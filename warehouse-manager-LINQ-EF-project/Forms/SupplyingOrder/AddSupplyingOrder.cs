using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_manager_LINQ_EF_project.Models;

namespace warehouse_manager_LINQ_EF_project.Forms.SupplyingOrder
{
    public partial class AddSupplyingOrder : Form
    {
        private readonly Model _model;

        private DateTimePicker _dtp;
        private Rectangle _rectangle;

        public AddSupplyingOrder()
        {
            InitializeComponent();

            _model = new Model();

            Initialize();
            this.Text = "Add New Suppling Order";
        }

        public AddSupplyingOrder(int orderId) : this()
        {
            var order = _model.SupplyingOrders.Find(orderId);

            if (order != null)
            {
                this.Text = $"Suppling Order Number: {order.Number} Details";

                dgvProducts.Visible = false;
                btnAdd.Visible = false;
                btnRemove.Visible = false;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                btnUpdate.Enabled = false;

                txtNumber.ReadOnly = true;
                dtpDate.Enabled = false;
                cbWarehouses.Enabled = false;
                cbProviders.Enabled = false;

                dgvSelectedItems.Location = new Point(20, dgvSelectedItems.Location.Y);
                dgvSelectedItems.Width = this.Width - 40;

                dgvSelectedItems.CellClick -= dgvSelectedItems_CellClick;
                dgvSelectedItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSelectedItems.RowHeadersVisible = false;

                txtNumber.Text = order.Number;
                dtpDate.Value = order.Date;
                cbWarehouses.SelectedItem = order.Warehouse;
                cbProviders.SelectedItem = order.Provider;

                foreach (var orderItem in order.Items)
                {
                    dgvSelectedItems.Rows.Add();
                    var row = dgvSelectedItems.Rows[dgvSelectedItems.Rows.Count - 1];

                    row.Cells[0].Value = orderItem.Product.Id;
                    row.Cells[1].Value = orderItem.Product.Name;
                    row.Cells[2].Value = orderItem.SuppliedQuantity;
                    ((DataGridViewComboBoxCell)row.Cells[3]).DataSource = orderItem.Product.Units.ToList();
                    ((DataGridViewComboBoxCell)row.Cells[3]).DisplayMember = "Name";
                    ((DataGridViewComboBoxCell)row.Cells[3]).ValueMember = "Id";
                    ((DataGridViewComboBoxCell)row.Cells[3]).ValueType = typeof(int);
                    ((DataGridViewComboBoxCell)row.Cells[3]).Value = orderItem.Unit.Id;
                    row.Cells[4].Value = orderItem.ProductionDate.ToString("yyyy-MM-dd");
                    row.Cells[5].Value = orderItem.Expiry;
                }

                dgvSelectedItems.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("invalid supplying order ID", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Initialize()
        {
            cbWarehouses.ValueMember = "Id";
            cbWarehouses.DisplayMember = "Name";
            cbWarehouses.DataSource = _model.Warehouses.ToList();

            cbProviders.DisplayMember = "Name";
            cbProviders.ValueMember = "Id";
            cbProviders.DataSource = _model.Providers.ToList();

            dgvProducts.DataSource = _model.Products.ToList();

            _dtp = new DateTimePicker();

            dgvSelectedItems.Controls.Add(_dtp);
            _dtp.Visible = false;
            _dtp.Format = DateTimePickerFormat.Custom;
            _dtp.TextChanged += new EventHandler(dtp_TextChange);
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnRemove_Click(object sender, EventArgs e)
        //{

        //}

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            dgvSelectedItems.Rows.Add();
            var row = dgvSelectedItems.Rows[dgvSelectedItems.Rows.Count - 1];
            var product = (Product)dgvProducts.SelectedRows[0].DataBoundItem;

            row.Cells[0].Value = product.Id;
            row.Cells[1].Value = product.Name;

            ((DataGridViewComboBoxCell)row.Cells[3]).DataSource = product.Units.ToList();
            ((DataGridViewComboBoxCell)row.Cells[3]).DisplayMember = "Name";
            ((DataGridViewComboBoxCell)row.Cells[3]).ValueMember = "Id";
            ((DataGridViewComboBoxCell)row.Cells[3]).ValueType = typeof(int);
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (dgvSelectedItems.SelectedRows.Count > 0)
            {
                dgvSelectedItems.Rows.Remove(dgvSelectedItems.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("No selected rows, select full row to remove", "Empty");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplyingOrder = new Models.SupplyingOrder
            {
                Number = txtNumber.Text,
                Date = dtpDate.Value.Date,
                Provider = (Provider)cbProviders.SelectedItem,
                Warehouse = (Models.Warehouse)cbWarehouses.SelectedItem,
                Items = new List<Item>()
            };

            for (int i = 0; i < dgvSelectedItems.Rows.Count; i++)
            {
                var row = dgvSelectedItems.Rows[i];

                int? unitId = (int?)((DataGridViewComboBoxCell)row.Cells[3]).Value;
                Unit unit = null;
                if (unitId != null)
                {
                    unit = _model.Units.Find(unitId.Value);
                }

                Models.Warehouse warehouse = (Models.Warehouse)cbWarehouses.SelectedItem;
                Provider provider = (Provider)cbProviders.SelectedItem;
                Product product = _model.Products.Find((int)row.Cells["ProductId"].Value);

                int suppliedQuantity = int.Parse(row.Cells["ProductId"].Value.ToString());
                int availableQuantity = suppliedQuantity * (unit?.Quantity ?? 1);

                DateTime productionDate = DateTime.Parse(row.Cells["ItemProductionDate"].Value.ToString());
                int expiry = int.Parse(row.Cells["Expiry"].Value.ToString());

                supplyingOrder.Items.Add(new Item()
                {
                    Warehouse = warehouse,
                    Provider = provider,
                    Product = product,
                    SuppliedQuantity = suppliedQuantity,
                    AvailableQuantity = availableQuantity,
                    ProductionDate = productionDate,
                    Expiry = expiry,
                    Unit = unit
                });
            }

            _model.SupplyingOrders.Add(supplyingOrder);
            _model.SaveChanges();
            MessageBox.Show("Saved", "Saved");
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvSelectedItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 4: // Column index of needed dateTimePicker cell

                    _rectangle = dgvSelectedItems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                    _dtp.Size = new Size(_rectangle.Width, _rectangle.Height); //  
                    _dtp.Location = new Point(_rectangle.X, _rectangle.Y); //  
                    _dtp.Visible = true;

                    break;
            }
        }

        private void dtp_TextChange(object sender, EventArgs e)
        {
            dgvSelectedItems.CurrentCell.Value = _dtp.Text.ToString();
        }

        private void dgvSelectedItems_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            _dtp.Visible = false;
        }

        private void dgvSelectedItems_Scroll(object sender, ScrollEventArgs e)
        {
            _dtp.Visible = false;
        }

        private void dgvSelectedItems_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 4: // Column index of needed dateTimePicker cell
                    _dtp.Visible = false;
                    break;
            }
        }
    }
}

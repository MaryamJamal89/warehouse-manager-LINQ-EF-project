using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace warehouse_manager_LINQ_EF_project.Forms.SupplyingOrder
{
    public partial class SupplyingOrdersList : Form
    {
        private readonly Model _model;

        public SupplyingOrdersList()
        {
            InitializeComponent();

            _model = new Model();

            _model.SupplyingOrders.Load();
            dgvOrders.DataSource = _model.SupplyingOrders.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddSupplyingOrder();
            form.ShowDialog();

            _model.SupplyingOrders.Load();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = ((Models.SupplyingOrder)dgvOrders.SelectedRows[0].DataBoundItem).Id;
                var form = new AddSupplyingOrder(orderId);
                form.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = ((Models.SupplyingOrder)dgvOrders.SelectedRows[0].DataBoundItem).Id;
            var form = new AddSupplyingOrder(orderId);
            form.Show();
        }
    }
}

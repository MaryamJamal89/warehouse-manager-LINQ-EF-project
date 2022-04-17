using System;
using System.Data.Entity;
using System.Windows.Forms;
using warehouse_manager_LINQ_EF_project.Forms.ExchangeOrder;
using warehouse_manager_LINQ_EF_project.Forms.SupplyingOrder;

namespace warehouse_manager_LINQ_EF_project.Forms.PaymentOrderM
{
    public partial class PaymentOrdersList : Form
    {
        private readonly Model _model;

        public PaymentOrdersList()
        {
            InitializeComponent();

            _model = new Model();

            _model.PaymentOrders.Load();
            dgvOrders.DataSource = _model.PaymentOrders.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditPaymentOrder();
            form.ShowDialog();

            _model.SupplyingOrders.Load();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = ((Models.PaymentOrder)dgvOrders.SelectedRows[0].DataBoundItem).Id;
                var form = new AddEditPaymentOrder(orderId);
                form.Show();
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = ((Models.PaymentOrder)dgvOrders.SelectedRows[0].DataBoundItem).Id;
            var form = new AddSupplyingOrder(orderId);
            form.Show();
        }
    }
}

using System;
using System.Data.Entity;
using System.Windows.Forms;
using warehouse_manager_LINQ_EF_project.Forms.ExchangeOrder;

namespace warehouse_manager_LINQ_EF_project.Forms.ExchangeOrder
{
    public partial class ExchangeOrdersList : Form
    {
        private readonly Model _model;

        public ExchangeOrdersList()
        {
            InitializeComponent();

            _model = new Model();

            _model.ExchangeOrders.Load();
            dgvOrders.DataSource = _model.ExchangeOrders.Local.ToBindingList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new AddEditExchangeOrder();
            form.ShowDialog();

            _model.SupplyingOrders.Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = ((Models.ExchangeOrder)dgvOrders.SelectedRows[0].DataBoundItem).Id;
                var form = new AddEditExchangeOrder(orderId);
                form.Show();
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = ((Models.ExchangeOrder)dgvOrders.SelectedRows[0].DataBoundItem).Id;
            var form = new AddEditExchangeOrder(orderId);
            form.Show();
        }
    }
}

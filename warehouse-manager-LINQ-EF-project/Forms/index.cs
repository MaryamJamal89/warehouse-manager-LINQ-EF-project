using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_manager_LINQ_EF_project.Forms.ExchangeOrder;
using warehouse_manager_LINQ_EF_project.Forms.PaymentOrderM;
using warehouse_manager_LINQ_EF_project.Forms.Person;
using warehouse_manager_LINQ_EF_project.Forms.Reports;
using warehouse_manager_LINQ_EF_project.Forms.SupplyingOrder;
using warehouse_manager_LINQ_EF_project.Forms.Warehouse;

namespace warehouse_manager_LINQ_EF_project
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void tsbViewWarehouses_Click(object sender, EventArgs e)
        {
            var form = new Warehouses();
            form.Show();
        }

        private void tsbViewProducts_Click(object sender, EventArgs e)
        {
            var form = new Products();
            form.Show();
        }

        private void tsbViewUnits_Click(object sender, EventArgs e)
        {
            var form = new Units();
            form.Show();
        }

        private void tsbViewProviders_Click(object sender, EventArgs e)
        {
            var form = new PersonList(PersonType.Provider);
            form.Show();
        }

        private void tsbViewCustomers_Click(object sender, EventArgs e)
        {
            var form = new PersonList(PersonType.Customer);
            form.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            var form = new ReportsList();
            form.Show();
        }

        private void itemsExpirationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ItemsExpirationReport();
            form.Show();
        }

        private void btnSupplyingOrders_Click(object sender, EventArgs e)
        {
            var form = new SupplyingOrdersList();
            form.Show();
        }

        private void btnNewSupplyingOrder_Click(object sender, EventArgs e)
        {
            var form = new AddSupplyingOrder();
            form.Show();
        }

        private void btnExchangeOrders_Click(object sender, EventArgs e)
        {
            var form = new ExchangeOrdersList();
            form.Show();
        }

        private void btnNewExchangeOrder_Click(object sender, EventArgs e)
        {
            var form = new AddEditExchangeOrder();
            form.Show();
        }

        private void btnPaymentOrders_Click(object sender, EventArgs e)
        {
            var form = new PaymentOrdersList();
            form.Show();
        }

        private void btnNewPaymentOrder_Click(object sender, EventArgs e)
        {
            var form = new AddEditPaymentOrder();
            form.Show();
        }        
    }
}

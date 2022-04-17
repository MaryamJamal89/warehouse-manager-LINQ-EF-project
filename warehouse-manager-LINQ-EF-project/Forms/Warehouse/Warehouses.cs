using System;
using System.Windows.Forms;
using System.Data.Entity;
using warehouse_manager_LINQ_EF_project.Models;

namespace warehouse_manager_LINQ_EF_project.Forms.Warehouse
{
    public partial class Warehouses : Form
    {
        private readonly Model _model;

        public Warehouses()
        {
            InitializeComponent();

            _model = new Model();

            _model.Warehouses.Load();
            dgvWarehouses.DataSource = _model.Warehouses.Local.ToBindingList();
            dgvWarehouses.Columns["Id"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_model.ChangeTracker.HasChanges())
            {
                _model.SaveChanges();
                MessageBox.Show("Changes saved successful", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No changes made, already up to date!", "Up to date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Warehouses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_model.ChangeTracker.HasChanges())
            {
                var result = MessageBox.Show("Do you want to save changes", "unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _model.SaveChanges();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

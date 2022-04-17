namespace warehouse_manager_LINQ_EF_project.Forms.SupplyingOrder
{
    partial class AddSupplyingOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplyingOrder));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSelectedItems = new System.Windows.Forms.DataGridView();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItemProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWarehouses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbProviders = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(300, 448);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 32);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(188)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(266, 191);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 65);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(188)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(266, 260);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(30, 65);
            this.btnRemove.TabIndex = 39;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ID";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ItemProductName
            // 
            this.ItemProductName.HeaderText = "Name";
            this.ItemProductName.MinimumWidth = 6;
            this.ItemProductName.Name = "ItemProductName";
            this.ItemProductName.ReadOnly = true;
            // 
            // dgvSelectedItems
            // 
            this.dgvSelectedItems.AllowUserToAddRows = false;
            this.dgvSelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.dgvSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ItemProductName,
            this.ItemQuantity,
            this.ProductUnit,
            this.ItemProductionDate,
            this.Expiry});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectedItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectedItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSelectedItems.Location = new System.Drawing.Point(300, 89);
            this.dgvSelectedItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSelectedItems.Name = "dgvSelectedItems";
            this.dgvSelectedItems.RowHeadersWidth = 51;
            this.dgvSelectedItems.RowTemplate.Height = 24;
            this.dgvSelectedItems.Size = new System.Drawing.Size(400, 340);
            this.dgvSelectedItems.TabIndex = 38;
            this.dgvSelectedItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedItems_CellClick);
            this.dgvSelectedItems.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedItems_CellLeave);
            this.dgvSelectedItems.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvSelectedItems_ColumnWidthChanged);
            this.dgvSelectedItems.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvSelectedItems_Scroll);
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "Quantity";
            this.ItemQuantity.MinimumWidth = 6;
            this.ItemQuantity.Name = "ItemQuantity";
            // 
            // ProductUnit
            // 
            this.ProductUnit.HeaderText = "Unit";
            this.ProductUnit.MinimumWidth = 6;
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ItemProductionDate
            // 
            this.ItemProductionDate.HeaderText = "ProductionDate";
            this.ItemProductionDate.MinimumWidth = 6;
            this.ItemProductionDate.Name = "ItemProductionDate";
            // 
            // Expiry
            // 
            this.Expiry.HeaderText = "Expiry (days)";
            this.Expiry.MinimumWidth = 6;
            this.Expiry.Name = "Expiry";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(520, 448);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 32);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Location = new System.Drawing.Point(38, 89);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(224, 340);
            this.dgvProducts.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(297, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Warehouse";
            // 
            // cbWarehouses
            // 
            this.cbWarehouses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbWarehouses.FormattingEnabled = true;
            this.cbWarehouses.Location = new System.Drawing.Point(300, 49);
            this.cbWarehouses.Margin = new System.Windows.Forms.Padding(2);
            this.cbWarehouses.Name = "cbWarehouses";
            this.cbWarehouses.Size = new System.Drawing.Size(180, 24);
            this.cbWarehouses.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(517, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Provider";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(159, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(162, 49);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 23);
            this.dtpDate.TabIndex = 30;
            // 
            // cbProviders
            // 
            this.cbProviders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbProviders.FormattingEnabled = true;
            this.cbProviders.Location = new System.Drawing.Point(520, 51);
            this.cbProviders.Margin = new System.Windows.Forms.Padding(2);
            this.cbProviders.Name = "cbProviders";
            this.cbProviders.Size = new System.Drawing.Size(180, 24);
            this.cbProviders.TabIndex = 29;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumber.Location = new System.Drawing.Point(38, 49);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 23);
            this.txtNumber.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Number";
            // 
            // AddSupplyingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvSelectedItems);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbWarehouses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbProviders);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSupplyingOrder";
            this.Text = "AddSupplyingOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemProductName;
        private System.Windows.Forms.DataGridView dgvSelectedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWarehouses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbProviders;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
    }
}
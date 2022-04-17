namespace warehouse_manager_LINQ_EF_project.Forms.ExchangeOrder
{
    partial class AddEditExchangeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditExchangeOrder));
            this.cbDestinationWarehouses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSourceWarehouses = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.itemProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProductUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvSelectedItems = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDestinationWarehouses
            // 
            this.cbDestinationWarehouses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDestinationWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationWarehouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDestinationWarehouses.FormattingEnabled = true;
            this.cbDestinationWarehouses.Location = new System.Drawing.Point(225, 57);
            this.cbDestinationWarehouses.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestinationWarehouses.Name = "cbDestinationWarehouses";
            this.cbDestinationWarehouses.Size = new System.Drawing.Size(180, 24);
            this.cbDestinationWarehouses.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(38, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Source Warehouse";
            // 
            // cbSourceWarehouses
            // 
            this.cbSourceWarehouses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSourceWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSourceWarehouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSourceWarehouses.FormattingEnabled = true;
            this.cbSourceWarehouses.Location = new System.Drawing.Point(41, 57);
            this.cbSourceWarehouses.Margin = new System.Windows.Forms.Padding(2);
            this.cbSourceWarehouses.Name = "cbSourceWarehouses";
            this.cbSourceWarehouses.Size = new System.Drawing.Size(180, 24);
            this.cbSourceWarehouses.TabIndex = 46;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(188)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(427, 49);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(543, 146);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(200, 174);
            this.dgvProducts.TabIndex = 41;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // itemProviderName
            // 
            this.itemProviderName.HeaderText = "Provider";
            this.itemProviderName.MinimumWidth = 6;
            this.itemProviderName.Name = "itemProviderName";
            this.itemProviderName.ReadOnly = true;
            // 
            // Expiry
            // 
            this.Expiry.HeaderText = "Expiry (days)";
            this.Expiry.MinimumWidth = 6;
            this.Expiry.Name = "Expiry";
            this.Expiry.ReadOnly = true;
            // 
            // ItemProductionDate
            // 
            this.ItemProductionDate.HeaderText = "ProductionDate";
            this.ItemProductionDate.MinimumWidth = 6;
            this.ItemProductionDate.Name = "ItemProductionDate";
            this.ItemProductionDate.ReadOnly = true;
            // 
            // cbProductUnit
            // 
            this.cbProductUnit.HeaderText = "Unit";
            this.cbProductUnit.MinimumWidth = 6;
            this.cbProductUnit.Name = "cbProductUnit";
            this.cbProductUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbProductUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "Quantity";
            this.ItemQuantity.MinimumWidth = 6;
            this.ItemQuantity.Name = "ItemQuantity";
            // 
            // ItemProductName
            // 
            this.ItemProductName.HeaderText = "Name";
            this.ItemProductName.MinimumWidth = 6;
            this.ItemProductName.Name = "ItemProductName";
            this.ItemProductName.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ID";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(222, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Destination Warehouse";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Location = new System.Drawing.Point(40, 100);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(490, 220);
            this.dgvItems.TabIndex = 45;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(188)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemove.Location = new System.Drawing.Point(481, 49);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 32);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvSelectedItems
            // 
            this.dgvSelectedItems.AllowUserToAddRows = false;
            this.dgvSelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(189)))), ((int)(((byte)(203)))));
            this.dgvSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ItemProductName,
            this.ItemQuantity,
            this.cbProductUnit,
            this.ItemProductionDate,
            this.Expiry,
            this.itemProviderName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectedItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelectedItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSelectedItems.Location = new System.Drawing.Point(40, 340);
            this.dgvSelectedItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSelectedItems.Name = "dgvSelectedItems";
            this.dgvSelectedItems.RowHeadersWidth = 51;
            this.dgvSelectedItems.RowTemplate.Height = 24;
            this.dgvSelectedItems.Size = new System.Drawing.Size(702, 160);
            this.dgvSelectedItems.TabIndex = 43;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(543, 49);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 32);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(645, 49);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 32);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(540, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(543, 119);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 37;
            // 
            // AddEditExchangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(784, 513);
            this.Controls.Add(this.cbDestinationWarehouses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSourceWarehouses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvSelectedItems);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditExchangeOrder";
            this.Text = "AddEditExchangeOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDestinationWarehouses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSourceWarehouses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemProductionDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvSelectedItems;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
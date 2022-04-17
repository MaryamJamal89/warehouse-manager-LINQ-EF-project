namespace warehouse_manager_LINQ_EF_project
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbViewWarehouses = new System.Windows.Forms.ToolStripButton();
            this.tsbViewProducts = new System.Windows.Forms.ToolStripButton();
            this.tsbViewUnits = new System.Windows.Forms.ToolStripButton();
            this.tsbViewProviders = new System.Windows.Forms.ToolStripButton();
            this.tsbViewCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemsExpirationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsAgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewExchangeOrder = new System.Windows.Forms.Button();
            this.btnExchangeOrders = new System.Windows.Forms.Button();
            this.btnNewPaymentOrder = new System.Windows.Forms.Button();
            this.btnNewSupplyingOrder = new System.Windows.Forms.Button();
            this.btnPaymentOrders = new System.Windows.Forms.Button();
            this.btnSupplyingOrders = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbViewWarehouses,
            this.tsbViewProducts,
            this.tsbViewUnits,
            this.tsbViewProviders,
            this.tsbViewCustomers,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbViewWarehouses
            // 
            this.tsbViewWarehouses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewWarehouses.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewWarehouses.Image")));
            this.tsbViewWarehouses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewWarehouses.Name = "tsbViewWarehouses";
            this.tsbViewWarehouses.Size = new System.Drawing.Size(99, 25);
            this.tsbViewWarehouses.Text = "Warehouses";
            this.tsbViewWarehouses.Click += new System.EventHandler(this.tsbViewWarehouses_Click);
            // 
            // tsbViewProducts
            // 
            this.tsbViewProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewProducts.Image")));
            this.tsbViewProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewProducts.Name = "tsbViewProducts";
            this.tsbViewProducts.Size = new System.Drawing.Size(75, 25);
            this.tsbViewProducts.Text = "Products";
            this.tsbViewProducts.Click += new System.EventHandler(this.tsbViewProducts_Click);
            // 
            // tsbViewUnits
            // 
            this.tsbViewUnits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewUnits.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewUnits.Image")));
            this.tsbViewUnits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewUnits.Name = "tsbViewUnits";
            this.tsbViewUnits.Size = new System.Drawing.Size(50, 25);
            this.tsbViewUnits.Text = "Units";
            this.tsbViewUnits.Click += new System.EventHandler(this.tsbViewUnits_Click);
            // 
            // tsbViewProviders
            // 
            this.tsbViewProviders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewProviders.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewProviders.Image")));
            this.tsbViewProviders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewProviders.Name = "tsbViewProviders";
            this.tsbViewProviders.Size = new System.Drawing.Size(80, 25);
            this.tsbViewProviders.Text = "Providers";
            this.tsbViewProviders.Click += new System.EventHandler(this.tsbViewProviders_Click);
            // 
            // tsbViewCustomers
            // 
            this.tsbViewCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbViewCustomers.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewCustomers.Image")));
            this.tsbViewCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewCustomers.Name = "tsbViewCustomers";
            this.tsbViewCustomers.Size = new System.Drawing.Size(89, 25);
            this.tsbViewCustomers.Text = "Customers";
            this.tsbViewCustomers.Click += new System.EventHandler(this.tsbViewCustomers_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsExpirationToolStripMenuItem,
            this.itemsAgesToolStripMenuItem,
            this.itemsMovementToolStripMenuItem,
            this.singleProductToolStripMenuItem,
            this.singleWarehouseToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 25);
            this.toolStripDropDownButton1.Text = "Report";
            // 
            // itemsExpirationToolStripMenuItem
            // 
            this.itemsExpirationToolStripMenuItem.Name = "itemsExpirationToolStripMenuItem";
            this.itemsExpirationToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.itemsExpirationToolStripMenuItem.Text = "Items Expiration";
            this.itemsExpirationToolStripMenuItem.Click += new System.EventHandler(this.itemsExpirationToolStripMenuItem_Click);
            // 
            // itemsAgesToolStripMenuItem
            // 
            this.itemsAgesToolStripMenuItem.Enabled = false;
            this.itemsAgesToolStripMenuItem.Name = "itemsAgesToolStripMenuItem";
            this.itemsAgesToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.itemsAgesToolStripMenuItem.Text = "Items Ages";
            // 
            // itemsMovementToolStripMenuItem
            // 
            this.itemsMovementToolStripMenuItem.Enabled = false;
            this.itemsMovementToolStripMenuItem.Name = "itemsMovementToolStripMenuItem";
            this.itemsMovementToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.itemsMovementToolStripMenuItem.Text = "Items Movement";
            // 
            // singleProductToolStripMenuItem
            // 
            this.singleProductToolStripMenuItem.Enabled = false;
            this.singleProductToolStripMenuItem.Name = "singleProductToolStripMenuItem";
            this.singleProductToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.singleProductToolStripMenuItem.Text = "Single Product";
            // 
            // singleWarehouseToolStripMenuItem
            // 
            this.singleWarehouseToolStripMenuItem.Enabled = false;
            this.singleWarehouseToolStripMenuItem.Name = "singleWarehouseToolStripMenuItem";
            this.singleWarehouseToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.singleWarehouseToolStripMenuItem.Text = "Single Warehouse";
            // 
            // btnNewExchangeOrder
            // 
            this.btnNewExchangeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnNewExchangeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewExchangeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewExchangeOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewExchangeOrder.Location = new System.Drawing.Point(385, 96);
            this.btnNewExchangeOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewExchangeOrder.Name = "btnNewExchangeOrder";
            this.btnNewExchangeOrder.Size = new System.Drawing.Size(180, 40);
            this.btnNewExchangeOrder.TabIndex = 13;
            this.btnNewExchangeOrder.Text = "New Exchange Order";
            this.btnNewExchangeOrder.UseVisualStyleBackColor = false;
            this.btnNewExchangeOrder.Click += new System.EventHandler(this.btnNewExchangeOrder_Click);
            // 
            // btnExchangeOrders
            // 
            this.btnExchangeOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnExchangeOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExchangeOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExchangeOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExchangeOrders.Location = new System.Drawing.Point(385, 55);
            this.btnExchangeOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnExchangeOrders.Name = "btnExchangeOrders";
            this.btnExchangeOrders.Size = new System.Drawing.Size(180, 40);
            this.btnExchangeOrders.TabIndex = 11;
            this.btnExchangeOrders.Text = "Exchange Orders";
            this.btnExchangeOrders.UseVisualStyleBackColor = false;
            this.btnExchangeOrders.Click += new System.EventHandler(this.btnExchangeOrders_Click);
            // 
            // btnNewPaymentOrder
            // 
            this.btnNewPaymentOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnNewPaymentOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPaymentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewPaymentOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewPaymentOrder.Location = new System.Drawing.Point(204, 96);
            this.btnNewPaymentOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewPaymentOrder.Name = "btnNewPaymentOrder";
            this.btnNewPaymentOrder.Size = new System.Drawing.Size(180, 40);
            this.btnNewPaymentOrder.TabIndex = 12;
            this.btnNewPaymentOrder.Text = "New Payment Order";
            this.btnNewPaymentOrder.UseVisualStyleBackColor = false;
            this.btnNewPaymentOrder.Click += new System.EventHandler(this.btnNewPaymentOrder_Click);
            // 
            // btnNewSupplyingOrder
            // 
            this.btnNewSupplyingOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnNewSupplyingOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSupplyingOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewSupplyingOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewSupplyingOrder.Location = new System.Drawing.Point(23, 96);
            this.btnNewSupplyingOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewSupplyingOrder.Name = "btnNewSupplyingOrder";
            this.btnNewSupplyingOrder.Size = new System.Drawing.Size(180, 40);
            this.btnNewSupplyingOrder.TabIndex = 10;
            this.btnNewSupplyingOrder.Text = "New Supplying Order";
            this.btnNewSupplyingOrder.UseVisualStyleBackColor = false;
            this.btnNewSupplyingOrder.Click += new System.EventHandler(this.btnNewSupplyingOrder_Click);
            // 
            // btnPaymentOrders
            // 
            this.btnPaymentOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnPaymentOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaymentOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPaymentOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPaymentOrders.Location = new System.Drawing.Point(204, 55);
            this.btnPaymentOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaymentOrders.Name = "btnPaymentOrders";
            this.btnPaymentOrders.Size = new System.Drawing.Size(180, 40);
            this.btnPaymentOrders.TabIndex = 9;
            this.btnPaymentOrders.Text = "Payment Orders";
            this.btnPaymentOrders.UseVisualStyleBackColor = false;
            this.btnPaymentOrders.Click += new System.EventHandler(this.btnPaymentOrders_Click);
            // 
            // btnSupplyingOrders
            // 
            this.btnSupplyingOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnSupplyingOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupplyingOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSupplyingOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSupplyingOrders.Location = new System.Drawing.Point(23, 55);
            this.btnSupplyingOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplyingOrders.Name = "btnSupplyingOrders";
            this.btnSupplyingOrders.Size = new System.Drawing.Size(180, 40);
            this.btnSupplyingOrders.TabIndex = 8;
            this.btnSupplyingOrders.Text = "Supplying Orders";
            this.btnSupplyingOrders.UseVisualStyleBackColor = false;
            this.btnSupplyingOrders.Click += new System.EventHandler(this.btnSupplyingOrders_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(584, 181);
            this.Controls.Add(this.btnNewExchangeOrder);
            this.Controls.Add(this.btnExchangeOrders);
            this.Controls.Add(this.btnNewPaymentOrder);
            this.Controls.Add(this.btnNewSupplyingOrder);
            this.Controls.Add(this.btnPaymentOrders);
            this.Controls.Add(this.btnSupplyingOrders);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "Warehouse Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbViewWarehouses;
        private System.Windows.Forms.ToolStripButton tsbViewProducts;
        private System.Windows.Forms.ToolStripButton tsbViewUnits;
        private System.Windows.Forms.ToolStripButton tsbViewProviders;
        private System.Windows.Forms.ToolStripButton tsbViewCustomers;
        private System.Windows.Forms.Button btnNewExchangeOrder;
        private System.Windows.Forms.Button btnExchangeOrders;
        private System.Windows.Forms.Button btnNewPaymentOrder;
        private System.Windows.Forms.Button btnNewSupplyingOrder;
        private System.Windows.Forms.Button btnPaymentOrders;
        private System.Windows.Forms.Button btnSupplyingOrders;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem itemsExpirationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsAgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsMovementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleWarehouseToolStripMenuItem;
    }
}


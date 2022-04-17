namespace warehouse_manager_LINQ_EF_project.Forms.Reports
{
    partial class ItemsExpirationReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsExpirationReport));
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.nUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.nUpDownMonths = new System.Windows.Forms.NumericUpDown();
            this.nUpDownYears = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownYears)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(40, 70);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(255, 20);
            this.lblHeader.TabIndex = 22;
            this.lblHeader.Text = "Items having expiration daty before";
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
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(700, 330);
            this.dgvItems.TabIndex = 21;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(132)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(520, 30);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(220, 28);
            this.btnShow.TabIndex = 20;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // nUpDownDays
            // 
            this.nUpDownDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownDays.Location = new System.Drawing.Point(365, 30);
            this.nUpDownDays.Margin = new System.Windows.Forms.Padding(2);
            this.nUpDownDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nUpDownDays.Name = "nUpDownDays";
            this.nUpDownDays.Size = new System.Drawing.Size(75, 23);
            this.nUpDownDays.TabIndex = 19;
            this.nUpDownDays.ValueChanged += new System.EventHandler(this.nUpDown_ValueChanged);
            // 
            // nUpDownMonths
            // 
            this.nUpDownMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownMonths.Location = new System.Drawing.Point(280, 30);
            this.nUpDownMonths.Margin = new System.Windows.Forms.Padding(2);
            this.nUpDownMonths.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nUpDownMonths.Name = "nUpDownMonths";
            this.nUpDownMonths.Size = new System.Drawing.Size(75, 23);
            this.nUpDownMonths.TabIndex = 18;
            this.nUpDownMonths.ValueChanged += new System.EventHandler(this.nUpDown_ValueChanged);
            // 
            // nUpDownYears
            // 
            this.nUpDownYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownYears.Location = new System.Drawing.Point(195, 30);
            this.nUpDownYears.Margin = new System.Windows.Forms.Padding(2);
            this.nUpDownYears.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUpDownYears.Name = "nUpDownYears";
            this.nUpDownYears.Size = new System.Drawing.Size(75, 23);
            this.nUpDownYears.TabIndex = 17;
            this.nUpDownYears.ValueChanged += new System.EventHandler(this.nUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Months";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Years";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Time until expiration";
            // 
            // ItemsExpirationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.nUpDownDays);
            this.Controls.Add(this.nUpDownMonths);
            this.Controls.Add(this.nUpDownYears);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemsExpirationReport";
            this.Text = "ItemsExpirationReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.NumericUpDown nUpDownDays;
        private System.Windows.Forms.NumericUpDown nUpDownMonths;
        private System.Windows.Forms.NumericUpDown nUpDownYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
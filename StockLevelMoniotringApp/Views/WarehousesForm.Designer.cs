namespace FormUI.Views
{
    partial class WarehousesForm
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
            this.warehousesGridView = new System.Windows.Forms.DataGridView();
            this.WarehousesRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.WarehousesDelete = new System.Windows.Forms.Button();
            this.WarehousesAddName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddressButton = new System.Windows.Forms.Button();
            this.WarehousesAddCompany = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // warehousesGridView
            // 
            this.warehousesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.warehousesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warehousesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehousesGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.warehousesGridView.Location = new System.Drawing.Point(0, 0);
            this.warehousesGridView.Margin = new System.Windows.Forms.Padding(0);
            this.warehousesGridView.Name = "warehousesGridView";
            this.warehousesGridView.Size = new System.Drawing.Size(796, 729);
            this.warehousesGridView.TabIndex = 12;
            this.warehousesGridView.TabStop = false;
            // 
            // WarehousesRefresh
            // 
            this.WarehousesRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.WarehousesRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarehousesRefresh.Location = new System.Drawing.Point(3, 3);
            this.WarehousesRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.WarehousesRefresh.Name = "WarehousesRefresh";
            this.WarehousesRefresh.Size = new System.Drawing.Size(206, 60);
            this.WarehousesRefresh.TabIndex = 0;
            this.WarehousesRefresh.Text = "Refresh";
            this.WarehousesRefresh.UseVisualStyleBackColor = true;
            this.WarehousesRefresh.Click += new System.EventHandler(this.WarehousesRefresh_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(3, 265);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 60);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.WarehousesAdd_Click);
            // 
            // WarehousesDelete
            // 
            this.WarehousesDelete.BackColor = System.Drawing.Color.LightCoral;
            this.WarehousesDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WarehousesDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarehousesDelete.Location = new System.Drawing.Point(3, 666);
            this.WarehousesDelete.Margin = new System.Windows.Forms.Padding(0);
            this.WarehousesDelete.Name = "WarehousesDelete";
            this.WarehousesDelete.Size = new System.Drawing.Size(206, 60);
            this.WarehousesDelete.TabIndex = 10;
            this.WarehousesDelete.Text = "Delete Selected";
            this.WarehousesDelete.UseVisualStyleBackColor = false;
            this.WarehousesDelete.Click += new System.EventHandler(this.WarehousesDelete_Click);
            // 
            // WarehousesAddName
            // 
            this.WarehousesAddName.Location = new System.Drawing.Point(6, 49);
            this.WarehousesAddName.MaxLength = 300;
            this.WarehousesAddName.Name = "WarehousesAddName";
            this.WarehousesAddName.Size = new System.Drawing.Size(194, 25);
            this.WarehousesAddName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.WarehousesRefresh);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.WarehousesDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(796, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(212, 729);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddressButton);
            this.groupBox1.Controls.Add(this.WarehousesAddCompany);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.WarehousesAddName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // AddressButton
            // 
            this.AddressButton.Location = new System.Drawing.Point(6, 97);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(194, 23);
            this.AddressButton.TabIndex = 10;
            this.AddressButton.Text = "Wybierz adres";
            this.AddressButton.UseVisualStyleBackColor = true;
            // 
            // WarehousesAddCompany
            // 
            this.WarehousesAddCompany.FormattingEnabled = true;
            this.WarehousesAddCompany.Location = new System.Drawing.Point(6, 145);
            this.WarehousesAddCompany.Name = "WarehousesAddCompany";
            this.WarehousesAddCompany.Size = new System.Drawing.Size(191, 25);
            this.WarehousesAddCompany.TabIndex = 9;
            // 
            // WarehousesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.warehousesGridView);
            this.Name = "WarehousesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouses";
            ((System.ComponentModel.ISupportInitialize)(this.warehousesGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView warehousesGridView;
        private System.Windows.Forms.Button WarehousesRefresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button WarehousesDelete;
        private System.Windows.Forms.TextBox WarehousesAddName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox WarehousesAddCompany;
        private System.Windows.Forms.Button AddressButton;
    }
}
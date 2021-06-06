namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.customersButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.CategoriesButton = new System.Windows.Forms.Button();
            this.WarehousesButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersButton
            // 
            this.customersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customersButton.Location = new System.Drawing.Point(3, 183);
            this.customersButton.Margin = new System.Windows.Forms.Padding(0);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(206, 60);
            this.customersButton.TabIndex = 4;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.productsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsButton.Location = new System.Drawing.Point(3, 63);
            this.productsButton.Margin = new System.Windows.Forms.Padding(0);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(206, 60);
            this.productsButton.TabIndex = 2;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ordersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ordersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersButton.Location = new System.Drawing.Point(3, 3);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(0);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(206, 60);
            this.ordersButton.TabIndex = 1;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // CategoriesButton
            // 
            this.CategoriesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CategoriesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesButton.Location = new System.Drawing.Point(3, 123);
            this.CategoriesButton.Margin = new System.Windows.Forms.Padding(0);
            this.CategoriesButton.Name = "CategoriesButton";
            this.CategoriesButton.Size = new System.Drawing.Size(206, 60);
            this.CategoriesButton.TabIndex = 3;
            this.CategoriesButton.Text = "Categories";
            this.CategoriesButton.UseVisualStyleBackColor = true;
            this.CategoriesButton.Click += new System.EventHandler(this.CategoriesButton_Click);
            // 
            // WarehousesButton
            // 
            this.WarehousesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.WarehousesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WarehousesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarehousesButton.Location = new System.Drawing.Point(3, 243);
            this.WarehousesButton.Margin = new System.Windows.Forms.Padding(0);
            this.WarehousesButton.Name = "WarehousesButton";
            this.WarehousesButton.Size = new System.Drawing.Size(206, 60);
            this.WarehousesButton.TabIndex = 5;
            this.WarehousesButton.Text = "Warehouses";
            this.WarehousesButton.UseVisualStyleBackColor = true;
            this.WarehousesButton.Click += new System.EventHandler(this.WarehousesButton_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.Controls.Add(this.userLabel);
            this.menuPanel.Controls.Add(this.WarehousesButton);
            this.menuPanel.Controls.Add(this.customersButton);
            this.menuPanel.Controls.Add(this.CategoriesButton);
            this.menuPanel.Controls.Add(this.productsButton);
            this.menuPanel.Controls.Add(this.ordersButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(3);
            this.menuPanel.Size = new System.Drawing.Size(212, 561);
            this.menuPanel.TabIndex = 6;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(69, 534);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(63, 15);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "User Login";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userLabel.Visible = false;
            // 
            // productsGridView
            // 
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.productsGridView.Location = new System.Drawing.Point(212, 0);
            this.productsGridView.Margin = new System.Windows.Forms.Padding(0);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.RowTemplate.Height = 25;
            this.productsGridView.Size = new System.Drawing.Size(572, 561);
            this.productsGridView.TabIndex = 7;
            this.productsGridView.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.menuPanel);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Level App";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button CategoriesButton;
        private System.Windows.Forms.Button WarehousesButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView productsGridView;
    }
}
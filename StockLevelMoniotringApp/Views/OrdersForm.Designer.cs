
namespace FormUI.Views
{
    partial class OrdersForm
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
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.SubtotalBox = new System.Windows.Forms.NumericUpDown();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressButton = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.CompanyID = new System.Windows.Forms.ComboBox();
            this.StatusID = new System.Windows.Forms.ComboBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtotalBox)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrdersGridView.Location = new System.Drawing.Point(0, 0);
            this.OrdersGridView.Margin = new System.Windows.Forms.Padding(0);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowTemplate.Height = 25;
            this.OrdersGridView.Size = new System.Drawing.Size(796, 729);
            this.OrdersGridView.TabIndex = 17;
            this.OrdersGridView.TabStop = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshButton.Location = new System.Drawing.Point(3, 3);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(206, 60);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(3, 508);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(206, 60);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(3, 666);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(206, 60);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(6, 103);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(194, 77);
            this.InfoBox.TabIndex = 5;
            this.InfoBox.Text = "";
            // 
            // SubtotalBox
            // 
            this.SubtotalBox.DecimalPlaces = 2;
            this.SubtotalBox.Location = new System.Drawing.Point(6, 55);
            this.SubtotalBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.SubtotalBox.Name = "SubtotalBox";
            this.SubtotalBox.Size = new System.Drawing.Size(194, 25);
            this.SubtotalBox.TabIndex = 3;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(75, 35);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(56, 17);
            this.Subtotal.TabIndex = 2;
            this.Subtotal.Text = "Subtotal";
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Location = new System.Drawing.Point(66, 83);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(75, 17);
            this.Information.TabIndex = 4;
            this.Information.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Client number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Company";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Order Status";
            // 
            // AddressButton
            // 
            this.AddressButton.FlatAppearance.BorderSize = 0;
            this.AddressButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddressButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddressButton.Location = new System.Drawing.Point(6, 231);
            this.AddressButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(194, 27);
            this.AddressButton.TabIndex = 8;
            this.AddressButton.Text = "Select";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // UserID
            // 
            this.UserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(6, 281);
            this.UserID.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(194, 25);
            this.UserID.TabIndex = 10;
            // 
            // CompanyID
            // 
            this.CompanyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyID.FormattingEnabled = true;
            this.CompanyID.Location = new System.Drawing.Point(6, 329);
            this.CompanyID.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(194, 25);
            this.CompanyID.TabIndex = 12;
            // 
            // StatusID
            // 
            this.StatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusID.FormattingEnabled = true;
            this.StatusID.Location = new System.Drawing.Point(6, 377);
            this.StatusID.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.StatusID.Name = "StatusID";
            this.StatusID.Size = new System.Drawing.Size(194, 25);
            this.StatusID.TabIndex = 14;
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Enabled = false;
            this.AddressBox.Location = new System.Drawing.Point(6, 203);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(194, 25);
            this.AddressBox.TabIndex = 7;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.Controls.Add(this.AddButton);
            this.menuPanel.Controls.Add(this.groupBox1);
            this.menuPanel.Controls.Add(this.RefreshButton);
            this.menuPanel.Controls.Add(this.DeleteButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuPanel.Location = new System.Drawing.Point(796, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(3);
            this.menuPanel.Size = new System.Drawing.Size(212, 729);
            this.menuPanel.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Subtotal);
            this.groupBox1.Controls.Add(this.AddressBox);
            this.groupBox1.Controls.Add(this.SubtotalBox);
            this.groupBox1.Controls.Add(this.CompanyID);
            this.groupBox1.Controls.Add(this.Information);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.InfoBox);
            this.groupBox1.Controls.Add(this.UserID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddressButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.OrdersGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "OrdersForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtotalBox)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.NumericUpDown SubtotalBox;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddressButton;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.ComboBox CompanyID;
        private System.Windows.Forms.ComboBox StatusID;
        public System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
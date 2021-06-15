
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
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtotalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(2, 1);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowTemplate.Height = 25;
            this.OrdersGridView.Size = new System.Drawing.Size(672, 348);
            this.OrdersGridView.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(786, 23);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(139, 79);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(795, 564);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 56);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(795, 642);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 66);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(742, 203);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(150, 70);
            this.InfoBox.TabIndex = 4;
            this.InfoBox.Text = "";
            // 
            // SubtotalBox
            // 
            this.SubtotalBox.Location = new System.Drawing.Point(742, 152);
            this.SubtotalBox.Name = "SubtotalBox";
            this.SubtotalBox.Size = new System.Drawing.Size(160, 23);
            this.SubtotalBox.TabIndex = 5;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(742, 125);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(51, 15);
            this.Subtotal.TabIndex = 11;
            this.Subtotal.Text = "Subtotal";
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Location = new System.Drawing.Point(742, 178);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(70, 15);
            this.Information.TabIndex = 12;
            this.Information.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Client number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Company";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Order Status";
            // 
            // AddressButton
            // 
            this.AddressButton.Location = new System.Drawing.Point(742, 326);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(194, 23);
            this.AddressButton.TabIndex = 17;
            this.AddressButton.Text = "Choose address";
            this.AddressButton.UseVisualStyleBackColor = true;
            this.AddressButton.Click += new System.EventHandler(this.AddressButton_Click);
            // 
            // UserID
            // 
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(742, 393);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(121, 23);
            this.UserID.TabIndex = 18;
            // 
            // CompanyID
            // 
            this.CompanyID.FormattingEnabled = true;
            this.CompanyID.Location = new System.Drawing.Point(742, 437);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(121, 23);
            this.CompanyID.TabIndex = 19;
            // 
            // StatusID
            // 
            this.StatusID.FormattingEnabled = true;
            this.StatusID.Location = new System.Drawing.Point(742, 490);
            this.StatusID.Name = "StatusID";
            this.StatusID.Size = new System.Drawing.Size(121, 23);
            this.StatusID.TabIndex = 20;
            // 
            // AddressBox
            // 
            this.AddressBox.Enabled = false;
            this.AddressBox.Location = new System.Drawing.Point(739, 294);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(197, 23);
            this.AddressBox.TabIndex = 21;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.StatusID);
            this.Controls.Add(this.CompanyID);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.AddressButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.SubtotalBox);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RefreshButton);
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
            this.Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtotalBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
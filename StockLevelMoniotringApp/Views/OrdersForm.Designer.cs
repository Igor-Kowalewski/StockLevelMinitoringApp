
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
            this.AddressID = new System.Windows.Forms.NumericUpDown();
            this.UserID = new System.Windows.Forms.NumericUpDown();
            this.CompanyID = new System.Windows.Forms.NumericUpDown();
            this.StatusID = new System.Windows.Forms.NumericUpDown();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtotalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusID)).BeginInit();
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
            // AddressID
            // 
            this.AddressID.Location = new System.Drawing.Point(742, 301);
            this.AddressID.Name = "AddressID";
            this.AddressID.Size = new System.Drawing.Size(161, 23);
            this.AddressID.TabIndex = 6;
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(742, 356);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(161, 23);
            this.UserID.TabIndex = 7;
            // 
            // CompanyID
            // 
            this.CompanyID.Location = new System.Drawing.Point(742, 409);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(164, 23);
            this.CompanyID.TabIndex = 8;
            // 
            // StatusID
            // 
            this.StatusID.Location = new System.Drawing.Point(743, 461);
            this.StatusID.Name = "StatusID";
            this.StatusID.Size = new System.Drawing.Size(163, 23);
            this.StatusID.TabIndex = 9;
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
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Order Address ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Company ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Order Status ID";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.StatusID);
            this.Controls.Add(this.CompanyID);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.AddressID);
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
            ((System.ComponentModel.ISupportInitialize)(this.AddressID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusID)).EndInit();
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
        private System.Windows.Forms.NumericUpDown AddressID;
        private System.Windows.Forms.NumericUpDown UserID;
        private System.Windows.Forms.NumericUpDown CompanyID;
        private System.Windows.Forms.NumericUpDown StatusID;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

namespace FormUI.Views
{
    partial class AddressForm
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
            this.AddressGridView = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.ZipBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.NumericUpDown();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addAddressGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.addAddressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressGridView
            // 
            this.AddressGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddressGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddressGridView.Location = new System.Drawing.Point(0, 0);
            this.AddressGridView.Margin = new System.Windows.Forms.Padding(0);
            this.AddressGridView.Name = "AddressGridView";
            this.AddressGridView.RowTemplate.Height = 25;
            this.AddressGridView.Size = new System.Drawing.Size(587, 561);
            this.AddressGridView.TabIndex = 0;
            this.AddressGridView.TabStop = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshButton.Location = new System.Drawing.Point(3, 3);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(194, 60);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(3, 375);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(194, 60);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(3, 498);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(194, 60);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(6, 44);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(182, 25);
            this.StreetBox.TabIndex = 6;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(6, 144);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(182, 25);
            this.CityBox.TabIndex = 10;
            // 
            // ZipBox
            // 
            this.ZipBox.Location = new System.Drawing.Point(6, 194);
            this.ZipBox.Mask = "00-000";
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(182, 25);
            this.ZipBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Street";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "House number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Zip code";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(6, 94);
            this.NumberBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(182, 25);
            this.NumberBox.TabIndex = 8;
            // 
            // ChooseButton
            // 
            this.ChooseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChooseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChooseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseButton.Location = new System.Drawing.Point(3, 63);
            this.ChooseButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(194, 60);
            this.ChooseButton.TabIndex = 3;
            this.ChooseButton.Text = "Select";
            this.ChooseButton.UseVisualStyleBackColor = false;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.addAddressGroupBox);
            this.panel1.Controls.Add(this.ChooseButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(584, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 1;
            // 
            // addAddressGroupBox
            // 
            this.addAddressGroupBox.Controls.Add(this.label1);
            this.addAddressGroupBox.Controls.Add(this.StreetBox);
            this.addAddressGroupBox.Controls.Add(this.NumberBox);
            this.addAddressGroupBox.Controls.Add(this.CityBox);
            this.addAddressGroupBox.Controls.Add(this.label4);
            this.addAddressGroupBox.Controls.Add(this.ZipBox);
            this.addAddressGroupBox.Controls.Add(this.label3);
            this.addAddressGroupBox.Controls.Add(this.label2);
            this.addAddressGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAddressGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAddressGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAddressGroupBox.Location = new System.Drawing.Point(3, 123);
            this.addAddressGroupBox.Name = "addAddressGroupBox";
            this.addAddressGroupBox.Size = new System.Drawing.Size(194, 246);
            this.addAddressGroupBox.TabIndex = 4;
            this.addAddressGroupBox.TabStop = false;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddressGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AddressForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addresses";
            ((System.ComponentModel.ISupportInitialize)(this.AddressGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.addAddressGroupBox.ResumeLayout(false);
            this.addAddressGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AddressGridView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.MaskedTextBox ZipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumberBox;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox addAddressGroupBox;
    }
}
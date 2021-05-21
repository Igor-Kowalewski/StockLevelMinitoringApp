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
            this.WarehousesGridView = new System.Windows.Forms.DataGridView();
            this.WarehousesRefresh = new System.Windows.Forms.Button();
            this.WarehousesListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.WarehousesDelete = new System.Windows.Forms.Button();
            this.WarehousesAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WarehousesAddAddress = new System.Windows.Forms.NumericUpDown();
            this.WarehousesAddCompany = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesAddAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesAddCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // WarehousesGridView
            // 
            this.WarehousesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehousesGridView.Location = new System.Drawing.Point(8, 8);
            this.WarehousesGridView.Name = "WarehousesGridView";
            this.WarehousesGridView.Size = new System.Drawing.Size(843, 303);
            this.WarehousesGridView.TabIndex = 0;
            // 
            // WarehousesRefresh
            // 
            this.WarehousesRefresh.Location = new System.Drawing.Point(254, 317);
            this.WarehousesRefresh.Name = "WarehousesRefresh";
            this.WarehousesRefresh.Size = new System.Drawing.Size(80, 50);
            this.WarehousesRefresh.TabIndex = 1;
            this.WarehousesRefresh.Text = "Refresh";
            this.WarehousesRefresh.UseVisualStyleBackColor = true;
            this.WarehousesRefresh.Click += new System.EventHandler(this.WarehousesRefresh_Click);
            // 
            // WarehousesListBox
            // 
            this.WarehousesListBox.FormattingEnabled = true;
            this.WarehousesListBox.ItemHeight = 15;
            this.WarehousesListBox.Location = new System.Drawing.Point(8, 317);
            this.WarehousesListBox.Name = "WarehousesListBox";
            this.WarehousesListBox.Size = new System.Drawing.Size(240, 139);
            this.WarehousesListBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.WarehousesAdd_Click);
            // 
            // WarehousesDelete
            // 
            this.WarehousesDelete.Location = new System.Drawing.Point(254, 406);
            this.WarehousesDelete.Name = "WarehousesDelete";
            this.WarehousesDelete.Size = new System.Drawing.Size(80, 50);
            this.WarehousesDelete.TabIndex = 4;
            this.WarehousesDelete.Text = "Delete Selected";
            this.WarehousesDelete.UseVisualStyleBackColor = true;
            this.WarehousesDelete.Click += new System.EventHandler(this.WarehousesDelete_Click);
            // 
            // WarehousesAddName
            // 
            this.WarehousesAddName.Location = new System.Drawing.Point(473, 370);
            this.WarehousesAddName.Name = "WarehousesAddName";
            this.WarehousesAddName.Size = new System.Drawing.Size(113, 23);
            this.WarehousesAddName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add new product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address ID:";
            // 
            // WarehousesAddAddress
            // 
            this.WarehousesAddAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.WarehousesAddAddress.Location = new System.Drawing.Point(473, 422);
            this.WarehousesAddAddress.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WarehousesAddAddress.Name = "WarehousesAddAddress";
            this.WarehousesAddAddress.Size = new System.Drawing.Size(120, 23);
            this.WarehousesAddAddress.TabIndex = 9;
            // 
            // WarehousesAddCompany
            // 
            this.WarehousesAddCompany.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.WarehousesAddCompany.Location = new System.Drawing.Point(473, 470);
            this.WarehousesAddCompany.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WarehousesAddCompany.Name = "WarehousesAddCompany";
            this.WarehousesAddCompany.Size = new System.Drawing.Size(120, 23);
            this.WarehousesAddCompany.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company ID:";
            // 
            // WarehousesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WarehousesAddCompany);
            this.Controls.Add(this.WarehousesAddAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarehousesAddName);
            this.Controls.Add(this.WarehousesDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WarehousesListBox);
            this.Controls.Add(this.WarehousesRefresh);
            this.Controls.Add(this.WarehousesGridView);
            this.Name = "WarehousesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehousesForm";
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesAddAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehousesAddCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WarehousesGridView;
        private System.Windows.Forms.Button WarehousesRefresh;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button WarehousesDelete;
        private System.Windows.Forms.TextBox WarehousesAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WarehousesAddAddress;
        private System.Windows.Forms.ListBox WarehousesListBox;
        private System.Windows.Forms.NumericUpDown WarehousesAddCompany;
        private System.Windows.Forms.Label label4;
    }
}
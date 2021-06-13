
namespace FormUI.Views
{
    partial class ProductsForm
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
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.ProductsRefresh = new System.Windows.Forms.Button();
            this.ProductsAdd = new System.Windows.Forms.Button();
            this.ProductsDelete = new System.Windows.Forms.Button();
            this.ProductsAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsAddDesc = new System.Windows.Forms.RichTextBox();
            this.ProductsAddPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.addProductGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsAddCat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsAddPrice)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.addProductGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsGridView
            // 
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.productsGridView.Location = new System.Drawing.Point(0, 0);
            this.productsGridView.Margin = new System.Windows.Forms.Padding(0);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.Size = new System.Drawing.Size(796, 729);
            this.productsGridView.TabIndex = 13;
            this.productsGridView.TabStop = false;
            // 
            // ProductsRefresh
            // 
            this.ProductsRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsRefresh.FlatAppearance.BorderSize = 0;
            this.ProductsRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductsRefresh.Location = new System.Drawing.Point(3, 3);
            this.ProductsRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsRefresh.Name = "ProductsRefresh";
            this.ProductsRefresh.Size = new System.Drawing.Size(206, 60);
            this.ProductsRefresh.TabIndex = 0;
            this.ProductsRefresh.Text = "Refresh";
            this.ProductsRefresh.UseVisualStyleBackColor = true;
            this.ProductsRefresh.Click += new System.EventHandler(this.ProductsRefresh_Click);
            // 
            // ProductsAdd
            // 
            this.ProductsAdd.BackColor = System.Drawing.Color.LightGreen;
            this.ProductsAdd.FlatAppearance.BorderSize = 0;
            this.ProductsAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductsAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductsAdd.Location = new System.Drawing.Point(3, 360);
            this.ProductsAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsAdd.Name = "ProductsAdd";
            this.ProductsAdd.Size = new System.Drawing.Size(206, 60);
            this.ProductsAdd.TabIndex = 10;
            this.ProductsAdd.Text = "Add";
            this.ProductsAdd.UseVisualStyleBackColor = false;
            this.ProductsAdd.Click += new System.EventHandler(this.ProductsAdd_Click);
            // 
            // ProductsDelete
            // 
            this.ProductsDelete.BackColor = System.Drawing.Color.LightCoral;
            this.ProductsDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProductsDelete.FlatAppearance.BorderSize = 0;
            this.ProductsDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductsDelete.Location = new System.Drawing.Point(3, 666);
            this.ProductsDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsDelete.Name = "ProductsDelete";
            this.ProductsDelete.Size = new System.Drawing.Size(206, 60);
            this.ProductsDelete.TabIndex = 11;
            this.ProductsDelete.Text = "Delete Selected";
            this.ProductsDelete.UseVisualStyleBackColor = false;
            this.ProductsDelete.Click += new System.EventHandler(this.ProductsDelete_Click);
            // 
            // ProductsAddName
            // 
            this.ProductsAddName.Location = new System.Drawing.Point(6, 44);
            this.ProductsAddName.Name = "ProductsAddName";
            this.ProductsAddName.Size = new System.Drawing.Size(194, 25);
            this.ProductsAddName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // ProductsAddDesc
            // 
            this.ProductsAddDesc.Location = new System.Drawing.Point(6, 140);
            this.ProductsAddDesc.MaxLength = 300;
            this.ProductsAddDesc.Name = "ProductsAddDesc";
            this.ProductsAddDesc.Size = new System.Drawing.Size(194, 84);
            this.ProductsAddDesc.TabIndex = 7;
            this.ProductsAddDesc.Text = "";
            // 
            // ProductsAddPrice
            // 
            this.ProductsAddPrice.DecimalPlaces = 2;
            this.ProductsAddPrice.Location = new System.Drawing.Point(6, 92);
            this.ProductsAddPrice.Name = "ProductsAddPrice";
            this.ProductsAddPrice.Size = new System.Drawing.Size(194, 25);
            this.ProductsAddPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category ID";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.Controls.Add(this.addProductGroupBox);
            this.menuPanel.Controls.Add(this.ProductsRefresh);
            this.menuPanel.Controls.Add(this.ProductsDelete);
            this.menuPanel.Controls.Add(this.ProductsAdd);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuPanel.Location = new System.Drawing.Point(796, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(3);
            this.menuPanel.Size = new System.Drawing.Size(212, 729);
            this.menuPanel.TabIndex = 12;
            // 
            // addProductGroupBox
            // 
            this.addProductGroupBox.Controls.Add(this.ProductsAddCat);
            this.addProductGroupBox.Controls.Add(this.label1);
            this.addProductGroupBox.Controls.Add(this.ProductsAddName);
            this.addProductGroupBox.Controls.Add(this.label2);
            this.addProductGroupBox.Controls.Add(this.ProductsAddPrice);
            this.addProductGroupBox.Controls.Add(this.label4);
            this.addProductGroupBox.Controls.Add(this.label3);
            this.addProductGroupBox.Controls.Add(this.ProductsAddDesc);
            this.addProductGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProductGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProductGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addProductGroupBox.Location = new System.Drawing.Point(3, 63);
            this.addProductGroupBox.Name = "addProductGroupBox";
            this.addProductGroupBox.Size = new System.Drawing.Size(206, 294);
            this.addProductGroupBox.TabIndex = 1;
            this.addProductGroupBox.TabStop = false;
            // 
            // ProductsAddCat
            // 
            this.ProductsAddCat.FormattingEnabled = true;
            this.ProductsAddCat.Location = new System.Drawing.Point(6, 256);
            this.ProductsAddCat.Name = "ProductsAddCat";
            this.ProductsAddCat.Size = new System.Drawing.Size(191, 25);
            this.ProductsAddCat.TabIndex = 12;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.productsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "ProductsForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsAddPrice)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.addProductGroupBox.ResumeLayout(false);
            this.addProductGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Button ProductsRefresh;
        private System.Windows.Forms.Button ProductsAdd;
        private System.Windows.Forms.Button ProductsDelete;
        private System.Windows.Forms.TextBox ProductsAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ProductsAddDesc;
        private System.Windows.Forms.NumericUpDown ProductsAddPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.GroupBox addProductGroupBox;
        private System.Windows.Forms.ComboBox ProductsAddCat;
    }
}
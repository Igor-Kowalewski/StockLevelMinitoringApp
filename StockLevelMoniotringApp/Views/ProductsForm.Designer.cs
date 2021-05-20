
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
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductsRefresh = new System.Windows.Forms.Button();
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.ProductsAdd = new System.Windows.Forms.Button();
            this.ProductsDelete = new System.Windows.Forms.Button();
            this.ProductsAddName = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsAddDesc = new System.Windows.Forms.RichTextBox();
            this.ProductsAddPrice = new System.Windows.Forms.NumericUpDown();
            this.ProductsAddCat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsAddPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsAddCat)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(843, 303);
            this.ProductsGridView.TabIndex = 0;
            // 
            // ProductsRefresh
            // 
            this.ProductsRefresh.Location = new System.Drawing.Point(258, 321);
            this.ProductsRefresh.Name = "ProductsRefresh";
            this.ProductsRefresh.Size = new System.Drawing.Size(80, 50);
            this.ProductsRefresh.TabIndex = 1;
            this.ProductsRefresh.Text = "Refresh";
            this.ProductsRefresh.UseVisualStyleBackColor = true;
            this.ProductsRefresh.Click += new System.EventHandler(this.ProductsRefresh_Click);
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.ItemHeight = 15;
            this.ProductsListBox.Location = new System.Drawing.Point(12, 321);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(240, 139);
            this.ProductsListBox.TabIndex = 2;
            // 
            // ProductsAdd
            // 
            this.ProductsAdd.Location = new System.Drawing.Point(500, 641);
            this.ProductsAdd.Name = "ProductsAdd";
            this.ProductsAdd.Size = new System.Drawing.Size(80, 50);
            this.ProductsAdd.TabIndex = 3;
            this.ProductsAdd.Text = "Add";
            this.ProductsAdd.UseVisualStyleBackColor = true;
            this.ProductsAdd.Click += new System.EventHandler(this.ProductsAdd_Click);
            // 
            // ProductsDelete
            // 
            this.ProductsDelete.Location = new System.Drawing.Point(258, 421);
            this.ProductsDelete.Name = "ProductsDelete";
            this.ProductsDelete.Size = new System.Drawing.Size(80, 50);
            this.ProductsDelete.TabIndex = 4;
            this.ProductsDelete.Text = "Delete Selected";
            this.ProductsDelete.UseVisualStyleBackColor = true;
            this.ProductsDelete.Click += new System.EventHandler(this.ProductsDelete_Click);
            // 
            // ProductsAddName
            // 
            this.ProductsAddName.Location = new System.Drawing.Point(477, 393);
            this.ProductsAddName.Name = "ProductsAddName";
            this.ProductsAddName.Size = new System.Drawing.Size(113, 23);
            this.ProductsAddName.TabIndex = 5;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(481, 339);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(99, 15);
            this.ProductNameLabel.TabIndex = 7;
            this.ProductNameLabel.Text = "Add new product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // ProductsAddDesc
            // 
            this.ProductsAddDesc.Location = new System.Drawing.Point(480, 480);
            this.ProductsAddDesc.Name = "ProductsAddDesc";
            this.ProductsAddDesc.Size = new System.Drawing.Size(100, 96);
            this.ProductsAddDesc.TabIndex = 8;
            this.ProductsAddDesc.Text = "";
            // 
            // ProductsAddPrice
            // 
            this.ProductsAddPrice.DecimalPlaces = 2;
            this.ProductsAddPrice.Location = new System.Drawing.Point(477, 436);
            this.ProductsAddPrice.Name = "ProductsAddPrice";
            this.ProductsAddPrice.Size = new System.Drawing.Size(120, 23);
            this.ProductsAddPrice.TabIndex = 9;
            // 
            // ProductsAddCat
            // 
            this.ProductsAddCat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ProductsAddCat.Location = new System.Drawing.Point(477, 582);
            this.ProductsAddCat.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ProductsAddCat.Name = "ProductsAddCat";
            this.ProductsAddCat.Size = new System.Drawing.Size(120, 23);
            this.ProductsAddCat.TabIndex = 9;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ProductsAddCat);
            this.Controls.Add(this.ProductsAddPrice);
            this.Controls.Add(this.ProductsAddDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductsAddName);
            this.Controls.Add(this.ProductsDelete);
            this.Controls.Add(this.ProductsAdd);
            this.Controls.Add(this.ProductsListBox);
            this.Controls.Add(this.ProductsRefresh);
            this.Controls.Add(this.ProductsGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsAddPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsAddCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Button ProductsRefresh;
        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.Button ProductsAdd;
        private System.Windows.Forms.Button ProductsDelete;
        private System.Windows.Forms.TextBox ProductsAddName;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ProductsAddDesc;
        private System.Windows.Forms.NumericUpDown ProductsAddPrice;
        private System.Windows.Forms.NumericUpDown ProductsAddCat;
    }
}
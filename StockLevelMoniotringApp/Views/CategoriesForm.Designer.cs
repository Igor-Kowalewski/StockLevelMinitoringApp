
namespace FormUI.Views
{
    partial class CategoriesForm
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
            this.categoriesGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addCategoryLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.addCategoryGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.addCategoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoriesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoriesGridView.Location = new System.Drawing.Point(0, 0);
            this.categoriesGridView.Margin = new System.Windows.Forms.Padding(0);
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.RowTemplate.Height = 25;
            this.categoriesGridView.Size = new System.Drawing.Size(796, 729);
            this.categoriesGridView.TabIndex = 7;
            this.categoriesGridView.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(206, 60);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.LightGreen;
            this.addCategoryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCategoryButton.Location = new System.Drawing.Point(3, 146);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(206, 60);
            this.addCategoryButton.TabIndex = 4;
            this.addCategoryButton.Text = "Add";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteCategoryButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteCategoryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCategoryButton.Location = new System.Drawing.Point(3, 666);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(206, 60);
            this.deleteCategoryButton.TabIndex = 5;
            this.deleteCategoryButton.Text = "Delete Selected";
            this.deleteCategoryButton.UseVisualStyleBackColor = false;
            this.deleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 25);
            this.textBox1.TabIndex = 3;
            // 
            // addCategoryLabel
            // 
            this.addCategoryLabel.AutoSize = true;
            this.addCategoryLabel.Location = new System.Drawing.Point(83, 20);
            this.addCategoryLabel.Name = "addCategoryLabel";
            this.addCategoryLabel.Size = new System.Drawing.Size(43, 17);
            this.addCategoryLabel.TabIndex = 2;
            this.addCategoryLabel.Text = "Name";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel.Controls.Add(this.addCategoryGroupBox);
            this.menuPanel.Controls.Add(this.deleteCategoryButton);
            this.menuPanel.Controls.Add(this.refreshButton);
            this.menuPanel.Controls.Add(this.addCategoryButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuPanel.Location = new System.Drawing.Point(796, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(3);
            this.menuPanel.Size = new System.Drawing.Size(212, 729);
            this.menuPanel.TabIndex = 6;
            // 
            // addCategoryGroupBox
            // 
            this.addCategoryGroupBox.Controls.Add(this.addCategoryLabel);
            this.addCategoryGroupBox.Controls.Add(this.textBox1);
            this.addCategoryGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCategoryGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCategoryGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCategoryGroupBox.Location = new System.Drawing.Point(3, 63);
            this.addCategoryGroupBox.Name = "addCategoryGroupBox";
            this.addCategoryGroupBox.Size = new System.Drawing.Size(206, 77);
            this.addCategoryGroupBox.TabIndex = 1;
            this.addCategoryGroupBox.TabStop = false;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.categoriesGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "CategoriesForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.addCategoryGroupBox.ResumeLayout(false);
            this.addCategoryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView categoriesGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label addCategoryLabel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.GroupBox addCategoryGroupBox;
    }
}
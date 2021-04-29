namespace Magazyn
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddClient = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.FoundedClientsListbox = new System.Windows.Forms.ListBox();
            this.SearchSurnameLabel = new System.Windows.Forms.Label();
            this.SearchSurnameTexbox = new System.Windows.Forms.TextBox();
            this.SearchClient = new System.Windows.Forms.Button();
            this.addingClientGroupbox = new System.Windows.Forms.GroupBox();
            this.searchingClientsGroupbox = new System.Windows.Forms.GroupBox();
            this.customersButton = new System.Windows.Forms.Button();
            this.levelsButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.addingClientGroupbox.SuspendLayout();
            this.searchingClientsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddClient
            // 
            this.AddClient.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.AddClient.Location = new System.Drawing.Point(62, 162);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(160, 60);
            this.AddClient.TabIndex = 0;
            this.AddClient.TabStop = false;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(62, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(62, 136);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(160, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(62, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(62, 120);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Surname";
            // 
            // FoundedClientsListbox
            // 
            this.FoundedClientsListbox.FormattingEnabled = true;
            this.FoundedClientsListbox.Location = new System.Drawing.Point(66, 190);
            this.FoundedClientsListbox.Name = "FoundedClientsListbox";
            this.FoundedClientsListbox.Size = new System.Drawing.Size(160, 199);
            this.FoundedClientsListbox.TabIndex = 0;
            this.FoundedClientsListbox.TabStop = false;
            // 
            // SearchSurnameLabel
            // 
            this.SearchSurnameLabel.AutoSize = true;
            this.SearchSurnameLabel.Location = new System.Drawing.Point(63, 81);
            this.SearchSurnameLabel.Name = "SearchSurnameLabel";
            this.SearchSurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SearchSurnameLabel.TabIndex = 6;
            this.SearchSurnameLabel.Text = "Surname";
            // 
            // SearchSurnameTexbox
            // 
            this.SearchSurnameTexbox.Location = new System.Drawing.Point(66, 97);
            this.SearchSurnameTexbox.Name = "SearchSurnameTexbox";
            this.SearchSurnameTexbox.Size = new System.Drawing.Size(160, 20);
            this.SearchSurnameTexbox.TabIndex = 7;
            // 
            // SearchClient
            // 
            this.SearchClient.Location = new System.Drawing.Point(66, 123);
            this.SearchClient.Name = "SearchClient";
            this.SearchClient.Size = new System.Drawing.Size(160, 60);
            this.SearchClient.TabIndex = 0;
            this.SearchClient.TabStop = false;
            this.SearchClient.Text = "Search Client";
            this.SearchClient.UseVisualStyleBackColor = true;
            this.SearchClient.Click += new System.EventHandler(this.SearchClientBtn_Click);
            // 
            // addingClientGroupbox
            // 
            this.addingClientGroupbox.Controls.Add(this.AddClient);
            this.addingClientGroupbox.Controls.Add(this.textBoxName);
            this.addingClientGroupbox.Controls.Add(this.textBoxSurname);
            this.addingClientGroupbox.Controls.Add(this.labelName);
            this.addingClientGroupbox.Controls.Add(this.labelSurname);
            this.addingClientGroupbox.Location = new System.Drawing.Point(13, 13);
            this.addingClientGroupbox.Name = "addingClientGroupbox";
            this.addingClientGroupbox.Size = new System.Drawing.Size(290, 535);
            this.addingClientGroupbox.TabIndex = 8;
            this.addingClientGroupbox.TabStop = false;
            this.addingClientGroupbox.Text = "Add New Client";
            // 
            // searchingClientsGroupbox
            // 
            this.searchingClientsGroupbox.Controls.Add(this.FoundedClientsListbox);
            this.searchingClientsGroupbox.Controls.Add(this.SearchSurnameLabel);
            this.searchingClientsGroupbox.Controls.Add(this.SearchClient);
            this.searchingClientsGroupbox.Controls.Add(this.SearchSurnameTexbox);
            this.searchingClientsGroupbox.Location = new System.Drawing.Point(308, 13);
            this.searchingClientsGroupbox.Name = "searchingClientsGroupbox";
            this.searchingClientsGroupbox.Size = new System.Drawing.Size(290, 535);
            this.searchingClientsGroupbox.TabIndex = 9;
            this.searchingClientsGroupbox.TabStop = false;
            this.searchingClientsGroupbox.Text = "Search For Client";
            // 
            // customersButton
            // 
            this.customersButton.Location = new System.Drawing.Point(611, 14);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(160, 60);
            this.customersButton.TabIndex = 8;
            this.customersButton.TabStop = false;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // levelsButton
            // 
            this.levelsButton.Location = new System.Drawing.Point(611, 81);
            this.levelsButton.Name = "levelsButton";
            this.levelsButton.Size = new System.Drawing.Size(160, 60);
            this.levelsButton.TabIndex = 10;
            this.levelsButton.TabStop = false;
            this.levelsButton.Text = "Actual Levels";
            this.levelsButton.UseVisualStyleBackColor = true;
            this.levelsButton.Click += new System.EventHandler(this.LevelsButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(611, 149);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(160, 60);
            this.ordersButton.TabIndex = 11;
            this.ordersButton.TabStop = false;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.levelsButton);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.searchingClientsGroupbox);
            this.Controls.Add(this.addingClientGroupbox);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Level App";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.addingClientGroupbox.ResumeLayout(false);
            this.addingClientGroupbox.PerformLayout();
            this.searchingClientsGroupbox.ResumeLayout(false);
            this.searchingClientsGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.ListBox FoundedClientsListbox;
        private System.Windows.Forms.Label SearchSurnameLabel;
        private System.Windows.Forms.TextBox SearchSurnameTexbox;
        private System.Windows.Forms.Button SearchClient;
        private System.Windows.Forms.GroupBox addingClientGroupbox;
        private System.Windows.Forms.GroupBox searchingClientsGroupbox;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button levelsButton;
        private System.Windows.Forms.Button ordersButton;
    }
}


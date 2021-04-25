namespace Magazyn
{
    partial class Dashboard
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
            this.Dodaj = new System.Windows.Forms.Button();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.ListaZnalezione = new System.Windows.Forms.ListBox();
            this.ZnajdzPoNazwiskoLabel = new System.Windows.Forms.Label();
            this.ZnajdzPoNazwiskuBox = new System.Windows.Forms.TextBox();
            this.Szukaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dodaj
            // 
            this.Dodaj.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Dodaj.Location = new System.Drawing.Point(19, 353);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(166, 85);
            this.Dodaj.TabIndex = 0;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(21, 312);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(173, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(228, 312);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(207, 20);
            this.textBoxNazwisko.TabIndex = 2;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(18, 286);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(26, 13);
            this.labelImie.TabIndex = 3;
            this.labelImie.Text = "Imie";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(225, 286);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(53, 13);
            this.labelNazwisko.TabIndex = 4;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // ListaZnalezione
            // 
            this.ListaZnalezione.FormattingEnabled = true;
            this.ListaZnalezione.Location = new System.Drawing.Point(21, 66);
            this.ListaZnalezione.Name = "ListaZnalezione";
            this.ListaZnalezione.Size = new System.Drawing.Size(205, 199);
            this.ListaZnalezione.TabIndex = 5;
            // 
            // ZnajdzPoNazwiskoLabel
            // 
            this.ZnajdzPoNazwiskoLabel.AutoSize = true;
            this.ZnajdzPoNazwiskoLabel.Location = new System.Drawing.Point(18, 24);
            this.ZnajdzPoNazwiskoLabel.Name = "ZnajdzPoNazwiskoLabel";
            this.ZnajdzPoNazwiskoLabel.Size = new System.Drawing.Size(101, 13);
            this.ZnajdzPoNazwiskoLabel.TabIndex = 6;
            this.ZnajdzPoNazwiskoLabel.Text = "Znajdz po nazwisku";
            // 
            // ZnajdzPoNazwiskuBox
            // 
            this.ZnajdzPoNazwiskuBox.Location = new System.Drawing.Point(19, 40);
            this.ZnajdzPoNazwiskuBox.Name = "ZnajdzPoNazwiskuBox";
            this.ZnajdzPoNazwiskuBox.Size = new System.Drawing.Size(100, 20);
            this.ZnajdzPoNazwiskuBox.TabIndex = 7;
            // 
            // Szukaj
            // 
            this.Szukaj.Location = new System.Drawing.Point(151, 24);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(86, 36);
            this.Szukaj.TabIndex = 8;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.UseVisualStyleBackColor = true;
            this.Szukaj.Click += new System.EventHandler(this.Szukaj_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.ZnajdzPoNazwiskuBox);
            this.Controls.Add(this.ZnajdzPoNazwiskoLabel);
            this.Controls.Add(this.ListaZnalezione);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.Dodaj);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.ListBox ListaZnalezione;
        private System.Windows.Forms.Label ZnajdzPoNazwiskoLabel;
        private System.Windows.Forms.TextBox ZnajdzPoNazwiskuBox;
        private System.Windows.Forms.Button Szukaj;
    }
}


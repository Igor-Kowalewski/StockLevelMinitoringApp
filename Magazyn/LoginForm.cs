using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class LoginForm : Form
    {
        // PONIŻSZA INICJALIZACJA FORM2 WYMAGANA PRZECHODZENIA POMIĘDZY FORMSAMI BEZ ZAMKNIĘCIA APLIKACJI - IGOR KOWALEWSKI
        // POPRZEDNIA WERSJA:

        //  public LoginForm()
        //  {
        //      InitializeComponent();
        //  }

        public LoginForm() // KONSTRUKTOR
        {
            InitializeComponent();
            this.FormClosed +=
               new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
        }

        public Form MainFormReference { get; set; }

        private void LoginForm_Shown(object sender, EventArgs e) // PO WYŚWIETLENIU OBIEKTU ZYSKUJE FOCUS
        {
            this.Focus();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "admin" && passwordTextbox.Text == "admin") // TODO - TUTAJ DODAĆ LEPSZĄ WALIDACJĘ UŻYTKOWNIKÓW -> HASZOWANIE HASEŁ I POBIERANIE Z BAZY DANYCH  - IGOR KOWALEWSKI
            {
                this.MainFormReference.Activate();
                this.MainFormReference.Enabled = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Incorrect Login or Password!", "Warning!", MessageBoxButtons.OK);
            }
        }

    }
}

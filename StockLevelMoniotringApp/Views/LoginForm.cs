using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosed +=
               new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
        }

        public Form MainFormReference { get; set; }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "admin" && passwordTextBox.Text == "admin") // TODO - TUTAJ DODAĆ LEPSZĄ WALIDACJĘ UŻYTKOWNIKÓW -> HASZOWANIE HASEŁ I POBIERANIE Z BAZY DANYCH  - IGOR KOWALEWSKI
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

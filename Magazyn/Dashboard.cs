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
    public partial class Dashboard : Form
    {
        List<Klient> klienci = new List<Klient>();

        public Dashboard()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            ListaZnalezione.DataSource = klienci;
            ListaZnalezione.DisplayMember = "FullInfo";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.DodajOsobe(textBoxImie.Text, textBoxNazwisko.Text);

            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
        }

        private void Szukaj_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            klienci = db.ZnajdzOsobe(ZnajdzPoNazwiskuBox.Text);

            UpdateList();
        }
    }
}

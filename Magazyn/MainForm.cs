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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm { MainFormReference = this }; // REFERENCJA DO GŁÓWNEGO FORMULARZA ABY POWRÓCIĆ Z LOGOWANIA - IGOR KOWALEWSKI
            loginForm.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e) // PO ZALOGOWANIU FORMULARZ JEST AKTYWOWANY - IGOR KOWALEWSKI
        {
            UpdateList();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); // Application.Exit(); <- LEPSZA METODA ALE POWODUJE BŁĘDY - IGOR KOWALEWSKI
        }

        List<Customer> customers = new List<Customer>();
        public void UpdateList()
        {
            FoundedClientsListbox.DataSource = customers;
            FoundedClientsListbox.DisplayMember = "FullInfo";
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.AddClient(textBoxName.Text, textBoxSurname.Text);

            textBoxName.Text = "";
            textBoxSurname.Text = "";
        }

        private void SearchClientBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            customers = db.SearchClient(SearchSurnameTexbox.Text);

            UpdateList();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm { MainFormReference = this };
            this.Hide();
            customersForm.Show();
        }

        private void LevelsButton_Click(object sender, EventArgs e)
        {
            LevelsForm levelsForm = new LevelsForm { MainFormReference = this };
            this.Hide();
            levelsForm.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm { MainFormReference = this };
            this.Hide();
            ordersForm.Show();
        }
    }
}

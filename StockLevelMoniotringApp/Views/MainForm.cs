using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Views;
using WindowsFormsApp1.Service.CategoryService;
using WindowsFormsApp1.Service.PersonService;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly IPersonService _PersonService;
        private readonly ICategoryService categoryService;

        /// <summary>
        /// Dzięki DI w klasie program mamy uzupęłnione serwisy
        /// </summary>
        /// <param name="personService"></param>
        public MainForm(IPersonService personService)
        {
            _PersonService = personService;
            InitializeComponent();
        }

        //Testowa metoda
        //private void Button1_Click_1(object sender, EventArgs e)
        //{
        //    //var value = _PersonService.GetPersonById(int.Parse(textBox1.Text));
        //    //Console.WriteLine(value.IdPeople);
        //    //LBtotal.Text = value.IdPeople +" "+ value.Name  + " " + value.Surename + " "+ value.Pesel +" "+ value.Job ;
        //}


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm { MainFormReference = this }; // REFERENCJA DO GŁÓWNEGO FORMULARZA ABY POWRÓCIĆ Z LOGOWANIA - IGOR KOWALEWSKI
            loginForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); // Application.Exit(); <- LEPSZA METODA ALE POWODUJE BŁĘDY - IGOR KOWALEWSKI
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm { MainFormReference = this };
            this.Hide();
            customersForm.Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm { MainFormReference = this };
            this.Hide();
            customersForm.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm { MainFormReference = this };
            this.Hide();
            customersForm.Show();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm(categoryService, this);
            this.Hide();
            categoriesForm.Show();
        }
    }
}
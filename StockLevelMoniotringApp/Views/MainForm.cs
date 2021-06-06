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
using WindowsFormsApp1.Service.ProductService;
using WindowsFormsApp1.Service.WarehouseService;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly IPersonService _PersonService;
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private readonly IWarehouseService warehouseService;


        /// <summary>
        /// Dzięki DI w klasie program mamy uzupęłnione serwisy
        /// </summary>
        /// <param name="personService"></param>
        public MainForm(IPersonService personService)
        {
            _PersonService = personService;
            InitializeComponent();
            RefreshData();
        }


        public string Username { get; set; }
        public void SetUsername(string username)
        {
            Username = username;
            userLabel.Text = "User: " + Username;
            userLabel.Visible = true;
        }

        private void RefreshData()
        {
            var DBContext = new SimpleWarehousContext();
            var products = DBContext.Produts.ToList();
            productsGridView.DataSource = products;
            productsGridView.Columns[0].Visible = false;
            productsGridView.Columns[4].Visible = false;
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            RefreshData();
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
            ProductsForm productsForm = new ProductsForm(productService, this);
            this.Hide();
            productsForm.Show();
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

        private void WarehousesButton_Click(object sender, EventArgs e)
        {
            WarehousesForm warehousesForm = new WarehousesForm(warehouseService, this);
            this.Hide();
            warehousesForm.Show();
        }

    }

}
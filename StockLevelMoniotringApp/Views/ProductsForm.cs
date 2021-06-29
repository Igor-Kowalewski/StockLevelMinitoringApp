using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1;
using WindowsFormsApp1.Service.ProductService;

namespace FormUI.Views
{
    public partial class ProductsForm : Form
    {
        public IProductService ProductService { get; set; }
        public MainForm MainFormReference { get; set; }

        public ProductsForm(IProductService productService, Form MainFormReference)
        {
            this.ProductService = productService;
            this.MainFormReference = (MainForm)MainFormReference;

            InitializeComponent();
            ProductsAddPrice.Controls[0].Visible = false;
            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.ProductsForm_FormClosed);

            RefreshData();
            PopulateIdList();
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainFormReference.Show();
            this.Dispose();
        }

        private void ProductsRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var DBContext = new SimpleWarehousContext();
            var products = DBContext.Produts.ToList();

            var result = (from product in DBContext.Produts
                          join category in DBContext.Categories
                          on product.CategoryId equals category.CategoryId
                          select new
                          {
                              product.DisplayName,
                              product.Price,
                              product.Description,
                              category.Name
                          }).ToList();
            productsGridView.DataSource = result;
            productsGridView.Columns[3].HeaderText = "Category";
            productsGridView.Columns[0].HeaderText = "ProductName";
            //productsGridView.DataSource = products;
            //productsGridView.Columns[0].Visible = false;
            //productsGridView.Columns[4].Visible = false;

            //var stringlist = new List<String>();  // LISTA STRING DO WYKORZYSTANIA NP W LISTBOXACH
            //foreach (var item in products)
            //{
            //    stringlist.Add(item.ProductId + " " + item.DisplayName);
            //}
        }

        private void ProductsAdd_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Category tempCat = (Category)ProductsAddCat.SelectedItem;
            Product temp = new Product { DisplayName = ProductsAddName.Text, Price = (double)ProductsAddPrice.Value, Description = ProductsAddDesc.Text, CategoryId = tempCat.CategoryId };
            MessageBox.Show("Dodawanie produktu " + ProductsAddName.Text);
            DBContext.Produts.Add(temp);
            DBContext.SaveChanges();

            RefreshData();
        }

        private void ProductsDelete_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Product temp = new Product();
            foreach (DataGridViewRow row in productsGridView.SelectedRows)
            {
                MessageBox.Show("USUWANIE: Index " + row.Index.ToString() + " ID: " + row.Cells[0].Value.ToString());
                temp.ProductId = (int)row.Cells[0].Value;
                DBContext.Produts.Remove(temp);
                DBContext.SaveChanges();

            }
            
            RefreshData();
        }

        private void PopulateIdList()
        {
            var DBContext = new SimpleWarehousContext();

            var categories = DBContext.Categories.ToList();
            ProductsAddCat.DataSource = categories;

            ProductsAddCat.DisplayMember = "Name";
            ProductsAddCat.ValueMember = "CategoryId";

        }
    }
}

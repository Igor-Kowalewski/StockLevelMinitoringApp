using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1.Service.ProductService;

namespace FormUI.Views
{
    public partial class ProductsForm : Form
    {
        public IProductService ProductService { get; set; }
        public Form MainFormReference { get; set; }

        public ProductsForm(IProductService productService, Form MainFormReference)
        {
            this.ProductService = productService;
            this.MainFormReference = MainFormReference;

            InitializeComponent();
            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.ProductsForm_FormClosed);
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainFormReference.Show();
            this.Dispose();
        }

        private void ProductsRefresh_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();
            var products = DBContext.Produts.ToList();
            ProductsGridView.DataSource = products;

            var stringlist = new List<String>();

            foreach (var item in products)
            {
                stringlist.Add(item.ProductId + " " + item.DisplayName);
            }
            ProductsListBox.DataSource = stringlist;
        }

        private void ProductsAdd_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Product temp = new Product { DisplayName = ProductsAddName.Text, Price = (double)ProductsAddPrice.Value, Description = ProductsAddDesc.Text, CategoryId = (int)ProductsAddCat.Value};
            MessageBox.Show("Dodawanie produktu " + ProductsAddName.Text);
            DBContext.Produts.Add(temp);
            DBContext.SaveChanges();

        }

        private void ProductsDelete_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Product temp = new Product();
            foreach (DataGridViewRow row in ProductsGridView.SelectedRows)
            {
                MessageBox.Show("USUWANIE: Index " + row.Index.ToString() + " ID: " + row.Cells[0].Value.ToString());
                temp.ProductId = (int)row.Cells[0].Value;
                DBContext.Produts.Remove(temp);
                DBContext.SaveChanges();
            }
        }
    }
}

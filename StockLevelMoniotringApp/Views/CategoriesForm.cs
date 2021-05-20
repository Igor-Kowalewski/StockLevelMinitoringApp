using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1.Service.CategoryService;

namespace FormUI.Views
{
    public partial class CategoriesForm : Form
    {
        public ICategoryService CategoryService { get; set; }
        public Form MainFormReference { get; set; }

        public CategoriesForm(ICategoryService categoryService, Form MainFormReference)
        {
            this.CategoryService = categoryService;
            this.MainFormReference = MainFormReference;

            InitializeComponent();
            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.CategoriesForm_FormClosed);
        }

        private void CategoriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFormReference.Show();
            this.Dispose();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();
            var categories = DBContext.Categories.ToList();
            categoriesGridView.DataSource = categories;


            var stringlist= new List<String>();
            foreach (var item in categories)
            {
                stringlist.Add(item.CategoryId + " " + item.Name);
            }
            listBox1.DataSource = stringlist;


            // NIE DZIAŁA SERVICE !!!
            //categoriesGridView.DataSource = Data.SimpleWarehousContext();
            //ICategoryService categoryService1;
            //List<String> ls = new List<string>();
            //ls = CategoryService.GetAllCategories();

            //Category example = new Category();
            //example.Name = "Przykładowa";
            //CategoryService.AddCategory(example);
            //listBox1.DataSource = CategoryService.GetAllCategories();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            var temp = new Category { Name = textBox1.Text };

            DBContext.Categories.Add(temp);
            DBContext.SaveChanges();
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Category temp = new Category();
            foreach (DataGridViewRow row in categoriesGridView.SelectedRows)
            {
                MessageBox.Show("USUWANIE: Index " + row.Index.ToString() + " ID: " + row.Cells[0].Value.ToString());
                temp.CategoryId = (int)row.Cells[0].Value;
                DBContext.Categories.Remove(temp);
                DBContext.SaveChanges();
            }
        }
    }
}
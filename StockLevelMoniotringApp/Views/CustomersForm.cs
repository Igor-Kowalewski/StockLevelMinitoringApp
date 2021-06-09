using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1;

namespace FormUI.Views
{
    public partial class CustomersForm : Form
    {
        public Form MainFormReference { get; set; }

        public CustomersForm()
        {
            InitializeComponent();
            RefreshData();

            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.CustomersForm_FormClosed);
        }

        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainFormReference.Show();
            this.Dispose();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var DBContext = new SimpleWarehousContext();
            var Users = DBContext.Users.ToList();
            CustomerGridView.DataSource = Users;
            CustomerGridView.Columns[0].Visible = false;
            CustomerGridView.Columns[6].Visible = false;
            CustomerGridView.Columns[7].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            User temp = new User {Name = NameBox.Text, Surename = SurnameBox.Text, Phone = PhoneBox.Text, Email = EmailBox.Text, AddressId = (int)AddressID.Value, CompanyRoleId= (int)CompanyRoleID.Value};
            MessageBox.Show("Dodawanie klienta " + NameBox.Text);
            DBContext.Users.Add(temp);
            DBContext.SaveChanges();

            RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            User temp = new User();
            foreach (DataGridViewRow row in CustomerGridView.SelectedRows)
            {
                MessageBox.Show("USUWANIE: Index " + row.Index.ToString() + " ID: " + row.Cells[0].Value.ToString());
                temp.UserId = (int)row.Cells[0].Value;
                DBContext.Users.Remove(temp);
                DBContext.SaveChanges();
            }

            RefreshData();
        }
    }
}

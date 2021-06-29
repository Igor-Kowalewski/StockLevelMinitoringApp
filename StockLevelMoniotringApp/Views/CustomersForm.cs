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
        public int AdId = 0;

        public Form MainFormReference { get; set; }

        public CustomersForm()
        {
            InitializeComponent();
            RefreshData();

            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.CustomersForm_FormClosed);
            PopulateIdList();
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
            var result = (from customer in DBContext.Users
                          join address in DBContext.Adresses
                          on customer.AddressId equals address.AddressId
                          join companyRole in DBContext.CompanyRole
                          on customer.CompanyRoleId equals companyRole.CompanyRoleId
                          select new
                          {
                              customer.Name,
                              customer.Surename,
                              customer.Email,
                              customer.Phone,
                              address.Street,
                              address.StreetNumber,
                              address.City,
                              address.Zipcode,
                              companyRole.RoleName
                          }).ToList();
            CustomerGridView.DataSource = result;
            //var Users = DBContext.Users.ToList();
            //CustomerGridView.DataSource = Users;
            //CustomerGridView.Columns[0].Visible = false;
            //CustomerGridView.Columns[6].Visible = false;
            //CustomerGridView.Columns[7].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            CompanyRole tempRole = (CompanyRole)CompanyRoleId.SelectedItem;
            User temp = new User {Name = NameBox.Text, Surename = SurnameBox.Text, Phone = PhoneBox.Text, Email = EmailBox.Text, AddressId = AdId, CompanyRoleId = tempRole.CompanyRoleId};
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

        private void PopulateIdList()
        {
            var DBContext = new SimpleWarehousContext();

            var roles = DBContext.CompanyRole.ToList();
            CompanyRoleId.DataSource = roles;

            CompanyRoleId.DisplayMember = "RoleName";
            CompanyRoleId.ValueMember = "CompanyRoleId";

            CompanyRole temp = new CompanyRole();
            temp.CompanyRoleId = -1;
            temp.RoleName = "Brak";
            CompanyRoleId.SelectedItem = temp;
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            addressForm.CustomersForm = this;
            addressForm.Show();
            addressForm.parentID = 1;
        }
    }
}

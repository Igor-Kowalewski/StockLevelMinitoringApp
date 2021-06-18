using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1;

namespace FormUI.Views
{
    public partial class AddressForm : Form
    {
        public int parentID = -1;
        public OrdersForm OrdersForm  { get; set; }
        public CustomersForm CustomersForm { get; set; }
        public WarehousesForm WarehousesForm { get; set; }

        public AddressForm()
        {
            InitializeComponent();
            RefreshData();
            NumberBox.Controls[0].Visible = false;
        }
        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var DBContext = new SimpleWarehousContext();
            var Addresses = DBContext.Adresses.ToList();
            AddressGridView.DataSource = Addresses;
            AddressGridView.Columns[0].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Address temp = new Address { Street = StreetBox.Text, StreetNumber = (int)NumberBox.Value, City = CityBox.Text, Zipcode = ZipBox.Text};
            MessageBox.Show("Dodawanie klienta " + (int)NumberBox.Value + " " + StreetBox.Text);
            DBContext.Adresses.Add(temp);
            DBContext.SaveChanges();

            RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Address temp = new Address();
            foreach (DataGridViewRow row in AddressGridView.SelectedRows)
            {
                MessageBox.Show("USUWANIE: Index " + row.Index.ToString() + " ID: " + row.Cells[0].Value.ToString());
                temp.AddressId = (int)row.Cells[0].Value;
                DBContext.Adresses.Remove(temp);
                DBContext.SaveChanges();
            }

            RefreshData();
        }



        private void ChooseButton_Click(object sender, EventArgs e)
        {
            var form1 = Application.OpenForms[0];

            Address temp = new Address();
            foreach (DataGridViewRow row in AddressGridView.SelectedRows)
            {
                string AddressName = row.Cells[3].Value + " " + (string)row.Cells[2].Value + ", " + (string)row.Cells[1].Value + ", " + (string)row.Cells[4].Value;
                temp.AddressId = (int)row.Cells[0].Value;
                switch(parentID)
                {
                    case -1:
                    break;
                    case 0:
                        OrdersForm.AddressBox.Text = AddressName;
                        OrdersForm.AdId = temp.AddressId;
                        break;
                    case 1:
                        CustomersForm.AddressBox.Text = AddressName;
                        CustomersForm.AdId = temp.AddressId;
                        break;
                    case 2:
                        WarehousesForm.AddressBox.Text = AddressName;
                        WarehousesForm.AdId = temp.AddressId;
                        break;
                }
        }
            this.Dispose();
        }
    }
}

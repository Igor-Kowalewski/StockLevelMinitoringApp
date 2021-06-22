using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1;
using FormUI.Services.PdfService;

namespace FormUI.Views
{
    public partial class OrdersForm : Form
    {

        public int AdId = 0;

        public Form MainFormReference { get; set; }

        public OrdersForm()
        {
            InitializeComponent();
            RefreshData();
            SubtotalBox.Controls[0].Visible = false;
            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.OrdersForm_FormClosed);
            PopulateIdList();
        }

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
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
            var result = (from order in DBContext.Orders
                      join address in DBContext.Adresses
                      on order.OrderAddressId equals address.AddressId
                      join company in DBContext.Companies
                      on order.CompanyId equals company.CompanyId
                      join status in DBContext.OrderStatus
                      on order.OrderStatusId equals status.OrderStatusId
                      join user in DBContext.Users
                      on order.UserId equals user.UserId
                          select new
                      {
                          order.Subotal,
                          order.AdditionalInformations,
                          user.UserId,
                          company.CompanyName,
                          address.Street,
                          address.StreetNumber,
                          address.City,
                          address.Zipcode,
                          status.StatusName,
                      }).ToList();
            var Orders = DBContext.Orders.ToList();
            OrdersGridView.DataSource = result;
            //OrdersGridView.Columns[0].Visible = false;
            //OrdersGridView.Columns[3].Visible = false;
            //OrdersGridView.Columns[4].Visible = false;
            //OrdersGridView.Columns[5].Visible = false;
            //OrdersGridView.Columns[6].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            User tempUser = (User)UserID.SelectedItem;
            Company tempComp = (Company)CompanyID.SelectedItem;
            OrderStatus tempStat = (OrderStatus)StatusID.SelectedItem;
            Order temp = new Order { Subotal = SubtotalBox.Value, AdditionalInformations = InfoBox.Text, OrderAddressId = AdId, UserId = tempUser.UserId, CompanyId = tempComp.CompanyId, OrderStatusId = tempStat.OrderStatusId };
            MessageBox.Show("Dodawanie Zamowinia ");
            DBContext.Orders.Add(temp);
            DBContext.SaveChanges();

            RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Order temp = new Order();
            foreach (DataGridViewRow row in OrdersGridView.SelectedRows)
            {
                MessageBox.Show("USUWANIE: Index " + row.Index.ToString() + " ID: " + row.Cells[0].Value.ToString());
                temp.OrderId = (int)row.Cells[0].Value;
                DBContext.Orders.Remove(temp);
                DBContext.SaveChanges();
            }

            RefreshData();
        }

        private void PopulateIdList()
        {
            var DBContext = new SimpleWarehousContext();

            var users = DBContext.Users.ToList();
            UserID.DataSource = users;

            var companies = DBContext.Companies.ToList();
            CompanyID.DataSource = companies;

            var statuses = DBContext.OrderStatus.ToList();
            StatusID.DataSource = statuses;

            UserID.DisplayMember = "UserId";
            UserID.ValueMember = "UserId";

            CompanyID.DisplayMember = "CompanyName";
            CompanyID.ValueMember = "CompanyId";

            StatusID.DisplayMember = "StatusName";
            StatusID.ValueMember = "OrderStatusId";

            
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            addressForm.OrdersForm = this;
            addressForm.Show();
            addressForm.parentID = 0;
        }

        private void PdfButton_Click(object sender, EventArgs e)
        {
            GeneratePDF pdf = new GeneratePDF();
            foreach (DataGridViewRow row in OrdersGridView.SelectedRows)
            {
                string client = row.Cells[3].Value.ToString();
                string adres1 = row.Cells[5].Value.ToString() + " " + row.Cells[4].Value.ToString();
                string adres2 = row.Cells[6].Value.ToString() + ", " + row.Cells[7].Value.ToString();
                pdf.ExportPDF(adres1, adres2, client, (Company)CompanyID.SelectedItem, 456, "uwagi");
            }
            
            MessageBox.Show("Wygenerowano pdf");
        }
    }
}

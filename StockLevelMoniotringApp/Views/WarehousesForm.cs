using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1;
using WindowsFormsApp1.Service.WarehouseService;

namespace FormUI.Views
{
    public partial class WarehousesForm : Form
    {
        public int AdId = 0;

        public IWarehouseService WarehouseService { get; set; }
        public MainForm MainFormReference { get; set; }

        public WarehousesForm(IWarehouseService WarehouseService, Form MainFormReference)
        {
            this.WarehouseService = WarehouseService;
            this.MainFormReference = (MainForm)MainFormReference;

            InitializeComponent();
            RefreshData();
            PopulateIdList();

            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.WarehousesForm_FormClosed);
        }
        private void WarehousesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainFormReference.Show();
            this.Dispose();
        }

        private void WarehousesRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var DBContext = new SimpleWarehousContext();
            var result = (from warehouse in DBContext.Warehouses
                          join address in DBContext.Adresses
                          on warehouse.AddressId equals address.AddressId
                          join company in DBContext.Companies
                          on warehouse.CompanyId equals company.CompanyId
                          select new
                          {
                              warehouse.WarehouseName,
                              address.Street,
                              address.StreetNumber,
                              address.City,
                              address.Zipcode,
                              company.CompanyName
                          }).ToList();
            warehousesGridView.DataSource = result;

            //var Warehouses = DBContext.Warehouses.ToList();
            //warehousesGridView.DataSource = Warehouses;
            //warehousesGridView.Columns[0].Visible = false;
            //warehousesGridView.Columns[2].Visible = false;
            //warehousesGridView.Columns[3].Visible = false;
        }

        private void WarehousesAdd_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Company tempComp = (Company)WarehousesAddCompany.SelectedItem;
            Warehous temp = new Warehous { WarehouseName = WarehousesAddName.Text, AddressId = AdId, CompanyId = tempComp.CompanyId };
            MessageBox.Show("Dodawanie magazynu " + WarehousesAddName.Text);
            DBContext.Warehouses.Add(temp);
            DBContext.SaveChanges();

            RefreshData();
        }

        private void WarehousesDelete_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Warehous temp = new Warehous();
            foreach (DataGridViewRow row in warehousesGridView.SelectedRows)
            {
                MessageBox.Show("USUWANIE: Index " + row.Index.ToString() + " ID: " + row.Cells[0].Value.ToString());
                temp.WarehouseId = (int)row.Cells[0].Value;
                DBContext.Warehouses.Remove(temp);
                DBContext.SaveChanges();
            }

            RefreshData();
        }

        private void PopulateIdList()
        {
            var DBContext = new SimpleWarehousContext();

            var companies = DBContext.Companies.ToList();
            WarehousesAddCompany.DataSource = companies;

            WarehousesAddCompany.DisplayMember = "CompanyName";
            WarehousesAddCompany.ValueMember = "CompanyId";

        }
        private void AddressButton_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            addressForm.WarehousesForm = this;
            addressForm.Show();
            addressForm.parentID = 2;
        }
    }
}

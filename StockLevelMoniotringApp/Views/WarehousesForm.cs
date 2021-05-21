using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1.Service.WarehouseService;

namespace FormUI.Views
{
    public partial class WarehousesForm : Form
    {
        public IWarehouseService WarehouseService { get; set; }
        public Form MainFormReference { get; set; }

        public WarehousesForm(IWarehouseService WarehouseService, Form MainFormReference)
        {
            this.WarehouseService = WarehouseService;
            this.MainFormReference = MainFormReference;

            InitializeComponent();

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
            var DBContext = new SimpleWarehousContext();
            var Warehouses = DBContext.Warehouses.ToList();
            WarehousesGridView.DataSource = Warehouses;

            var stringlist = new List<String>();

            foreach (var item in Warehouses)
            {
                stringlist.Add(item.WarehouseId + " " + item.WarehouseName);
            }
            WarehousesListBox.DataSource = stringlist;
        }

        private void WarehousesAdd_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Warehous temp = new Warehous { WarehouseName = WarehousesAddName.Text, AddressId = (int)WarehousesAddAddress.Value, CompanyId = (int)WarehousesAddCompany.Value };
            MessageBox.Show("Dodawanie magazynu " + WarehousesAddName.Text);
            DBContext.Warehouses.Add(temp);
            DBContext.SaveChanges();

        }

        private void WarehousesDelete_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            Warehous temp = new Warehous();
            foreach (DataGridViewRow row in WarehousesGridView.SelectedRows)
            {
                MessageBox.Show("USUWANIE: Index " + row.Index.ToString() + " ID: " + row.Cells[0].Value.ToString());
                temp.WarehouseId = (int)row.Cells[0].Value;
                DBContext.Warehouses.Remove(temp);
                DBContext.SaveChanges();
            }
        }
    }
}

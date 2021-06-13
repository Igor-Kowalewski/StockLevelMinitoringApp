﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1;


namespace FormUI.Views
{
    public partial class OrdersForm : Form
    {
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
            var Orders = DBContext.Orders.ToList();
            OrdersGridView.DataSource = Orders;
            OrdersGridView.Columns[0].Visible = false;
            OrdersGridView.Columns[3].Visible = false;
            OrdersGridView.Columns[4].Visible = false;
            OrdersGridView.Columns[5].Visible = false;
            OrdersGridView.Columns[6].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var DBContext = new SimpleWarehousContext();

            User tempUser = (User)UserID.SelectedItem;
            Company tempComp = (Company)CompanyID.SelectedItem;
            OrderStatus tempStat = (OrderStatus)StatusID.SelectedItem;
            Order temp = new Order { Subotal = SubtotalBox.Value, AdditionalInformations = InfoBox.Text, OrderAddressId = 1, UserId = tempUser.UserId, CompanyId = tempComp.CompanyId, OrderStatusId = 1 /* do naprawienia*/ };
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

            //DO NAPRAWIENIA
            //var statuses = DBContext.OrderStatus.ToList();
            //StatusID.DataSource = statuses;

            UserID.DisplayMember = "Name";
            UserID.ValueMember = "UserId";

            CompanyID.DisplayMember = "CompanyName";
            CompanyID.ValueMember = "CompanyId";

            StatusID.DisplayMember = "StatusName";
            StatusID.ValueMember = "OrderStatusId";

        }
    }
}

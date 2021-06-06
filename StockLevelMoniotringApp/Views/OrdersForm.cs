using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Views
{
    public partial class OrdersForm : Form
    {
        public Form MainFormReference { get; set; }

        public OrdersForm()
        {
            InitializeComponent();
            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.OrdersForm_FormClosed);
        }

        private void OrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainFormReference.Show();
            this.Dispose();
        }
    }
}

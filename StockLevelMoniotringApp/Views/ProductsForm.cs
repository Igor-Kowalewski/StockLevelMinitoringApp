using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Views
{
    public partial class ProductsForm : Form
    {
        public Form MainFormReference { get; set; }

        public ProductsForm()
        {
            InitializeComponent();
            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.ProductsForm_FormClosed);
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainFormReference.Show();
            this.Dispose();
        }
    }
}

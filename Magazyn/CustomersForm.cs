using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            this.FormClosed +=
                new System.Windows.Forms.FormClosedEventHandler(this.CustomersForm_FormClosed);
        }

        public Form MainFormReference { get; set; }

        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MainFormReference.Show();
            this.Dispose();
        }
    }
}

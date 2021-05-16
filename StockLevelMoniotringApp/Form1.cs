using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Service.PersonService;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IPersonService _PersonService;

        /// <summary>
        /// Dzięki DI w klasie program mamy uzupęłnione serwisy
        /// </summary>
        /// <param name="personService"></param>
        public Form1(IPersonService personService)
        {
            _PersonService = personService;
            InitializeComponent();
        }

        /// <summary>
        /// Testowa metoda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            //var value = _PersonService.GetPersonById(int.Parse(textBox1.Text));
            //Console.WriteLine(value.IdPeople);
            //LBtotal.Text = value.IdPeople +" "+ value.Name  + " " + value.Surename + " "+ value.Pesel +" "+ value.Job ;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

   
}
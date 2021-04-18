using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Form1 : Form
    {
        //deklaracja bazy
        private readonly MagazynEntities magazynEntities;
        public Form1()
        {
            InitializeComponent();
            //inicjacja bazy
            magazynEntities = new MagazynEntities();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string n = Environment.NewLine;
                string customerName = tbCustomerName.Text;
                var dateOut = dtpDateRented.Value;
                var dateIn = dtpDateReturned.Value;

                var carType = cbTypeOfCar.Text;
                var errorMessage = "";
                bool isValid = true;
                double cost = Convert.ToDouble(tbCost.Text);

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data." + n;
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal Date Selection." +n;
                }


                if (isValid)
                {
                    //DODAWANIE REKORDOW DO BAZY
                    var rentalRecord = new MagazynRecord();             //przypisywanie danych do odpowiadajacych im pol
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DataReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

                    //przesylanie do bazy
                    magazynEntities.MagazynRecord.Add(rentalRecord);
                    magazynEntities.SaveChanges(); //zapisywanie zmian

                    MessageBox.Show("Customer Name: " + customerName + n +
                        "Date Rented: " + dateOut + n +
                        "Date Returned: " + dateIn + n +
                        "Cost: " + cost + n +
                        "Car type: " + carType);
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw; end program
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select * frome TypeOfCars
            var cars = magazynEntities.TypeOfCar.ToList();      //linq call to data base
            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "id";
            cbTypeOfCar.DataSource = cars;
        }
    }
}

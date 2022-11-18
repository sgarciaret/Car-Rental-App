using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddRentalRecord : Form
    {
        private readonly CarRentalEntities carRentalEntities;

        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string custommerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                double cost = Convert.ToDouble(lbCost.Text);
                var carType = cbTypeOfCar.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(custommerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error, please enter missing data\n\r";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Illegal date selection\n\r";
                }

                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = custommerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

                    carRentalEntities.CarRentalRecord.Add(rentalRecord);
                    carRentalEntities.SaveChanges();

                    MessageBox.Show($"Customer Name: {custommerName}\n\r" +
                    $"Date Rented: {dateOut}\n\r" +
                    $"Date Returned: {dateIn}\n\r" +
                    $"Cost: {cost}\n\r" +
                    $"Car Type: {carType}");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var cars = carRentalEntities.TypesOfCars.ToList();

            var cars = carRentalEntities.TypesOfCars
                .Select(q => new { Id = q.Id, Name = q.Make + " " + q.Model})
                .ToList();
            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "id";
            cbTypeOfCar.DataSource = cars;
        }

       
    }
}

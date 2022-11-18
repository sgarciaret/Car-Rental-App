using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {

        private readonly CarRentalEntities _db;

        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //var cars = _db.TypesOfCars.ToList();

            // Select Id as CarId, name as CarName from TypesOfCars
            //var cars = _db.TypesOfCars
            //    .Select(q => new {ID = q.Id, Name = q.Make})
            //    .ToList();

            var cars = _db.TypesOfCars
                .Select(q => new { Make = q.Make, Model = q.Model, VIN = q.VIN, Year = q.Year, LicensePlateNumber = q.LicensePlateNumber })
                .ToList();
            gvVehicleList.DataSource = cars;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //gvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }
    }
}

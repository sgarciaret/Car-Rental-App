using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
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
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _roleName;
        public Users _user;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, Users user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Roles.shortname;
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord();
            addRentalRecord.ShowDialog();
            addRentalRecord.MdiParent= this;
            
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageVehicleListing");

            if (!isOpen)
            {
                var vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;

                vehicleListing.Show();
            }
            
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] children = this.MdiChildren;

            var query = children.Select(c => c).Where(c => c is ManageRentalRecords).ToList();

            if (query.Count == 0)
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_user.password == Utils.DefaultHashPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }

            var username = _user.user;
            tsLoginRole.Text = $"Logged in as: {username}";
            if (_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] children = this.MdiChildren;

            var query = children.Select(c => c).Where(c => c is ManageUsers).ToList();

            if (query.Count == 0)
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                // convert the input to a byte array and compute the hash
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                // create a StringBuilder to collect the bytes
                StringBuilder sBuilder = new StringBuilder();

                // loop through each byte of the hashed data and format each one as an hexadecimal string
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();

                var user = _db.Users.FirstOrDefault(q => q.user == username && q.password == hashed_password && q.isActive == true);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials.");
                }
                else
                {
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong. Please try again.");
            }
        }
    }
}

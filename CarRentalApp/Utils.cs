using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    internal class Utils
    {
        public static bool FormIsOpen(string name)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == name);
            return isOpen;
        }

        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static string DefaultHashPassword()
        {
            SHA256 sha = SHA256.Create();

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("Password@123"));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}

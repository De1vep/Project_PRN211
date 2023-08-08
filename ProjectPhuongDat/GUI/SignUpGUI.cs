using Microsoft.Data.SqlClient;
using ProjectPhuongDat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectPhuongDat.GUI
{
    public partial class SignUpGUI : Form
    {
        private readonly MusicStoreContext _context = new();

        public SignUpGUI()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public List<User> users = new();
        private void btSignup_Click(object sender, EventArgs e)
        {
            string firstName = tbFname.Text;
            string lastName = tbLname.Text;
            string userName = tbUname.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string rePassword = tbRepass.Text;
            string state = tbState.Text;
            string country = tbCountry.Text;
            string city = tbCity.Text;
            string address = tbAddress.Text;
            string phone = tbPhone.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rePassword) ||
                string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui long khong de trong!", "Thong bao");

            }
            else if (password != rePassword)
            {
                MessageBox.Show("Mat Khau Khong Khop!");
            }
            else
            {
                User user = new User
                {
                    UserName = userName,
                    Password = password,
                    Address = address,
                    City = city,
                    Country = country,
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone,
                    State = state,
                    Role = 0
                };

                _context.Users.Add(user);
                _context.SaveChanges();
                MessageBox.Show("Dang ky thanh cong!", "Thong Bao!!!");
                this.Hide();
                LoginGUI login = new LoginGUI();
                login.ShowDialog();
                this.Show();
                this.Close();
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (!email.Contains("@"))
            {
                tbEmail.Text = email + "@fpt.edu.vn";
            }
        }
    }
}

using ProjectPhuongDat.DAO;
using ProjectPhuongDat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPhuongDat.GUI
{
    public partial class LoginGUI : Form
    {
        public Form form { get; set; }
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountDAO dao = new AccountDAO();
            User user = dao.GetUserByUsernameAndPassword(txbUser.Text, txbPass.Text);
            if (user != null)
            {
                this.Hide();
                MainGUI userGUI = new MainGUI(user);
                userGUI.ShowDialog();

            }
            else
            {
                MessageBox.Show("!!!That member does not exist!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


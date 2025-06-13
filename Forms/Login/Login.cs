using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTable.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TryLogin()
        {
            Home main = new Home();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
            this.Hide();
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserNameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TryLogin();
            }
        }

        private void PasswordTexbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TryLogin();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            TryLogin();
        }
    }
}

using EasyTable.Data;
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
        private readonly EasyTableDbContext context;
        public Login()
        {
            EasyTableDbContextFactory factory = new EasyTableDbContextFactory();
            context = factory.CreateDbContext(new string[0]);
            InitializeComponent();
        }

        private void TryLogin()
        {
            string username = UserNameTextbox.Text;
            string password = PasswordTexbox.Text;

            var user = context.Users.FirstOrDefault(u => u.Username == username && u.HashedPassword == password);
            if (user != null)
            {
                Home main = new Home(user.Id);
                main.FormClosed += (s, args) => this.Close();
                main.Show();
                this.Hide();
            }
            else
            {
                Notification.Show(this, "Невалидни данни за достъп", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }


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

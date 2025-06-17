using EasyTable.Data;
using EasyTable.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTable.Forms.Admin
{
    public partial class ViewAddEditUserDialog : Form
    {
        private int userId;
        private int currentMode;

        public event EventHandler UserSaved;

        private readonly EasyTableDbContext context;
        public ViewAddEditUserDialog(int mode, int userID = -1)
        {

            var factory = new EasyTableDbContextFactory();
            context = factory.CreateDbContext(new string[0]);

            InitializeComponent();
            userId = userID;
            currentMode = mode;

            this.Shown += SetupDialog;
        }

        private async void SetupDialog(object sender, EventArgs e)
        {
            this.Enabled = false;


            if (currentMode == 1)
            {
                nameTextBox.Enabled = false;
                usernameTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
                contactTextBox.Enabled = false;
                jobDropdown.Enabled = false;
                SubmitBtn.Enabled = false;
                CancelBtn.Enabled = false;
                TitleLable.Text = "Информация";
                await LoadData();
            }
            else if (currentMode == 2)
            {
                TitleLable.Text = "Добавяне на нов служител";
                SubmitBtn.Text = "Добави";
            }
            else
            {
                TitleLable.Text = "Редактиране";
                await LoadData();
            }



            this.Enabled = true;
        }

        private async Task LoadData()
        {
            var user = await context.Users
                                .FirstOrDefaultAsync(u => u.Id == userId);


            nameTextBox.Text = user.Name;
            usernameTextBox.Text = user.Username;
            passwordTextBox.Text = user.HashedPassword;
            contactTextBox.Text = user.ContactInfo;

            string jobText;
            if (user.RoleId == 1)
            {
                jobText = "Управител";
            }
            else if (user.RoleId == 2)
            {
                jobText = "Сервитьор";
            }
            else
            {
                jobText = "Администратор";
            }

            jobDropdown.Text = jobText;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private async void SaveData()
        {
            if (currentMode == 2)
            {
                User user = new User()
                {
                    Name = nameTextBox.Text,
                    Username = usernameTextBox.Text,
                    HashedPassword = passwordTextBox.Text,
                    ContactInfo = contactTextBox.Text,
                    RoleId = (jobDropdown.Text == "Администратор") ? 1 : 2,
            };

                await context.Users.AddAsync(user);
                await this.context.SaveChangesAsync();

                UserSaved?.Invoke(this, EventArgs.Empty);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                var user = await this.context.Users
                     .Include(u => u.Role)
                     .FirstOrDefaultAsync(u => u.Id == userId);

                user.Name = nameTextBox.Text;
                user.Username = usernameTextBox.Text;
                user.HashedPassword = passwordTextBox.Text;
                user.ContactInfo = contactTextBox.Text;
                user.RoleId = (jobDropdown.Text == "Администратор") ? 1 : 2;

                await this.context.SaveChangesAsync();

                UserSaved?.Invoke(this, EventArgs.Empty);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}

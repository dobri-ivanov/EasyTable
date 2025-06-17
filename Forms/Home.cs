using EasyTable.Data;
using EasyTable.Data.Dtos;
using EasyTable.Data.Models;
using EasyTable.Forms.Admin;
using EasyTable.Forms.Controls;
using EasyTable.Forms.GenericForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTable
{
    public partial class Home : Form
    {
        private readonly EasyTableDbContext context;
        private User currentUser;

        private int currentUserId;
        public Home(int id)
        {
            InitializeComponent();

            var factory = new EasyTableDbContextFactory();
            context = factory.CreateDbContext(new string[0]);

            currentUserId = id;
            this.Load += Home_Load;

        }

        private async void Home_Load(object sender, EventArgs e)
        {
            SetUpForm();
            await LoadUsersAsync();
            await LoadCurrentUser(currentUserId);
        }

        private async Task LoadCurrentUser(int id)
        {
            currentUser =  await context.Users.Include(x => x.Role).FirstOrDefaultAsync(u => u.Id == id);
            navBar1.EmployeeName = currentUser.Name;
        }
        private void SetUpForm()
        {
            //Events
            optionsMenu.EditClicked += OptionsMenu_Edit;
            optionsMenu.DeleteClicked += OptionsMenu_Delete;
            optionsMenu.ViewClicked += OptionsMenu_View;
        }

        #region Resizing
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            const int resizeArea = 15;

            if (m.Msg == WM_NCHITTEST)
            {
                Point pos = PointToClient(Cursor.Position);

                if (pos.X < resizeArea && pos.Y < resizeArea)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (pos.X > Width - resizeArea && pos.Y < resizeArea)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (pos.X < resizeArea && pos.Y > Height - resizeArea)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (pos.X > Width - resizeArea && pos.Y > Height - resizeArea)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (pos.X < resizeArea)
                    m.Result = (IntPtr)HTLEFT;
                else if (pos.X > Width - resizeArea)
                    m.Result = (IntPtr)HTRIGHT;
                else if (pos.Y < resizeArea)
                    m.Result = (IntPtr)HTTOP;
                else if (pos.Y > Height - resizeArea)
                    m.Result = (IntPtr)HTBOTTOM;
                else
                    base.WndProc(ref m); // само ако не е в resize зоните

                return;
            }

            base.WndProc(ref m);
        }
        #endregion

        #region Admin

        //FillUserData
        public async Task LoadUsersAsync()
        {
            var list = await context.Users
                .Include(u => u.Role)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    UserName = u.Username,
                    RoleName = u.Role.RoleName == "Admin" ? "Администратор" : u.Role.RoleName == "Waiter" ? "Сервитьор" : u.Role.RoleName,
                    ContactInfo = u.ContactInfo,
                })
                .ToListAsync();

            userDtoBindingSource.DataSource = list;
        }

        //Open Options Menu
        private void bunifuDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                int currentRowUserId = int.Parse(bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                string currentRowUserRole = bunifuDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (currentUser.Role.Id == 3)
                {
                    Point screenPos = Cursor.Position;

                    Point clientPos = this.PointToClient(screenPos);
                    optionsMenu.SetId(currentRowUserId);

                    int x = clientPos.X - optionsMenu.Width;
                    int y = clientPos.Y;

                    optionsMenu.Visible = true;
                    optionsMenu.Location = new Point(this.Size.Width - optionsMenu.Size.Width - 203, y - 100);
                }
                else if ((currentUser.Id != currentRowUserId || currentUser.RoleId == 3) && currentRowUserRole != "Администратор")
                {
                    Point screenPos = Cursor.Position;

                    Point clientPos = this.PointToClient(screenPos);
                    optionsMenu.SetId(currentRowUserId);

                    int x = clientPos.X - optionsMenu.Width;
                    int y = clientPos.Y;

                    optionsMenu.Visible = true;
                    optionsMenu.Location = new Point(this.Size.Width - optionsMenu.Size.Width - 203, y - 100);
                }
                else
                {
                    Notification.Show(this, "Нямате достъп!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
               

            }
        }

        //Option Menu open/close
        private void bunifuDataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var cell = bunifuDataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewImageCell;
                cell.Value = Properties.Resources.icon_options_hover;
            }

        }
        private void bunifuDataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var cell = bunifuDataGridView1[e.ColumnIndex, e.RowIndex] as DataGridViewImageCell;
                cell.Value = Properties.Resources.icon_options_new;
            }
        }

        //Option Menu buttons' events
        private void OptionsMenu_View(int userId)
        {
            if (userId != currentUser.Id)
            {
                ViewAddEditUserDialog viewEditUserDialog = new ViewAddEditUserDialog(1, userId);
                viewEditUserDialog.Show();
            }


        }
        private void OptionsMenu_Edit(int userId)
        {
            ViewAddEditUserDialog viewEditUserDialog = new ViewAddEditUserDialog(3, userId);
            viewEditUserDialog.UserSaved += async (_, __) => await LoadUsersAsync();
            viewEditUserDialog.Show();
        }

        private async void OptionsMenu_Delete(int userId)
        {
            bool ok = ConfirmationForm.Show(
                title: "Сигурни ли сте, че искате да изтриете този потребител?",
                confirmText: "Изтрий",
                cancelText: "Откажи");

            if (!ok)
                return;

            var user = await context.Users.FindAsync(userId);
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            await LoadUsersAsync();
        }
        #endregion

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            ViewAddEditUserDialog viewEditUserDialog = new ViewAddEditUserDialog(2);
            viewEditUserDialog.UserSaved += async (_, __) => await LoadUsersAsync();
            viewEditUserDialog.Show();
        }
    }
}

using EasyTable.Data;
using EasyTable.Data.Dtos;
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
        public Home()
        {
            InitializeComponent();
            var factory = new EasyTableDbContextFactory();
            context = factory.CreateDbContext(new string[0]);

            LoadUsersAsync();


        }

        private async Task LoadUsersAsync()
        {
            var list = await context.Users
                .Include(u => u.Role)           // само за сигурност, но вече не ти трябва навигация в грида
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    UserName = u.Username,
                    RoleName = u.Role.RoleName,
                    ContactInfo = u.ContactInfo,
                })
                .ToListAsync();

            userDtoBindingSource.DataSource = list;
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void OptionsMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

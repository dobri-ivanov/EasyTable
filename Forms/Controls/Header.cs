using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EasyTable.Forms.Controls
{
    public partial class Header : UserControl
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private Timer cursorResetTimer;

        private Rectangle previousBounds;
        private bool isMaximized = false;
        public Header()
        {
            InitializeComponent();

            cursorResetTimer = new Timer();
            cursorResetTimer.Interval = 50;
            cursorResetTimer.Tick += CursorResetTimer_Tick;
        }

        private void CursorResetTimer_Tick(object sender, EventArgs e)
        {
            cursorResetTimer.Stop();
            this.Cursor = Cursors.Default;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            Form form = FindForm();

            if (!isMaximized)
            {
                previousBounds = form.Bounds;
                ResizeButton.Image = EasyTable.Properties.Resources.icon_resize_back;

                form.Bounds = Screen.FromControl(form).WorkingArea;
                isMaximized = true;
            }
            else
            { 
                ResizeButton.Image = EasyTable.Properties.Resources.icon_resize_fullscreen;
                form.Bounds = previousBounds;
                isMaximized = false;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }

        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isMaximized)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Cursor = Cursors.Hand;

                    ReleaseCapture();
                    SendMessage(FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);

                    cursorResetTimer.Start();
                }
            }
        }

        private void bunifuPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isMaximized)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Cursor = Cursors.Hand;

                    ReleaseCapture();
                    SendMessage(FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);

                    cursorResetTimer.Start();
                }
            }
        }
    }
}

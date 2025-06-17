using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EasyTable.Forms.Controls
{
    public partial class UsersOptions : UserControl
    {
        public int userId;

        public event Action<int> EditClicked;
        public event Action<int> DeleteClicked;
        public event Action<int> ViewClicked;

        public UsersOptions()
        {
            InitializeComponent();
            this.Visible = false;

            AutoHide();
        }

        private void OnMouseLeftControl(object sender, EventArgs e)
        {
            Point pt = this.PointToClient(Cursor.Position);

            if (!this.ClientRectangle.Contains(pt))
                this.Visible = false;
        }

        private void AutoHide()
        {
            this.Leave += (_, __) => this.Visible = false;

            this.MouseLeave += OnMouseLeftControl;
            foreach (Control child in this.Controls)
                child.MouseLeave += OnMouseLeftControl;
        }

        public void SetId(int userId)
        {
            this.userId = userId;
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            ViewClicked?.Invoke(userId);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(userId);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(userId);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyTable.Forms.Controls
{
    public partial class UsersOptions : UserControl
    {
        private int _rowId;

        public int userId;

        // Събития, които формата ще слуша
        public event Action<int> EditClicked;
        public event Action<int> DeleteClicked;
        public event Action<int> ViewClicked;

        public UsersOptions()
        {
            InitializeComponent();

            this.Visible = false;

            EditBtn.Click += (_, __) => EditClicked?.Invoke(_rowId);
            DeleteBtn.Click += (_, __) => DeleteClicked?.Invoke(_rowId);
            DetailsBtn.Click += (_, __) => ViewClicked?.Invoke(_rowId);

            this.Leave += (_, __) => this.Visible = false;

            EditBtn.Text = userId.ToString();

            this.MouseLeave += OnMouseLeftControl;
            foreach (Control child in this.Controls)
                child.MouseLeave += OnMouseLeftControl;
        }

        private void OnMouseLeftControl(object sender, EventArgs e)
        {
            // Get mouse pos relative to this control
            Point pt = this.PointToClient(Cursor.Position);

            // If it's outside our client rectangle, hide
            if (!this.ClientRectangle.Contains(pt))
                this.Visible = false;
        }

        public void SetId(int id)
        {
            EditBtn.Text = id.ToString();
        }
    }
}

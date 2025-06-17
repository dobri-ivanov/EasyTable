using System.ComponentModel;
using System.Windows.Forms;

namespace EasyTable.Forms.Controls
{
    public partial class NavBar : UserControl
    {
        public NavBar()
        {
            InitializeComponent();
        }

        private string name;

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(true)]
        public string EmployeeName
        {
            get => name;
            set
            {
                name = value;
                employeeLabel.Text = value;
            }
        }
    }
}

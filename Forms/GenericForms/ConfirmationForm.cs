using System;
using System.Windows.Forms;

namespace EasyTable.Forms.GenericForms
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        public new string Text
        {
            get => textLbl.Text;
            set => textLbl.Text = value;
        }

        public string ConfirmButtonText
        {
            get => btnYes.Text;
            set => btnYes.Text = value;
        }

        public string CancelButtonText
        {
            get => btnNo.Text;
            set => btnNo.Text = value;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static bool Show(
        string title = "Потвърждение",
        string confirmText = "Да",
        string cancelText = "Откажи")
        {
            using (var dlg = new ConfirmationForm())
            {
                dlg.Text = title;
                dlg.ConfirmButtonText = confirmText;
                dlg.CancelButtonText = cancelText;
                return dlg.ShowDialog() == DialogResult.OK;
            }
        }
    }
}

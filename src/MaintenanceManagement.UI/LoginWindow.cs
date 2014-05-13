using System.Windows.Forms;

namespace MaintenanceManagement.UI
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public string Login { get { return txtLogin.Text; } }
        public string Password { get { return txtPassword.Text; } }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}

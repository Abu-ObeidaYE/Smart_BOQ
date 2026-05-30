using System;
using System.Windows.Forms;

namespace Smart_BOQ.Views.AccountsAndSubscriptions
{
    public partial class AccountManagementForm : Form
    {
        public AccountManagementForm()
        {
            InitializeComponent();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
        }

        private void btnChangePhone_Click(object sender, EventArgs e)
        {
        }

        private void btnEnable2FA_Click(object sender, EventArgs e)
        {
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtNewPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmNewPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}

using System;
using System.Windows.Forms;
using ShopManager.Models;
using ShopManager.Repositories;

namespace ShopManager
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IAppUsersManager _appUsersManager;

        public LoginForm(IAppUsersManager appUsersManager)
        {
            _appUsersManager = appUsersManager;
            InitializeComponent();
            
            cbxUsers.Properties.DisplayMember = "UserName";
            cbxUsers.Properties.ValueMember = "UserId";
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            cbxUsers.Properties.DataSource = await _appUsersManager.GetUsersList();
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newLogin = new AppUser();
                newLogin.UserName = cbxUsers.Text.Trim();
                newLogin.UserPassword = PasswordTextBox.Text.Trim();
                var result = await _appUsersManager.AcceptLogin(newLogin);
                if (result != null)
                {
                    PublicValues.UserID = result.UserId;
                    PublicValues.UserName = result.UserName;
                    PublicMessage.WellComeMessage(result.UserName);
                    //Logger 
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    PublicMessage.ErrorLoginMessage();
                }
            }
            catch 
            {
                PublicMessage.ErrorLoginMessage();
            }

          
        }

        private void cbxUsers_EditValueChanged(object sender, EventArgs e)
        {
            PasswordTextBox.Focus();
            PasswordTextBox.SelectAll();
        }
    }
}

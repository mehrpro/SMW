using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            cbxUsers.Properties.DataSource = await _appUsersManager.GetUsersList();
        }
    }
}

using System;
using ShopManager.Models;
using ShopManager.Repositories;

namespace ShopManager.AppForms
{
    public partial class SallerForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IAppUsersManager _appUsers;
        private Account _saller;
        public SallerForm(IAppUsersManager appUsers)
        {
            _appUsers = appUsers;
            InitializeComponent();
            ClearForm();
        }

        private async void ClearForm()
        {
            SallerListGridControl.DataSource = await _appUsers.GetSallerList();
            txtAddress.EditValue = txtNameFamily.EditValue =
                txtCompany.EditValue = txtFax.EditValue = txtMobile.EditValue = txtPhone.EditValue = null;
            _saller= new Account();
        }

        private void GetValues()
        {
            _saller.FullName = txtNameFamily.Text.Trim();
            _saller.Company = txtCompany.Text.Trim();
            _saller.Mobile = txtMobile.Text.Trim();
            _saller.PhoneNumber = txtPhone.Text.Trim();
            _saller.FaxNumber = txtFax.Text.Trim();
            _saller.Address = txtAddress.Text.Trim();
            _saller.GLEID_FK = 1;
        }
        private async void btnSaveButton_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider.Validate())
            {
                PublicMessage.ComplateFormMessage(Text);
                return;
            }
            GetValues();
            var result = await _appUsers.AddNewSaller(_saller);
            if (result)
            {
                PublicMessage.SuccessesSaveMessage(Text);
                ClearForm();
            }
            else
                PublicMessage.ErrorSaveMessage(Text);

        }

        private void SetValues(Account saller)
        {
            txtNameFamily.Text = saller.FullName;
            txtCompany.Text = saller.Company;
            txtMobile.Text = saller.Mobile;
            txtPhone.Text = saller.PhoneNumber;
            txtFax.Text = saller.FaxNumber;
            txtAddress.Text = saller.Address;
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("SallerId") != null)
            {
                _saller = new Account();
                _saller = (Account)gridView1.GetFocusedRow();
                SetValues(_saller);
            }
        }

        private void btnCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

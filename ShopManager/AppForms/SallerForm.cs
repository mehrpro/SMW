using System;
using ShopManager.Models;
using ShopManager.Repositories;

namespace ShopManager.AppForms
{
    public partial class SallerForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IAppUsersManager _appUsers;
        private Saller _saller;
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
            _saller= new Saller();
        }

        private void GetValues()
        {
            _saller.SallerName = txtNameFamily.Text.Trim();
            _saller.SallerCompany = txtCompany.Text.Trim();
            _saller.SallerMobile = txtMobile.Text.Trim();
            _saller.SallerPhoneNumber = txtPhone.Text.Trim();
            _saller.SallerFaxNumber = txtFax.Text.Trim();
            _saller.SallerAddress = txtAddress.Text.Trim();
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

        private void SetValues(Saller saller)
        {
            txtNameFamily.Text = saller.SallerName;
            txtCompany.Text = saller.SallerCompany;
            txtMobile.Text = saller.SallerMobile;
            txtPhone.Text = saller.SallerPhoneNumber;
            txtFax.Text = saller.SallerFaxNumber;
            txtAddress.Text = saller.SallerAddress;
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("SallerId") != null)
            {
                _saller = new Saller();
                _saller = (Saller)gridView1.GetFocusedRow();
                SetValues(_saller);
            }
        }

        private void btnCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

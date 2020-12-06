using System;
using System.Threading.Tasks;
using ShopManager.Models;
using ShopManager.Repositories;

namespace ShopManager.AppForms
{
    public partial class CustomersForm : DevExpress.XtraEditors.XtraForm
    {
        private IAppUsersManager _appUsers;
        private Customer _customer;

        public CustomersForm(IAppUsersManager appUsers)
        {
            _appUsers = appUsers;
            InitializeComponent();
            ClearForm();
        }


        private void ClearForm()
        {
            txtDescription.EditValue = txtCustomerName.EditValue = txtCustromerMobile.EditValue = null;
            _customer = new Customer();
        }
        private void GetCustomer()
        {
            _customer.CustomerName = txtCustomerName.Text;
            _customer.CustomerMobile = txtCustromerMobile.Text;
            _customer.CustomerAddress = txtDescription.Text;
        }

        private void SetCustomer()
        {
            txtCustomerName.Text = _customer.CustomerName;
            txtCustromerMobile.Text = _customer.CustomerMobile;
            txtDescription.Text = _customer.CustomerAddress;
        }
        private async Task UpdateCustomersList()
        {
            CustomersGridControl.DataSource = await _appUsers.GetAllCustomer();
        }

        private void btnCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSaveButton_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                PublicMessage.ComplateFormMessage(Text);
            }
            else
            {
                GetCustomer();
                var result = await _appUsers.AddNewCustomers(_customer);
                if (result)
                {
                    PublicMessage.SuccessesSaveMessage(Text);
                    ClearForm();
                    await UpdateCustomersList();
                }
                else
                    PublicMessage.ErrorSaveMessage(Text);
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (gridViewInvoiceList.GetFocusedRowCellValue("CustomerName") != null)
            {
                ClearForm();
                _customer = (Customer) gridViewInvoiceList.GetFocusedRow();
                SetCustomer();
            }
        }

        private async void CustomersForm_Load(object sender, EventArgs e)
        {
            await UpdateCustomersList();
        }
    }
}

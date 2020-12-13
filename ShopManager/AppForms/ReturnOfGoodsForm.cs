using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopManager.Models;
using ShopManager.Repositories;
using ShopManager.ViewModels.Goods;

namespace ShopManager.AppForms
{
    public partial class ReturnOfGoodsForm : XtraForm
    {
        private IAppUsersManager _appUsers;
        private IGoodsClass _goodsClass;
        private List<StoreProductViewModel> _tempStoreProductViewModels;
        private List<StoreProductViewModel> _tempStoreProductViewModelsRemove;
        public ReturnOfGoodsForm(IAppUsersManager appUsers, IGoodsClass goodsClass)
        {
            _appUsers = appUsers;
            _goodsClass = goodsClass;
            InitializeComponent();
            cbxCustomers.Properties.DisplayMember = "CustomerName";
            cbxCustomers.Properties.ValueMember = "CustomerId";
            _tempStoreProductViewModels = _tempStoreProductViewModelsRemove = new List<StoreProductViewModel>();

        }
        /// <summary>
        /// لیست مشتریان
        /// </summary>
        /// <returns></returns>
        private async Task CustomersList()
        {
            cbxCustomers.Properties.DataSource = await _appUsers.GetAllCustomer();
        }

        private async void ReturnOfGoodsForm_Load(object sender, EventArgs e)
        {
            await CustomersList();
        }

        private async void cbxCustomers_EditValueChanged(object sender, EventArgs e)
        {
            var select = (Account)cbxCustomers.GetSelectedDataRow();
            if (select == null)
            {
                cbxInvoiceList.Properties.DataSource = null;


            }

            cbxInvoiceList.Properties.DataSource = await _goodsClass.GetOrdersListByCustomerId(select.AccountID);

        }

        private void UpdateNewSum()
        {
            txtNewSumInvoice.EditValue = _tempStoreProductViewModels.Sum(x => x.SumAfterPercent);
        }

        private void UpdateList()
        {
            OrderDitailsGridControl.DataSource = _tempStoreProductViewModels;
            gridViewInvoiceList.RefreshData();
            UpdateNewSum();


        }
        private async void RenewFactor()
        {
            var selectFactor = (Order)cbxInvoiceList.GetSelectedDataRow();
            if (selectFactor == null)
            {
                txtNewSumInvoice.EditValue = txtSumInvoice.EditValue = 0;
                OrderDitailsGridControl.DataSource = null;
            }

            txtSumInvoice.EditValue = selectFactor.SumPrice;
            _tempStoreProductViewModels = await _goodsClass.GetOrderDetaisByOrderId(selectFactor.OrderId);
            UpdateList();
        }
        private void cbxInvoiceList_EditValueChanged(object sender, EventArgs e)
        {
            RenewFactor();

        }



        private void btnCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReloadFactor_Click(object sender, EventArgs e)
        {
            _tempStoreProductViewModels = _tempStoreProductViewModelsRemove = new List<StoreProductViewModel>();
            RenewFactor();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (gridViewInvoiceList.GetFocusedRowCellValue("ProductName") != null)
            {
                var selectforRemove = (StoreProductViewModel)gridViewInvoiceList.GetFocusedRow();
                _tempStoreProductViewModels.Remove(selectforRemove);
                _tempStoreProductViewModelsRemove.Add(selectforRemove);
                UpdateList();
            }
        }

        private async void btnReturnOfCash_Click(object sender, EventArgs e)
        {
            var result = await _goodsClass.ReturnStoreProduct(_tempStoreProductViewModels);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopManager.Repositories;
using ShopManager.StructureMapping;
using System.Globalization;
using ShopManager.Models;
using ShopManager.ViewModels.Goods;

namespace ShopManager.AppForms
{
    public partial class SalesForm : DevExpress.XtraEditors.XtraForm
    {
        private IAppUsersManager _appUsers;
        private IGoodsClass _goodsClass;
        private List<StoreProductViewModel> _storeProduct;
        public SalesForm(IAppUsersManager appUsers, IGoodsClass goodsClass)
        {
            _appUsers = appUsers;
            _goodsClass = goodsClass;
            InitializeComponent();
            dateInvoice.DateTime = DateTime.Today;
            _storeProduct = new List<StoreProductViewModel>();

            cbxCustomers.Properties.DisplayMember = "CustomerName";
            cbxCustomers.Properties.ValueMember = "CustomerId";

            cbxStoreProduct.Properties.DisplayMember = "ProductList.ProductName";
            cbxStoreProduct.Properties.ValueMember = "StoreId";
        }


        private void CheckSalerGridControl()
        {
            if (_storeProduct.Count > 0)
            {
                cbxCustomers.Enabled = false;
            }
            else
            {
                cbxCustomers.Enabled = true;
            }
        }
        /// <summary>
        /// دکمه افزودن مشتری جدید
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            using (var tempContainer = new StructureMap.Container(new TypeRegistery()))
            {
                var instance = tempContainer.GetInstance<CustomersForm>();
                instance.ShowDialog();
                await CustomersList();
            }
        }
        /// <summary>
        /// لیست مشتریان
        /// </summary>
        /// <returns></returns>
        private async Task CustomersList()
        {
            cbxCustomers.Properties.DataSource = await _appUsers.GetAllCustomer();
        }
        /// <summary>
        /// لیست کالا
        /// </summary>
        /// <returns></returns>
        private async Task UpdateStoreProduct()
        {
            cbxStoreProduct.Properties.DataSource = await _goodsClass.GetStoreProduct();
        }
        /// <summary>
        /// فاکتور فروش
        /// </summary>
        /// <returns></returns>
        private async Task UpdateGridControl()
        {
            CheckSalerGridControl();
            SalerGridControl.DataSource = _storeProduct;
            gridViewInvoiceList.RefreshData();
        }

        private async void SalesForm_Load(object sender, EventArgs e)
        {
            await CustomersList();
            await UpdateStoreProduct();
        }

        private void cbxStoreProduct_EditValueChanged(object sender, EventArgs e)
        {
            var selectedData = (StoreProductList)cbxStoreProduct.GetSelectedDataRow();
            if (selectedData == null)
            {
                txtNumbers.EditValue = null;
                numNumbers.EditValue = 0;
                txtUnits.EditValue = null;
                txtCurrency.EditValue = 0;
                numPercent.Properties.MaxValue = 100;
                
                return;
            }

            numNumbers.Properties.MinValue = numPercent.Properties.MinValue = 0;
            txtNumbers.EditValue = selectedData.Numbers;
            numNumbers.Properties.MaxValue = (decimal) selectedData.Numbers;
            txtUnits.EditValue = selectedData.ProductList.Unit.UnitName;
            numPercent.Properties.MaxValue = selectedData.Percent;
            txtCurrency.EditValue = selectedData.Price;
        }

        private StoreProductViewModel GetViewModel()
        {
     
            var newModel = new StoreProductViewModel
            {
                Customers_FK = Convert.ToInt32(cbxCustomers.EditValue),
                OrderDate = dateInvoice.DateTime,
                InvoiceType_FK = 2,
                SumPrice = Convert.ToDouble(txtSum.EditValue),
                ProductName = cbxStoreProduct.Text,
                StoreId_FK = Convert.ToInt32(cbxStoreProduct.EditValue),
                Numbers = Convert.ToDouble(numNumbers.EditValue),
                Price = Convert.ToDouble(txtCurrency.EditValue),
                UnitNam = txtUnits.Text,
                Percent = Convert.ToByte(numPercent.EditValue),
                PercentPrice = Convert.ToDouble(txtPercentPrice.EditValue),
                SumAfterPercent = Convert.ToDouble(txtSumAfterPercent.EditValue),
            };
            return newModel;
        }

        private void ClearItem()
        {
            cbxStoreProduct.EditValue = null;
        }
        private void btnCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAddToList_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                PublicMessage.ComplateFormMessage(Text);
            }
            else
            {
                _storeProduct.Add(GetViewModel());
                ClearItem();
                await UpdateGridControl();
            }
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            if (gridViewInvoiceList.GetFocusedRowCellValue("ProductName") != null)
            {
                var select = (StoreProductViewModel) gridViewInvoiceList.GetFocusedRow();
                _storeProduct.Remove(select);
                await UpdateGridControl();
            }
        }


        private void Sumer()
        {
            var a1 = Convert.ToDouble(numNumbers.EditValue) * Convert.ToDouble(txtCurrency.EditValue);
            var a2 = a1 * Convert.ToByte(numPercent.EditValue) / 100;
            txtPercentPrice.Text = a2.ToString(CultureInfo.InvariantCulture);
            txtSum.EditValue = a1;
            txtSumAfterPercent.EditValue = a1 - a2;
        }
        private void numNumbers_EditValueChanged(object sender, EventArgs e)
        {
            Sumer();
        }

        private void numTakfif_EditValueChanged(object sender, EventArgs e)
        {
            Sumer();
        }

        private async void btnSaveButton_Click(object sender, EventArgs e)
        {
            if (_storeProduct.Count > 0)
            {
                if (await  _goodsClass.AddOrders(_storeProduct))
                {
                    PublicMessage.SuccessesSaveMessage(Text);
                    ClearForm();
                }
                else
                    PublicMessage.ErrorSaveMessage(Text);
            }
            else
            {
                PublicMessage.ComplateFormMessage(Text);
            }
        }

        private async void ClearForm()
        {
            cbxStoreProduct.EditValue = cbxCustomers.EditValue = null;
            _storeProduct = new List<StoreProductViewModel>();
            await UpdateGridControl();
        }
    }
}

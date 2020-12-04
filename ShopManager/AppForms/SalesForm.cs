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
using ShopManager.StructureMapping;
using System.Data.Entity;
using ShopManager.Models;

namespace ShopManager.AppForms
{
    public partial class SalesForm : DevExpress.XtraEditors.XtraForm
    {
        private IAppUsersManager _appUsers;
        private IGoodsClass _goodsClass;
        public SalesForm(IAppUsersManager appUsers, IGoodsClass goodsClass)
        {
            _appUsers = appUsers;
            _goodsClass = goodsClass;
            InitializeComponent();
            dateInvoice.DateTime = DateTime.Today;

            cbxCustomers.Properties.DisplayMember = "CustomerName";
            cbxCustomers.Properties.ValueMember = "CustomerId";

            cbxStoreProduct.Properties.DisplayMember = "ProductList.ProductName";
            cbxStoreProduct.Properties.ValueMember = "StoreId";

        }

        private async void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            using (var tempContainer = new StructureMap.Container(new TypeRegistery()))
            {
                var instance = tempContainer.GetInstance<CustomersForm>();
                instance.ShowDialog();
                await CustomersList();
            }
        }
        private async Task CustomersList()
        {
            cbxCustomers.Properties.DataSource = await _appUsers.GetAllCustomer();
        }

        private async Task UpdateStoreProduct()
        {
            cbxStoreProduct.Properties.DataSource = await _goodsClass.GetStoreProduct();
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
                return;
            }
            txtNumbers.EditValue = selectedData.Numbers;
            numNumbers.Properties.MaxValue = (decimal) selectedData.Numbers;
            txtUnits.EditValue = selectedData.ProductList.Unit.UnitName;
            txtCurrency.EditValue = selectedData.Price;
        }
    }
}

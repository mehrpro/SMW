using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopManager.Models;
using ShopManager.Repositories;

namespace ShopManager.AppForms
{
    public partial class ReturnOfGoodsForm : XtraForm
    {
        private IAppUsersManager _appUsers;
        private IGoodsClass _goodsClass;
        public ReturnOfGoodsForm(IAppUsersManager appUsers, IGoodsClass goodsClass)
        {
            _appUsers = appUsers;
            _goodsClass = goodsClass;
            InitializeComponent();
            cbxCustomers.Properties.DisplayMember = "CustomerName";
            cbxCustomers.Properties.ValueMember = "CustomerId";

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

        private void cbxCustomers_EditValueChanged(object sender, EventArgs e)
        {
            var select = (Customer) cbxCustomers.GetSelectedDataRow();
            if (select == null)
            {
                cbxInvoiceList.Properties.DataSource = null;
               

            }
            
        }

        private async void cbxInvoiceList_EditValueChanged(object sender, EventArgs e)
        {
            var selectFactor = (Order) cbxInvoiceList.GetSelectedDataRow();
            if (selectFactor == null)
            {
                txtNewSumInvoice.EditValue = txtSumInvoice.EditValue = 0;
                OrderDitailsGridControl.DataSource = null;
            }

            txtNewSumInvoice.EditValue = txtSumInvoice.EditValue = selectFactor.SumPrice;
            OrderDitailsGridControl.DataSource = await  _goodsClass.get
        }
    }
}

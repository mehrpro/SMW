using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShopManager.Models;
using ShopManager.Repositories;
using ShopManager.StructureMapping;
using ShopManager.ViewModels.Goods;

namespace ShopManager.AppForms
{
    public partial class PurchaseInvoiceForm : XtraForm
    {
        private IAppUsersManager _usersManager;
        private IGoodsClass _goodsClass;
        private List<InvoiceTempList> _invoicies;
        public PurchaseInvoiceForm(IAppUsersManager usersManager, IGoodsClass goodsClass)
        {
            _usersManager = usersManager;
            _goodsClass = goodsClass;
            InitializeComponent();
            dateInvoice.DateTime = DateTime.Now;

            _invoicies= new List<InvoiceTempList>();

            cbxSallerList.Properties.DisplayMember = "SallerName";
            cbxSallerList.Properties.ValueMember = "SallerId";

            cbxUnites.Properties.DisplayMember = "UnitName";
            cbxUnites.Properties.ValueMember = "UnitId";

            cbxProductList.Properties.DisplayMember = "ProductName";
            cbxProductList.Properties.ValueMember = "ProductId";
        }

        private async Task SallerList()
        {
            cbxSallerList.Properties.DataSource = await _usersManager.GetSallerList();
        }
        private async Task ProductsList()
        {
            cbxProductList.Properties.DataSource = await _goodsClass.GetProductList();
        }
        private async Task UnitesList()
        {
            cbxUnites.Properties.DataSource = await _goodsClass.GetUnitList();
        }


        private  void btnCloseButton_Click(object sender, EventArgs e)
        {
                Close();
        }

        private async void PurchaseInvoiceForm_Load(object sender, EventArgs e)
        {
            await SallerList();
            await ProductsList();
            await UnitesList();
        }


        private async Task InvoceCheck()
        {
            if (_invoicies.Count == 0)
            {
                dateInvoice.Enabled=cbxSallerList.Enabled=txtInvoiceNumber.Enabled = true;
            }
            else
            {
                if (dateInvoice.EditValue != null && cbxSallerList.EditValue != null )
                {
                    dateInvoice.Enabled = cbxSallerList.Enabled =txtInvoiceNumber.Enabled = false;
                }
                
            }
        }
        private async void btnSallerAdd_Click(object sender, EventArgs e)
        {
            using (var tempContainer = new StructureMap.Container(new TypeRegistery()))
            {
                var instance = tempContainer.GetInstance<SallerForm>();
                instance.WindowState = FormWindowState.Maximized;
                instance.ShowDialog();
                await SallerList();
            }
            
        }

        private async void btnProductAdd_Click(object sender, EventArgs e)
        {
            using (var tempContainer = new StructureMap.Container(new TypeRegistery()))
            {
                var instance = tempContainer.GetInstance<NewGoodsForm>();
                instance.WindowState = FormWindowState.Maximized;
                instance.ShowDialog();
                await ProductsList();

            }
        }

        private async void btnUnitAdd_Click(object sender, EventArgs e)
        {
            using (var tempContainer = new StructureMap.Container(new TypeRegistery()))
            {
                var instance = tempContainer.GetInstance<UnitsForm>();
               // instance.WindowState = FormWindowState.Maximized;
                instance.ShowDialog();
                await UnitesList();
            }
        }

        private InvoiceTempList getPurchaseInvoicy()
        {
            var newInvoiceItem = new InvoiceTempList
            {
                InvoiceDate = dateInvoice.DateTime.Date,
                InvoiceType_FK = 1,
                ProductList_FK = Convert.ToInt32(cbxProductList.EditValue),
                Saller_FK = Convert.ToInt32(cbxSallerList.EditValue),
                PurchasePrice = Convert.ToDouble(txtCurrency.EditValue),
                Unit_FK = Convert.ToInt32(cbxUnites.EditValue),
                Numbers = Convert.ToDouble(numNumbers.EditValue),
                AppUser_FK = PublicValues.UserID,
                Goods = cbxProductList.Text,
                Currency = Convert.ToDouble(txtCurrency.EditValue),
                UnitName = cbxUnites.Text,
                SumCurrency = Convert.ToDouble(txtCurrency.EditValue) * Convert.ToDouble(numNumbers.EditValue),
                InvoiceNumber = txtInvoiceNumber.Text.Trim(),
                Frosh = Convert.ToDouble(txtFroshe.EditValue),

            };
            return newInvoiceItem;
        }

        private async void UpdateInvoiceGridControl()
        {
            await InvoceCheck();
            InvoiceGridControl.DataSource = _invoicies;
            gridViewInvoiceList.RefreshData();
        }
        private void ClearItem()
        {
            cbxProductList.EditValue = cbxUnites.EditValue = 
                txtCurrency.EditValue =txtInvoiceNumber.EditValue = null;
            numNumbers.EditValue = 0;

        }
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                PublicMessage.ComplateFormMessage(Text);
            }
            else
            {
                _invoicies.Add(getPurchaseInvoicy());
                UpdateInvoiceGridControl();
                ClearItem();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (gridViewInvoiceList.GetFocusedRowCellValue("Goods") !=null)
            {
                var select = (InvoiceTempList) gridViewInvoiceList.GetFocusedRow();
                _invoicies.Remove(select);
                UpdateInvoiceGridControl();
            }
        }

        private void cbxProductList_EditValueChanged(object sender, EventArgs e)
        {
            var select = (ProductList) cbxProductList.GetSelectedDataRow();
            if (select == null)
            {
                cbxUnites.EditValue = null;
                txtCurrency.EditValue = null;
                numNumbers.EditValue = 0;
                return;
            }

            cbxUnites.EditValue = select.UnitId_FK;
        }

        private void ClearForm()
        {
            ClearItem();
            cbxSallerList.EditValue = null;
            _invoicies = new List<InvoiceTempList>();
            UpdateInvoiceGridControl();
            
        }
        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async Task<bool> Save(List<InvoiceTempList> invoiceTempList)
        {
            return await _goodsClass.AddPurchaseInvoice(invoiceTempList);
        }
        private async void btnSaveButton_Click(object sender, EventArgs e)
        {
            var result = await Save(_invoicies);
            if (result)
            {
                PublicMessage.SuccessesSaveMessage(Text);
                ClearForm();
            }
            else
                PublicMessage.ErrorSaveMessage(Text);

        }

        private void pre()
        {
            txtFroshe.EditValue = (Convert.ToDouble(txtCurrency.EditValue) * Convert.ToDouble(numPerc.EditValue)) /100 +
                   Convert.ToDouble(txtCurrency.EditValue);
        }
        private void txtCurrency_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtCurrency.EditValue) > 0)
            {
                pre();
            }
            else
            {
                txtFroshe.EditValue = 0;
            }
        }

        private void numPerc_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtCurrency.EditValue) > 0)
                pre();
            else
                txtFroshe.EditValue = 0;
        }
    }


}

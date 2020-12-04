
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopManager.Models;
using ShopManager.Repositories;
using ShopManager.StructureMapping;
using ShopManager.ViewModels.Goods;

namespace ShopManager.AppForms
{
    public partial class NewGoodsForm : DevExpress.XtraEditors.XtraForm
    {
        private IGoodsClass _goodsClass;
        private ProductList _selected;
 

        public NewGoodsForm(IGoodsClass goodsClass)
        {
            _goodsClass = goodsClass;
            InitializeComponent();
            cbxUnits.Properties.DisplayMember = "UnitName";
            cbxUnits.Properties.ValueMember = "UnitId";
        }

        private async void ClearForm()
        {
            txtGoodsName.EditValue =txtBarcode.EditValue = txtDescription.EditValue = cbxUnits.EditValue = null;
            _selected = new ProductList();
            ProductListGridControl.DataSource = await _goodsClass.GetProductList();
        }
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider.Validate())
            {
                PublicMessage.ComplateFormMessage(Text);
                return;
            }
            GetValues();
            var result = await _goodsClass.AddNewProduct(_selected);
            if (result != null)
            {
                PublicMessage.SuccessesSaveMessage(Text);
                ClearForm();
            }
            else
                PublicMessage.ErrorSaveMessage(Text);

        }



        private void GetValues()
        {

            _selected.ProductName = txtGoodsName.Text.Trim();
            _selected.Description = txtDescription.Text.Trim();
            _selected.UnitId_FK = Convert.ToInt32(cbxUnits.EditValue);
            _selected.ProductNumber = txtBarcode.Text.Trim();

        }

        private void SetValues(ProductList productList)
        {
            txtGoodsName.EditValue = productList.ProductName;
            txtBarcode.EditValue = productList.ProductNumber;
            txtDescription.EditValue = productList.Description;
            cbxUnits.EditValue = productList.UnitId_FK;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ProductId") != null)
            {
                _selected = new ProductList();
                _selected = (ProductList)gridView1.GetFocusedRow();
                SetValues(_selected);
            }
        }

        private async void NewGoodsForm_Load(object sender, EventArgs e)
        {
            cbxUnits.Properties.DataSource = await _goodsClass.GetUnitList();
            ClearForm();
        }

        private void btnCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async Task UnitesList()
        {
            cbxUnits.Properties.DataSource = await _goodsClass.GetUnitList();
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
    }
}

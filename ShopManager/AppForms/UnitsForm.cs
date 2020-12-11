using System;
using System.Windows.Forms;
using ShopManager.Models;
using ShopManager.Repositories;

namespace ShopManager.AppForms
{
    public partial class UnitsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IGoodsClass _goodsClass;
        private Unit _selected;

        public UnitsForm(IGoodsClass goodsClass)
        {
            _goodsClass = goodsClass;
            InitializeComponent();
            //UnitsListGridControl.DataSource = _goodsClass.GetUnitList();
            ClearForm();
        }




        private void SelectButton_Click(object sender, EventArgs e)
        {

            if (gridView1.GetFocusedRowCellValue("UnitId") != null)
            {
                var focusedRow = gridView1.GetFocusedRow();
                _selected = new Unit();
                _selected = (Unit)focusedRow;
                UnitNameTextBox.Text = _selected.UnitName;
                EnabledCheckBox.EditValue = _selected.Enabled;
            }
        }

        private async void ClearForm()
        {
            _selected = new Unit();

            UnitNameTextBox.EditValue = null;
            EnabledCheckBox.CheckState = CheckState.Unchecked;
            UnitsListGridControl.DataSource = await _goodsClass.GetUnitList();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            _selected.UnitName = UnitNameTextBox.Text.Trim();
            _selected.Enabled = EnabledCheckBox.Checked;
            var result = await _goodsClass.AddNewUnit(_selected);
            if (result)
            {
                PublicMessage.SuccessesSaveMessage(Text);
                ClearForm();
            }
            else
            {
                PublicMessage.ErrorSaveMessage(Text);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

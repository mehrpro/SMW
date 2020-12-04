
namespace ShopManager.AppForms
{
    partial class CustomersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CustomersGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewInvoiceList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SelectButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.btnCloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustromerMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustromerMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("B Yekan", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.CustomersGridControl);
            this.groupControl1.Controls.Add(this.btnCloseButton);
            this.groupControl1.Controls.Add(this.btnSaveButton);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtCustromerMobile);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCustomerName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(764, 495);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "مدیریت مشتریان";
            // 
            // CustomersGridControl
            // 
            this.CustomersGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGridControl.Location = new System.Drawing.Point(12, 146);
            this.CustomersGridControl.MainView = this.gridViewInvoiceList;
            this.CustomersGridControl.Name = "CustomersGridControl";
            this.CustomersGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1,
            this.SelectButton});
            this.CustomersGridControl.Size = new System.Drawing.Size(740, 337);
            this.CustomersGridControl.TabIndex = 15;
            this.CustomersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvoiceList});
            // 
            // gridViewInvoiceList
            // 
            this.gridViewInvoiceList.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewInvoiceList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelect,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewInvoiceList.GridControl = this.CustomersGridControl;
            this.gridViewInvoiceList.Name = "gridViewInvoiceList";
            this.gridViewInvoiceList.OptionsBehavior.ReadOnly = true;
            this.gridViewInvoiceList.OptionsFind.AlwaysVisible = true;
            this.gridViewInvoiceList.OptionsView.ShowGroupPanel = false;
            // 
            // colSelect
            // 
            this.colSelect.ColumnEdit = this.SelectButton;
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 0;
            this.colSelect.Width = 39;
            // 
            // SelectButton
            // 
            this.SelectButton.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject2.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject3.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject4.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.SelectButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "مشتری";
            this.gridColumn1.FieldName = "CustomerName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 289;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "تلفن";
            this.gridColumn2.FieldName = "CustomerMobile";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 265;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "توضیحات";
            this.gridColumn3.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.gridColumn3.FieldName = "CustomerAddress";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 227;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // btnCloseButton
            // 
            this.btnCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseButton.ImageOptions.SvgImage = global::ShopManager.Properties.Resources.close1;
            this.btnCloseButton.Location = new System.Drawing.Point(12, 100);
            this.btnCloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseButton.Name = "btnCloseButton";
            this.btnCloseButton.Size = new System.Drawing.Size(85, 40);
            this.btnCloseButton.TabIndex = 14;
            this.btnCloseButton.Text = "بستن";
            this.btnCloseButton.Click += new System.EventHandler(this.btnCloseButton_Click);
            // 
            // btnSaveButton
            // 
            this.btnSaveButton.ImageOptions.SvgImage = global::ShopManager.Properties.Resources.save;
            this.btnSaveButton.Location = new System.Drawing.Point(101, 100);
            this.btnSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveButton.Name = "btnSaveButton";
            this.btnSaveButton.Size = new System.Drawing.Size(85, 40);
            this.btnSaveButton.TabIndex = 13;
            this.btnSaveButton.Text = "ثبت";
            this.btnSaveButton.Click += new System.EventHandler(this.btnSaveButton_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(701, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 20);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "توضیحات";
            // 
            // txtCustromerMobile
            // 
            this.txtCustromerMobile.Location = new System.Drawing.Point(191, 58);
            this.txtCustromerMobile.Name = "txtCustromerMobile";
            this.txtCustromerMobile.Parmida_ActivePlusMultiKeys = false;
            this.txtCustromerMobile.Properties.MaxLength = 10;
            this.txtCustromerMobile.Size = new System.Drawing.Size(171, 26);
            this.txtCustromerMobile.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtCustromerMobile, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(368, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تلفن";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(396, 58);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Parmida_ActivePlusMultiKeys = false;
            this.txtCustomerName.Properties.MaxLength = 150;
            this.txtCustomerName.Size = new System.Drawing.Size(299, 26);
            this.txtCustomerName.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtCustomerName, conditionValidationRule2);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(701, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "نام مشتری";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(191, 90);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Parmida_ActivePlusMultiKeys = false;
            this.txtDescription.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Properties.MaxLength = 250;
            this.txtDescription.Size = new System.Drawing.Size(504, 50);
            this.txtDescription.TabIndex = 1;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 495);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مشتریان";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustromerMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCustromerMobile;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnCloseButton;
        private DevExpress.XtraEditors.SimpleButton btnSaveButton;
        private DevExpress.XtraGrid.GridControl CustomersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvoiceList;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit SelectButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}
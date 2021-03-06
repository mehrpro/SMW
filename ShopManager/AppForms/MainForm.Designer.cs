﻿
namespace ShopManager.AppForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewGoodsButton = new DevExpress.XtraBars.BarButtonItem();
            this.UnitsListButton = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.SallersButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnStore = new DevExpress.XtraBars.BarButtonItem();
            this.btnSales = new DevExpress.XtraBars.BarButtonItem();
            this.btnDaySales = new DevExpress.XtraBars.BarButtonItem();
            this.btnReturnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.GoodsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NewGoodsButton,
            this.UnitsListButton,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.SallersButton,
            this.barButtonItem1,
            this.btnStore,
            this.btnSales,
            this.btnDaySales,
            this.btnReturnProduct,
            this.barButtonItem2,
            this.btnCustomers});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.GoodsRibbonPage,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(759, 174);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // NewGoodsButton
            // 
            this.NewGoodsButton.Caption = "مدیریت کالا";
            this.NewGoodsButton.Id = 1;
            this.NewGoodsButton.ImageOptions.SvgImage = global::ShopManager.Properties.Resources.bo_product;
            this.NewGoodsButton.Name = "NewGoodsButton";
            this.NewGoodsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewGoodsButton_ItemClick);
            // 
            // UnitsListButton
            // 
            this.UnitsListButton.Caption = "واحدهای شمارش کالا";
            this.UnitsListButton.Id = 4;
            this.UnitsListButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("UnitsListButton.ImageOptions.SvgImage")));
            this.UnitsListButton.Name = "UnitsListButton";
            this.UnitsListButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UnitsListButton_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "کاربر :";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "admin";
            this.barStaticItem2.Id = 6;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem3.Caption = "امروز : 1399/09/15";
            this.barStaticItem3.Id = 7;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // SallersButton
            // 
            this.SallersButton.Caption = "تامین کنندگان";
            this.SallersButton.Id = 8;
            this.SallersButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SallersButton.ImageOptions.SvgImage")));
            this.SallersButton.Name = "SallersButton";
            this.SallersButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SallersButton_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ثبت فاکتور خرید";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnStore
            // 
            this.btnStore.Caption = "موجودی کالا";
            this.btnStore.Id = 10;
            this.btnStore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStore.ImageOptions.SvgImage")));
            this.btnStore.Name = "btnStore";
            // 
            // btnSales
            // 
            this.btnSales.Caption = "فاکتور فروش";
            this.btnSales.Id = 11;
            this.btnSales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSales.ImageOptions.SvgImage")));
            this.btnSales.Name = "btnSales";
            this.btnSales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSales_ItemClick);
            // 
            // btnDaySales
            // 
            this.btnDaySales.Caption = "دفتر فروش روزانه";
            this.btnDaySales.Id = 12;
            this.btnDaySales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDaySales.ImageOptions.SvgImage")));
            this.btnDaySales.Name = "btnDaySales";
            // 
            // btnReturnProduct
            // 
            this.btnReturnProduct.Caption = "برگشت کالا";
            this.btnReturnProduct.Id = 13;
            this.btnReturnProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReturnProduct.ImageOptions.SvgImage")));
            this.btnReturnProduct.Name = "btnReturnProduct";
            this.btnReturnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReturnProduct_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "فاکتور مشتری";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Caption = "مشتریان";
            this.btnCustomers.Id = 15;
            this.btnCustomers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCustomers.ImageOptions.SvgImage")));
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomers_ItemClick);
            // 
            // GoodsRibbonPage
            // 
            this.GoodsRibbonPage.Appearance.Options.UseTextOptions = true;
            this.GoodsRibbonPage.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.GoodsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.GoodsRibbonPage.Name = "GoodsRibbonPage";
            this.GoodsRibbonPage.Text = "کالا";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.NewGoodsButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.UnitsListButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStore);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "مدیریت کالا";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.SallersButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "تامین کنندگان";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "فروش";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSales);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDaySales);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReturnProduct);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCustomers);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "فروش کالا";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem3);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 486);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(759, 35);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 521);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "مدیریت فروشگاه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage GoodsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem NewGoodsButton;
        private DevExpress.XtraBars.BarButtonItem UnitsListButton;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarButtonItem SallersButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnStore;
        private DevExpress.XtraBars.BarButtonItem btnSales;
        private DevExpress.XtraBars.BarButtonItem btnDaySales;
        private DevExpress.XtraBars.BarButtonItem btnReturnProduct;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnCustomers;
    }
}
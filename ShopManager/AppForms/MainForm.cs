using System.Windows.Forms;
using Container = StructureMap.Container;

namespace ShopManager.AppForms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Container _container;

        public MainForm()
        {
            InitializeComponent();
        }

        private void NewGoodsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren) c.Close();
            var frm = _container.GetInstance<NewGoodsForm>();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void UnitsListButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<UnitsForm>();
            frm.ShowDialog();
        }

        private void SallersButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren) c.Close();
            var frm = _container.GetInstance<SallerForm>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren) c.Close();
            var frm = _container.GetInstance<PurchaseInvoiceForm>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren) c.Close();
            var frm = _container.GetInstance<SalesForm>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren) c.Close();
            var frm = _container.GetInstance<CustomersForm>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnReturnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var c in this.MdiChildren) c.Close();
            var frm = _container.GetInstance<ReturnOfGoodsForm>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}

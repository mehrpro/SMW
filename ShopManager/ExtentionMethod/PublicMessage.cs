
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ShopManager
{
   public static class PublicMessage
    {
        public static void SuccessesSaveMessage(string formName)
        {
            XtraMessageBox.Show(@"عملیات ثبت با موفقیت انجام شد", formName, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public static void ErrorSaveMessage(string formName)
        {
            XtraMessageBox.Show(@"عملیات ثبت با خطا مواجه شد", formName, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        public static void ComplateFormMessage(string formName)
        {
            XtraMessageBox.Show(@"مقادیر الزامی فرم وارد نشده است", formName, MessageBoxButtons.OK,
                MessageBoxIcon.Hand);
        }
        public static void WellComeMessage(string userName)
        {
            XtraMessageBox.Show($@"کلیه فرآینده ها با نام کاربری {userName} ثبت می گردد", @"مدیریت سیستم", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void ErrorLoginMessage()
        {
            XtraMessageBox.Show(@"نام کاربری و رمز عبور اشتباه است پس از بررسی مجدداً تلاش کنید", @"مدیریت سیستم", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}

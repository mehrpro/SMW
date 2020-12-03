using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.ViewModels.Goods
{
    public class ProductViewModel
    {
        [Display(Name = "شناسه")]
        public int ProductId { get; set; }
        [Display(Name = "نام کالا")]
        public string ProductName { get; set; }
        [Display(Name = "بارکد کالا")]
        public string ProductNumber { get; set; }
        [Display(Name = "شناسه واحد")]
        public int UnitId_FK { get; set; }
        [Display(Name = " واحد")]
        public string Unit { get; set; }
        [Display(Name = "وضعیت")]
        public bool Enabled { get; set; }
        [Display(Name = "تاریخ ثبت")]
        public DateTime DateRegister { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "شناسه کاربر")]
        public int AppUser_FK { get; set; }
        [Display(Name = " کاربر")]
        public int UserName{ get; set; }
    }
}

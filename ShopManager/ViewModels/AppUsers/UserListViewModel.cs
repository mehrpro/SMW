using System.ComponentModel.DataAnnotations;

namespace ShopManager.ViewModels.AppUsers
{
    public class UserListViewModel
    {
        [Display(Name = "شناسه")]
        public int UserId { get; set; }
        [Display(Name = "نام کاربر")]
        public string UserName { get; set; }
    }
}
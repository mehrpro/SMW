using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using ShopManager.Models;
using ShopManager.ViewModels.AppUsers;

namespace ShopManager.Repositories
{
    public interface IAppUsersManager
    {
        /// <summary>
        /// لیست نام کاربران
        /// </summary>
        /// <returns></returns>
        Task<List<UserListViewModel>> GetUsersList();
        /// <summary>
        /// مجوز ورود به نرم افزار
        /// </summary>
        /// <param name="appUser">کاربر</param>
        /// <returns></returns>
        Task<AppUser> AcceptLogin(AppUser appUser);
        /// <summary>
        /// افزودن تامین کننده
        /// </summary>
        /// <param name="saller">تامین کننده</param>
        /// <returns></returns>
        Task<bool> AddNewSaller(Account saller);
        /// <summary>
        /// لیست تامین کنندگان
        /// </summary>
        /// <returns></returns>
        Task<List<Account>> GetSallerList();

        /// <summary>
        /// افزودن مشتری جدید
        /// </summary>
        /// <param name="customer">مشتری</param>
        /// <returns></returns>
        Task<bool> AddNewCustomers(Account customer);
        /// <summary>
        /// لیست مشتریان
        /// </summary>
        /// <returns></returns>
        Task<List<Account>> GetAllCustomer();
    }

    public class AppUsersManager : IAppUsersManager
    {
        private AppDbContext _context;
        public AppUsersManager(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserListViewModel>> GetUsersList()
        {
            var li = new List<UserListViewModel>();
            var qry = await _context.AppUsers.AsNoTracking().ToListAsync();
            foreach (var appUser in qry)
            {
                var item = new UserListViewModel
                {
                    UserId = appUser.UserId,
                    UserName = appUser.UserName
                };
                li.Add(item);
            }
            return li.ToList();
        }

        public async Task<AppUser> AcceptLogin(AppUser appUser)
        {
            var user = await _context.AppUsers.SingleOrDefaultAsync(x =>
                x.UserPassword == appUser.UserPassword && x.UserName == appUser.UserName);
            return user != null ? user : null;
        }

        public async Task<bool> AddNewSaller(Account saller)
        {
            try
            {
                if (saller.AccountID > 0)
                {
                    var item = await _context.Accounts.FindAsync(saller.AccountID);
                    item.Address = saller.Address;
                    item.Company = saller.Company;
                    item.Mobile = saller.Mobile;
                    item.FaxNumber = saller.FaxNumber;
                    item.PhoneNumber = saller.PhoneNumber;
                    item.FullName = saller.FullName;
                }
                else
                {
                    saller.AppUserID_FK = PublicValues.UserID;
                    saller.Registered =DateTime.Now;
                    saller.Enabled = true;
                    saller.GLEID_FK = 1;
                    _context.Accounts.Add(saller);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Account>> GetSallerList()
        {
            return await _context.Accounts.Where(x=>x.GLEID_FK==1).AsNoTracking().ToListAsync();
        }

        public async Task<bool> AddNewCustomers(Account customer)
        {
            try
            {
                if (customer.AccountID > 0)
                {
                    var item = await _context.Accounts.FindAsync(customer.AccountID);
                    item.FullName = customer.FullName;
                    item.Mobile = customer.Mobile;
                    item.Address = customer.Address;
                }
                else
                {
                    customer.Registered = DateTime.Now;
                    customer.Enabled = true;
                    customer.AppUserID_FK = PublicValues.UserID;
                    customer.GLEID_FK = 2;
                    _context.Accounts.Add(customer);
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<List<Account>> GetAllCustomer()
        {
            return await _context.Accounts.Where(x=>x.GLEID_FK==2).AsNoTracking().ToListAsync();
        }
    }
}
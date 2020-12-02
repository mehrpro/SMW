using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    }

    public class AppUsersManager : IAppUsersManager
    {
        private DBModel _db;
       

        public AppUsersManager(DBModel db)
        {
            _db = db;
            
        }

        public async Task<List<UserListViewModel>> GetUsersList()
        {
            var qry = await _db.AppUsers.AsNoTracking().ToListAsync();
            var li = new List<UserListViewModel>();
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
    }
}
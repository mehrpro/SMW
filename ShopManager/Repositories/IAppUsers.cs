﻿using System;
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
        Task<bool> AddNewSaller(Saller saller);
        /// <summary>
        /// لیست تامین کنندگان
        /// </summary>
        /// <returns></returns>
        Task<List<Saller>> GetSallerList();

        /// <summary>
        /// افزودن مشتری جدید
        /// </summary>
        /// <param name="customer">مشتری</param>
        /// <returns></returns>
        Task<bool> AddNewCustomers(Customer customer);
        /// <summary>
        /// لیست مشتریان
        /// </summary>
        /// <returns></returns>
        Task<List<Customer>> GetAllCustomer();
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

        public async Task<bool> AddNewSaller(Saller saller)
        {
            try
            {
                if (saller.SallerId > 0)
                {
                    var item = await _context.Sallers.FindAsync(saller.SallerId);
                    item.SallerAddress = saller.SallerAddress;
                    item.SallerCompany = saller.SallerCompany;
                    item.SallerMobile = saller.SallerMobile;
                    item.SallerFaxNumber = saller.SallerFaxNumber;
                    item.SallerPhoneNumber = saller.SallerPhoneNumber;
                    item.SallerName = saller.SallerName;
                }
                else
                {
                    saller.AppUser_FK = PublicValues.UserID;
                    _context.Sallers.Add(saller);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Saller>> GetSallerList()
        {
            return await _context.Sallers.AsNoTracking().ToListAsync();
        }

        public async Task<bool> AddNewCustomers(Customer customer)
        {
            try
            {
                if (customer.CustomerId > 0)
                {
                    var item = await _context.Customers.FindAsync(customer.CustomerId);
                    item.CustomerName = customer.CustomerName;
                    item.CustomerMobile = customer.CustomerMobile;
                    item.CustomerAddress = customer.CustomerAddress;
                }
                else
                {
                    customer.DateRegister = DateTime.Now;
                    customer.Enabled = true;
                    customer.AppUser_FK = PublicValues.UserID;
                    _context.Customers.Add(customer);
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _context.Customers.AsNoTracking().ToListAsync();
        }
    }
}
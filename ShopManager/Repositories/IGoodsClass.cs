using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManager.Models;
using ShopManager.ViewModels.Goods;

namespace ShopManager.Repositories
{
    public interface IGoodsClass
    {
        /// <summary>
        /// افزودن کالا جدید 
        /// </summary>
        /// <param name="productViewModel">کالا جدید</param>
        /// <returns></returns>
        Task<ProductList> AddNewProduct(ProductList productViewModel);
        /// <summary>
        /// لیست کالاهای ثبت شده
        /// </summary>
        /// <returns></returns>
        Task<List<ProductList>> GetProductList();
        /// <summary>
        /// لیست واحدهای شمارشی ثبت شده
        /// </summary>
        /// <returns></returns>
        Task<List<Unit>> GetUnitList();
        /// <summary>
        /// افزودن واحد شمارشی جدید
        /// </summary>
        /// <param name="unit">واحد جدید</param>
        /// <returns></returns>
        Task<bool> AddNewUnit(Unit unit);

    }

    public class GoodsClass : IGoodsClass
    {
        private DBModel _context;

        public GoodsClass(DBModel context)
        {
            _context = context;
        }

        public async Task<ProductList> AddNewProduct(ProductList product)
        {
            try
            {

                if (product.ProductId > 0)
                {
                    var item = await _context.ProductLists.FindAsync(product.ProductId);
                    item.ProductName = product.ProductName;
                    item.ProductNumber = product.ProductNumber;
                    item.Description = product.Description;
                    item.UnitId_FK = product.UnitId_FK;
                    //Logger Insert
                }
                else
                {
                    product.Enabled = true;
                    product.DateRegister = DateTime.Now;
                    product.AppUser_FK = PublicValues.UserID;
                    _context.ProductLists.Add(product);
                    //Logger Insert
                }
                await _context.SaveChangesAsync();
         
                return product;

            }
            catch (Exception e)
            {
                //Logger Insert
                return null;
            }

        }

        public async Task<List<ProductList>> GetProductList()
        {
            return await _context.ProductLists.Include(x => x.Unit).ToListAsync();
        }

        public async Task<List<Unit>> GetUnitList()
        {
            return await _context.Units.AsNoTracking().ToListAsync();
        }

        public async Task<bool> AddNewUnit(Unit unit)
        {
            try
            {
                if (unit.UnitId > 0)
                {
                    var item = await _context.Units.FindAsync(unit.UnitId);
                    item.UnitName = unit.UnitName;
                    item.Enabled = unit.Enabled;
                }
                else
                {
                    unit.DateRegister = DateTime.Now;
                    _context.Units.Add(unit);
                }
                //_context.Units.Add(unit);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
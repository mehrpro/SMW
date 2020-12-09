using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        /// <summary>
        /// افزودن فاکتور خرید جدید 
        /// </summary>
        /// <param name="tempLists"></param>
        /// <returns></returns>
        Task<bool> AddPurchaseInvoice(List<InvoiceTempList> tempLists);
        /// <summary>
        /// لیست کالاهای موجود برای فروش
        /// </summary>
        /// <returns></returns>
        Task<List<StoreProductList>> GetStoreProduct();
        /// <summary>
        /// ثبت سفارش و کسر از انبار
        /// </summary>
        /// <param name="viewModels">ریز سفارش</param>
        /// <returns></returns>
        Task<bool> AddOrders(List<StoreProductViewModel> viewModels);


        /// <summary>
        /// لیست فاکتور های مشتری
        /// </summary>
        /// <param name="customerId">شناسه مشتری</param>
        /// <returns></returns>
        Task<List<Order>> GetOrdersListByCustomerId(int customerId);

        /// <summary>
        /// ریز فاکتور بر اساس شناسه فاکتور
        /// </summary>
        /// <param name="orderId">شناسه فاکتور</param>
        /// <returns></returns>
        Task<List<StoreProductViewModel>> GetOrderDetaisByOrderId(int orderId);
        /// <summary>
        /// برگشت کالا به انبار و حذف از فاکتور
        /// </summary>
        /// <param name="viewModels"></param>
        /// <returns></returns>
        Task<bool> ReturnStoreProduct(List<StoreProductViewModel> viewModels);

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
            catch 
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
            catch 
            {
                return false;
            }
        }
       
        public async Task<bool> AddPurchaseInvoice(List<InvoiceTempList> tempLists)
        {
            var now = DateTime.Now;
            using (var trans = _context.Database.BeginTransaction())
            {
                try
                {
                    var newItem = new PurchaseInvoicy
                    {
                        InvoiceDate = tempLists[0].InvoiceDate,
                        InvoiceNumber = tempLists[0].InvoiceNumber,
                        InvoiceType_FK = tempLists[0].InvoiceType_FK,
                        Saller_FK = tempLists[0].Saller_FK,
                        DateRegister = now,
                        Enabled = true,
                        AppUser_FK = tempLists[0].AppUser_FK,
                    };
                    _context.PurchaseInvoicies.Add(newItem);
                    var result =  await _context.SaveChangesAsync();
                    if (result > 0)
                    {
                        foreach (var item in tempLists)
                        {
                            var newDetail = new PurchaseInvoiceDetail
                            {
                                PurchaseInvoiceId_FK = newItem.PurchaseInvoiceId,
                                ProductList_FK = item.ProductList_FK,
                                PurchasePrice = item.PurchasePrice,
                                Numbers = item.Numbers,
                                SumCurrency = item.SumCurrency,
                                Enabled = true,
                            };
                            _context.PurchaseInvoiceDetails.Add(newDetail);
                            var newStore = new StoreProductList
                            {
                                ProductList_FK = item.ProductList_FK,
                                PurchaseInvoice_FK = newItem.PurchaseInvoiceId,
                                Price = item.Frosh,
                                Percent = item.Percent,
                                Numbers = item.Numbers,
                            };
                            _context.StoreProductLists.Add(newStore);
                        }
                        await _context.SaveChangesAsync();
                        trans.Commit();
                        return true;
                    }
                    trans.Rollback();
                    return false;
                }
                catch 
                {
                    trans.Rollback();
                    return false;
                }
            }


        }

        public async Task<List<StoreProductList>> GetStoreProduct()
        {
            return await _context.StoreProductLists.Where(x=>x.Numbers > 0).Include(x=>x.ProductList).Include(x=>x.ProductList.Unit).Include(x=>x.PurchaseInvoicy).Include(x=>x.PurchaseInvoicy.Saller).ToListAsync();
        }

        public async Task<bool> AddOrders(List<StoreProductViewModel> viewModels)
        {
            var now = DateTime.Now;
            using (var trans = _context.Database.BeginTransaction())
            {
                try
                {
                    var newOrder = new Order
                    {
                        OrderId = 0,
                        Customers_FK = viewModels[0].Customers_FK,
                        OrderDate = viewModels[0].OrderDate,
                        InvoiceType_FK = viewModels[0].InvoiceType_FK,
                        Enabled = true,
                        OrderRegister = now,
                        AppUser_FK = PublicValues.UserID,
                        SumPrice = viewModels.Sum(x=>x.SumAfterPercent),
                    };
                    _context.Orders.Add(newOrder);
                    await _context.SaveChangesAsync();

                    foreach (var itemDetails in viewModels)
                    {
                        var newDetails = new OrderDetail
                        {
                            Orders_FK = newOrder.OrderId,
                            StoreId_FK = itemDetails.StoreId_FK,
                            Numbers = itemDetails.Numbers,
                            Price = itemDetails.Price,
                            Percent = itemDetails.Percent,
                            PercentPrice = itemDetails.PercentPrice,
                            SumPrice = itemDetails.SumPrice,
                            SumAfterPercent = itemDetails.SumAfterPercent,
                            InvoiceType_FK = itemDetails.InvoiceType_FK,
                        };
                        _context.OrderDetails.Add(newDetails);
                    }

                    foreach (var removeItem in viewModels)
                    {
                        var resultAsync =
                            await _context.StoreProductLists.SingleOrDefaultAsync(x =>
                                x.StoreId == removeItem.StoreId_FK);
                        if (resultAsync ==null || resultAsync.Numbers == 0)
                        {
                            trans.Rollback();
                            return false;
                        }
                        resultAsync.Numbers -= removeItem.Numbers;
                    }

                    await _context.SaveChangesAsync();
                    trans.Commit();
                    return true;
                }
                catch 
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

        public async Task<List<Order>> GetOrdersListByCustomerId(int customerId)
        {
            return await _context.Orders.Where(x => x.Customers_FK == customerId).Include(x => x.Customer)
                .ToListAsync();
        }




        public async Task<List<StoreProductViewModel>> GetOrderDetaisByOrderId(int orderId)
        {
            
            var qry = await _context.OrderDetails.Where(x => x.Orders_FK == orderId).Include(x => x.StoreProductList).Include(x=>x.StoreProductList.ProductList).Include(x=>x.StoreProductList.ProductList.Unit).ToListAsync();
            var resultListStoreModel = new List<StoreProductViewModel>();

            foreach (var order in qry)
            {
                var newOrder = new StoreProductViewModel();
                newOrder.Customers_FK = order.Order.Customers_FK;
                newOrder.OrderDate = order.Order.OrderDate;
                newOrder.InvoiceType_FK = order.InvoiceType_FK;
                newOrder.SumPrice = order.SumPrice;
                newOrder.StoreId = order.StoreId_FK;
                newOrder.ProductName = order.StoreProductList.ProductList.ProductName.ToString();
                newOrder.ProductList_FK = order.StoreProductList.ProductList_FK;
                newOrder.PurchaseInvoice_FK = 0;
                newOrder.Orders_FK = order.Orders_FK;
                newOrder.StoreId_FK = order.StoreId_FK;
                newOrder.Numbers = order.Numbers;
                newOrder.Price = order.Price;
                newOrder.UnitNam = order.StoreProductList.ProductList.Unit.UnitName;
                newOrder.Percent = order.Percent;
                newOrder.PercentPrice = order.PercentPrice;
                newOrder.SumAfterPercent = order.SumAfterPercent;
                resultListStoreModel.Add(newOrder);
            }


            return resultListStoreModel;
        }

        public async Task<bool> ReturnStoreProduct(List<StoreProductViewModel> viewModels)
        {
            foreach (var itemRemove in viewModels)
            {
                await _context.OrderDetails.FindAsync(itemRemove.StoreId_FK);
            }

            return true;
        }
    }
}
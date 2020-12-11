using ShopManager.Models;

namespace ShopManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopManager.Models.DBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopManager.Models.DBModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.AppUsers.AddOrUpdate(x => x.UserId,
                new AppUser
                {
                    UserId = 1,
                    UserName = "admin",
                    UserMobile = "9186620474",
                    UserPassword = "1",
                    DateRgister = DateTime.Now,
                    Enabled = true,
                },
                new AppUser
                {
                    UserId = 2,
                    UserName = "Manager",
                    UserMobile = "9186620474",
                    UserPassword = "2",
                    DateRgister = DateTime.Now,
                    Enabled = true,

                },
                new AppUser()
                {
                    UserId = 3,
                    UserName = "Saler",
                    UserMobile = "9186620474",
                    UserPassword = "1",
                    DateRgister = DateTime.Now,
                    Enabled = true,
                });

            context.InvoiceTypes.AddOrUpdate(x => x.InvoiceTypeId,
                new InvoiceType
                {
                    InvoiceTypeId = 1,
                    InvoiceName = "خرید",

                },
                new InvoiceType()
                {
                    InvoiceTypeId = 2,
                    InvoiceName = "فروش",
                },
                new InvoiceType()
                {
                    InvoiceTypeId = 3,
                    InvoiceName = "مرجوعی",
                });
            context.Units.AddOrUpdate(x=>x.UnitId,
                new Unit()
                {
                    UnitId = 1,
                    UnitName = "عدد",
                    Enabled = true,
                    DateRegister = DateTime.Now,
                },
                new Unit
                {
                    UnitId = 2,
                    UnitName = "بسته",
                    Enabled = true,
                    DateRegister = DateTime.Now,
                },
                new Unit
                {
                    UnitId = 3,
                    UnitName = "کارتن",
                    Enabled = true,
                    DateRegister = DateTime.Now,
                });

        }
    }
}

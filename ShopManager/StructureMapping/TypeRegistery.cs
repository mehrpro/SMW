using ShopManager.Models;
using ShopManager.Repositories;
using StructureMap;
namespace ShopManager.StructureMapping
{
    public class TypeRegistery : Registry
    {
        public TypeRegistery()
        {

            For<IAppUsersManager>().Use<AppUsersManager>();
            For<IGoodsClass>().Use<GoodsClass>();//.Ctor<DBModel>("context").Is(new DBModel());

            //Entity Framework Context
            For<AppDbContext>().Use(context => CreateNewContext(context));
        }

        private AppDbContext CreateNewContext(IContext context)
        {
            var myContext = new AppDbContext();
            myContext.Configuration.ProxyCreationEnabled = false;
            return myContext;
        }
    }
}
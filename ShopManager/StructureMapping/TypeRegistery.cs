
using AutoMapper;
using AutoMapper.Configuration;
using DevExpress.Data;
using ShopManager.AutoMap;
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
            
       

            //Entity Framework Context
            For<DBModel>().Use(context => CreateNewContext(context));
        }

        private DBModel CreateNewContext(IContext context)
        {
            var myContext = new DBModel();
            myContext.Configuration.ProxyCreationEnabled = false;
            return myContext;
        }
    }
}
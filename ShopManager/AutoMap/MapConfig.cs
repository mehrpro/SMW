using AutoMapper;
using ShopManager.Models;
using ShopManager.ViewModels.AppUsers;

namespace ShopManager.AutoMap
{
    public class MapConfig
    {
        public MapConfig()
        {
            
        }

        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg => cfg.CreateMap<AppUser, AppUserViewModel>());
        }
    }
}
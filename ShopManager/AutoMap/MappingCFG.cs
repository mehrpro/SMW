using AutoMapper;
using ShopManager.Models;
using ShopManager.ViewModels.AppUsers;

namespace ShopManager.AutoMap
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppUser, AppUserViewModel>().ReverseMap();
        }

        
    }
}
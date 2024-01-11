using Agency.BUSINESS.ViewModels;
using Agency.CORE.Entities;
using AutoMapper;

namespace Agency.MVC
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<CreatePortfolioVM, Portfolio>().ReverseMap();
            CreateMap<UpdatePortfolioVM, Portfolio>().ReverseMap();
        }
    }
}

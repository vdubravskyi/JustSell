using AutoMapper;
using JustSell.Bussiness.Common.DTOs;
using JustSell.Data.Entities.Car;

namespace JustSell.Bussiness.Common
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Car, CarDto>()
                .ForMember(x => x.Name, options => 
                    options.MapFrom(x => $"{x.Brand} {x.Model}"))
                .ForMember(x => x.Description, options => 
                    options.MapFrom(x => $"Color: {x.Color} Engine: {x.Engine.Name} {x.Engine.Capacity} {x.Engine.HorsePower} hp"));
        }
    }
}

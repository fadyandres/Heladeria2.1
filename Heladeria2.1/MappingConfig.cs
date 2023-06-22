using AutoMapper;
using HeladeriaAPI.Models;
using HeladeriaAPI.Models.Dto;
using System.Runtime.InteropServices;

namespace Heladeria2._1
{
    public class MappingConfig : Profile
    {
     public MappingConfig()
        {
            CreateMap<Helado, HeladoDto>();
            CreateMap<HeladoDto, Helado>();

            CreateMap<Helado, HeladoCrearDto>().ReverseMap();
            CreateMap<Helado, HeladoUpdateDto>().ReverseMap();


            CreateMap<Toppings,ToppingsDto>();
            CreateMap<ToppingsDto,Toppings>();

            CreateMap<Toppings, ToppingsCrearDto>().ReverseMap();
            CreateMap<Toppings, ToppingsUpdateDto>().ReverseMap();


            CreateMap<Ventas, VentasDto>();
            CreateMap<VentasDto, Ventas>();

            CreateMap<Ventas, VentasCrearDto>().ReverseMap();
            CreateMap<Ventas, VentasUpdateDto>().ReverseMap();
        }  
        
        
    }
}

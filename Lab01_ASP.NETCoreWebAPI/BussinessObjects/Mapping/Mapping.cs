using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BussinessObjects.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(p => p.CategoryName, act => act.MapFrom(src => src.Category.CategoryName))
                .ReverseMap();
        }
    }
}

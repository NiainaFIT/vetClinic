using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vetClinic.Model.Requests;

namespace vetClinic.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<Database.ServiceMeasure, Model.ServiceMeasure>();

            //Product
            CreateMap<Database.Product, Model.Product>();
            CreateMap<ProductInsertRequest, Database.Product>().ReverseMap();
            CreateMap<ProductUpdateRequest, Database.Product>().ReverseMap();
        }
    }
}

using AutoMapper;
using Sparcpoint.Models;
using Sparcpoint.Models.DomainDto.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparcpoint.Mappers.DomainToEntity
{
    public static class ProductEntityMapper
    {
        private static IMapper _mapper = ConfigMapper();
        public static IMapper ConfigMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductAttribute, ProductAttributeDto>()
                .ForMember(dest => dest.Key, m => m.MapFrom(src => src.Key))
                .ForMember(dest => dest.Value, m => m.MapFrom(src => src.Value))
                .ReverseMap();

                cfg.CreateMap<ProductCategories, ProductCategoryDto>()
                .ForMember(dest => dest.CategoryInstanceId, m => m.MapFrom(src => src.CategoryInstanceId))
                .ReverseMap();

                cfg.CreateMap<Products, ProductDto>().ReverseMap();

            });
            return _mapper = config.CreateMapper();
        }
        public static Products MapDomainToEntity(ProductDto productDto)
        {
           return _mapper.Map<Products>(productDto);
        }
    }
}

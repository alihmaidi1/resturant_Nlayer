using AutoMapper;
using RestaurantOrderProject.DtoLayer.ProductDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping() { 
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategory>().ReverseMap();
        }
    }
}

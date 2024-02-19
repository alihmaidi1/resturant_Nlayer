using AutoMapper;
using RestaurantOrderProject.DtoLayer.DiscountDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        }
    }
}

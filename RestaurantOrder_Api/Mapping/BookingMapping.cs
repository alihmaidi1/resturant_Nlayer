using AutoMapper;
using RestaurantOrderProject.DtoLayer.BookingDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Mapping
{
    public class BookingMapping: Profile
    {
        public BookingMapping() { 
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, GetByIdBookingDto>().ReverseMap();
            CreateMap<Booking,  UpdateBookingDto>().ReverseMap();
        }
    }
}

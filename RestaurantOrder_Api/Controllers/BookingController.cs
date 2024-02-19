using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.BookingDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetAllList();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Name = createBookingDto.Name,
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone,

            };
            _bookingService.TAdd(booking);
            return Ok("Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingID = updateBookingDto.BookingID,
                Name = updateBookingDto.Name,
                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,

            };
            _bookingService.TUpdate(booking);
            return Ok("Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
    }
}

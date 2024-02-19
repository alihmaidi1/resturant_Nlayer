using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.DiscountDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;
        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetAllList());
            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            Discount Discount = new Discount()
            {
               Amount = createDiscountDto.Amount,
               Description = createDiscountDto.Description,
               ImageUrl = createDiscountDto.ImageUrl,
               Title = createDiscountDto.Title

            };
            _discountService.TAdd(Discount);
            return Ok("eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            Discount Discount = new Discount()
            {
                DiscountID = updateDiscountDto.DiscountID,
                Amount= updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                Title = updateDiscountDto.Title,
                ImageUrl = updateDiscountDto.ImageUrl

            };
            _discountService.TUpdate(Discount);
            return Ok("güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }
    }
}

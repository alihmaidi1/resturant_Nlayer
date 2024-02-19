using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantOrder_Api.Models;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;
using RestaurantOrderProject.DtoLayer.BasketsDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet("{id}")]
        public IActionResult GetBasketByTableId(int id)
        {
            var values = _basketService.TGetBasketByTableNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListWithProductName")]

        public IActionResult BasketListWithProductName(int id)
        {
            using var context = new RestaurantOrderContext();
            var values = context.Baskets.Include(x => x.Product).Where(y => y.TableID == id).Select(z => new ResultBasketListWithProduct
            {
                BasketID = z.BasketID,
                Count = z.Count,
                TableID = z.TableID,
                Price = z.Price,
                TotalPrice = z.TotalPrice,
                ProductID = z.ProductID,
                ProductName = z.Product.ProductName

            }).ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new RestaurantOrderContext();
            _basketService.TAdd(new Basket()
            {
                ProductID = createBasketDto.ProductID,
                Count = 1,
                TableID = 4,
                Price = context.Product.Where(x=>x.ProductID == createBasketDto.ProductID).Select(y=> y.Price).FirstOrDefault(),
                TotalPrice =  0
            });
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetById(id);
            _basketService.TDelete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }


    }
}

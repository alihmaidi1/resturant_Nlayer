using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;
using RestaurantOrderProject.DtoLayer.ProductDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetAllList());
            return Ok(value);
        }

		[HttpGet("ProductCount")]
		public IActionResult ProductCount()
		{
			var count = _productService.TGetProductCount();
			return Ok(count);
		}

		[HttpGet("TProductPriceAvg")]
		public IActionResult ProductPriceAvg()
		{
			var count = _productService.TProductPriceAvg();
			return Ok(count);
		}
       
		[HttpGet("ProductCountByCategoryNameDrink")]
		public IActionResult ProductCountByCategoryNameDrink()
		{
			var count = _productService.TProductCountByCategoryNameDrink();
			return Ok(count);
		}
		[HttpGet("ProductCountByCategoryNameHamburger")]
		public IActionResult ProductCountByCategoryNameHamburger()
		{
			var count = _productService.TProductCountByCategoryNameHamburger();
			return Ok(count);
		}

		[HttpGet("ProductNameByMinPrice")]
		public IActionResult ProductNameByMinPrice()
		{
			var product = _productService.TProductNameByMinPrice();
			return Ok(product);
		}

		[HttpGet("ProductNameByMaxPrice")]
		public IActionResult ProductNameByMaxPrice()
		{
			var product = _productService.TProductNameByMaxPrice();
			return Ok(product);
		}

		[HttpGet("ProductPricebyHamburgerAvg")]
		public IActionResult ProductPricebyHamburgerAvg()
		{
			var product = _productService.TProductPricebyHamburgerAvg();
			return Ok(product);
		}

		[HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new RestaurantOrderContext();
            var values = context.Product.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                Status = y.Status,
                CategoryName = y.Category.CategoryName
                
            });
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            Product Product = new Product()
            {
                ProductName = createProductDto.ProductName,
                Status = true,
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                CategoryID = createProductDto.CategoryID

            };
            _productService.TAdd(Product);
            return Ok("eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            Product Product = new Product()
            {
                ProductID = updateProductDto.ProductID,
                ProductName = updateProductDto.ProductName,
                Status = updateProductDto.Status,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                CategoryID = updateProductDto.CategoryID
            };
            _productService.TUpdate(Product);
            return Ok("güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.CategoryDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetAllList());
            return Ok(values);

        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            var count = _categoryService.TGetCategoryCount();
            return Ok(count);
        }

		[HttpGet("ActiveCategoryCount")]
		public IActionResult ActiveCategoryCount()
		{
			var count = _categoryService.TActiveCategoryCount();
			return Ok(count);
		}

		[HttpGet("PassiveCategoryCount")]
		public IActionResult PassiveCategoryCount()
		{
			var count = _categoryService.TPassiveCategoryCount();
			return Ok(count);
		}

		[HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {

            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = true,

            });
            return Ok("eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                CategoryID = updateCategoryDto.CategoryID,
                CategoryName = updateCategoryDto.CategoryName,
                Status = updateCategoryDto.Status,

            };
            _categoryService.TUpdate(category);
            return Ok("güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }

    }
}

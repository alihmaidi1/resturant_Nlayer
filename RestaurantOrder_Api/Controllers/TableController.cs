using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;

namespace RestaurantOrder_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TableController : ControllerBase
	{
		private readonly ITableService _tableService;

		public TableController(ITableService tableService)
		{
			_tableService = tableService;
		}

		[HttpGet("MenuTableCount")]
		public IActionResult MenuTableCount()
		{
			return Ok(_tableService.TMenuTableCount());
		}
	}
}

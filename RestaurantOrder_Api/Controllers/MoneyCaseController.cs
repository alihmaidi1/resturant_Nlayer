using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;

namespace RestaurantOrder_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoneyCaseController : ControllerBase
	{
		private readonly IMoneyCaseService _moneyCaseService;

		public MoneyCaseController(IMoneyCaseService moneyCaseService)
		{
			_moneyCaseService = moneyCaseService;
		}

		[HttpGet("TotalMoneyCaseAmount")]
		public IActionResult TotalMoneyCaseAmount() {

			return Ok(_moneyCaseService.TTotalMoneyCaseAmount());
		}
	}
}

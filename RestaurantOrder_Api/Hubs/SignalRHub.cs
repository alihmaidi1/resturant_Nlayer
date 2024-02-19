using Microsoft.AspNetCore.SignalR;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;

namespace RestaurantOrder_Api.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
		private readonly IOrderService _orderService;
		private readonly IMoneyCaseService _moneyCaseService;
		private readonly ITableService _tableService;
		private readonly IBookingService _bookingService;
		private readonly INotificationService _notificationService;

        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, ITableService tableService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _tableService = tableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }

        public async Task SendStatistics()
        {
            var value1 = _categoryService.TGetCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value1);

			var value2 = _productService.TGetProductCount();
			await Clients.All.SendAsync("ReceiveProductCount", value2);

			var value3 = _categoryService.TActiveCategoryCount();
			await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

			var value4 = _categoryService.TPassiveCategoryCount();
			await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

			var value5 = _productService.TProductCountByCategoryNameHamburger();
			await Clients.All.SendAsync("ReceiveProductCountByHamburger", value5);

			var value6 = _productService.TProductCountByCategoryNameDrink();
			await Clients.All.SendAsync("ReceiveProductCountByDrink", value6);

			var value7 = _productService.TProductPriceAvg();
			await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("0.00") + "₺");

			var value8 = _productService.TProductNameByMaxPrice();
			await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);

			var value9 = _productService.TProductNameByMinPrice();
			await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);

			var value10 = _productService.TProductPricebyHamburgerAvg();
			await Clients.All.SendAsync("ReceiveProductPricebyHamburgerAvg", value10);

			var value11 = _orderService.TTotalOrderCount();
			await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

			var value12 = _orderService.TActiveOrderCount();
			await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

			var value13 = _orderService.TLastOrderPrice();
			await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00") + "₺");

			var value14 = _moneyCaseService.TTotalMoneyCaseAmount();
			await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00") + "₺");

			var value16 = _tableService.TMenuTableCount();
			await Clients.All.SendAsync("ReceiveMenuTableCount", value16);

		}

		public async Task SendProgressStatistics()
		{
            var value1 = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value1.ToString("0.00" + "₺"));

            var value2 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);

            var value3 = _tableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", value3);
        }

        public async Task GetBookingList()
        {
            var values = _bookingService.TGetAllList();
            await Clients.All.SendAsync("ReceiveBookingList", values);
        }

		public async Task SendNotification()
		{
			var value = _notificationService.TNotificationCountByStatusFalse();
			await Clients.All.SendAsync("ReceiveNotificationCountByStatusFalse", value);
			var notificationListByFalse = _notificationService.TGetAllNotificationByStatusFalse();
			await Clients.All.SendAsync("ReceiveNotificationListByFalse", notificationListByFalse);
		}

    }
}

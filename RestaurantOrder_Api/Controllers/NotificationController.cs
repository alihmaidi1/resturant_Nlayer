using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.NotificationDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpGet]
        public IActionResult NotificationList() {
            var values = _notificationService.TGetAllList();
            return Ok(values);
        }

        [HttpGet("NotificationCountByStatusFalse")]

        public IActionResult NotificationCountByStatusFalse()
        {
            var count = _notificationService.TNotificationCountByStatusFalse();
            return Ok(count);
        }

        [HttpGet("GetAllNotificationByStatusFalse")]
        public IActionResult GetAllNotificationByStatusFalse()
        {
            var values = _notificationService.TGetAllNotificationByStatusFalse();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            Notification notification = new Notification()
            {
                Description = createNotificationDto.Description,
                Type = createNotificationDto.Type,
                Icon = createNotificationDto.Icon,
                Date = createNotificationDto.Date,
                Status = createNotificationDto.Status
            };
            _notificationService.TAdd(notification);
            return Ok("Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var value = _notificationService.TGetById(id);
            _notificationService.TDelete(value);
            return Ok("Silindi");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            Notification notification = new Notification()
            {
                NotificationID = updateNotificationDto.NotificationID,
                Description = updateNotificationDto.Description,
                Type = updateNotificationDto.Type,
                Icon = updateNotificationDto.Icon,
                Date = updateNotificationDto.Date,
                Status = updateNotificationDto.Status
            };
            _notificationService.TUpdate(notification);
            return Ok("Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.TGetById(id);
            return Ok(value);
        }
    }
}

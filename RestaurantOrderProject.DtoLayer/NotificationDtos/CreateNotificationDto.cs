using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DtoLayer.NotificationDtos
{
    public class CreateNotificationDto
    {
        public string Description { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}

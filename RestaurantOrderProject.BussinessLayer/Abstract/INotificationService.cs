using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.BussinessLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>

    {
        int TNotificationCountByStatusFalse();
        List<Notification> TGetAllNotificationByStatusFalse();
    }
}

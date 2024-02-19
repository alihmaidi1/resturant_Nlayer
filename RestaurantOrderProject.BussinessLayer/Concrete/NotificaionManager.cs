using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.BussinessLayer.Concrete
{
    public class NotificaionManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificaionManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification entity)
        {
            _notificationDal.Add(entity);
        }

        public void TDelete(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        public List<Notification> TGetAllList()
        {
            return _notificationDal.GetAllList();
        }

        public List<Notification> TGetAllNotificationByStatusFalse()
        {
            return _notificationDal.GetAllNotificationByStatusFalse();
        }

        public Notification TGetById(int id)
        {
            return _notificationDal.GetById(id);
        }

        public int TNotificationCountByStatusFalse()
        {
           return _notificationDal.NotificationCountByStatusFalse();
        }

        public void TUpdate(Notification entity)
        {
            _notificationDal.Update(entity);
        }
    }
}

using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;
using RestaurantOrderProject.DataAccessLayer.Repositories;
using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DataAccessLayer.EntityFramework
{
	public class EfOrderDetailDal : GenericRepository<OrderDetail>, IOrderDetailDal
	{
		public EfOrderDetailDal(RestaurantOrderContext context) : base(context)
		{
		}
	}
}

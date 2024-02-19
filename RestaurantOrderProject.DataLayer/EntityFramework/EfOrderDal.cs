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
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		private readonly RestaurantOrderContext _context;
		public EfOrderDal(RestaurantOrderContext context) : base(context)
		{
			_context = context;
		}

		public int ActiveOrderCount()
		{
			return _context.Orders.Where(x => x.Description == "Müşteri masada").Count();
		}

		public decimal LastOrderPrice()
		{
			return _context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y=> y.TotalPrice).FirstOrDefault();
		}

		public decimal TodayTotalPrice()
		{
			return _context.Orders.Where(x=> x.OrderDate == DateTime.Parse(DateTime.Now.ToShortDateString())).Sum(x => x.TotalPrice);
		}

		public int TotalOrderCount()
		{
			return _context.Orders.Count();
		}
	}
}

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
	public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
	{
		private readonly RestaurantOrderContext _context;
		public EfMoneyCaseDal(RestaurantOrderContext context) : base(context)
		{
			_context = context;
		}

		public decimal TotalMoneyCaseAmount()
		{
			return _context.MoneyCases.Select(x=> x.TotalAmount).FirstOrDefault();
		}
	}
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;
using RestaurantOrderProject.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DataAccessLayer.EntityFramework
{
	public class EfTableDal : GenericRepository<Table>, ITableDal
	{
		private readonly RestaurantOrderContext _context;
		public EfTableDal(RestaurantOrderContext context) : base(context)
		{
			_context = context;
		}

		public int MenuTableCount()
		{
			return _context.Tables.Count();
		}
	}
}

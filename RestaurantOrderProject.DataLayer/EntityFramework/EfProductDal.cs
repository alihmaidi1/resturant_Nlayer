using Microsoft.EntityFrameworkCore;
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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
		private readonly RestaurantOrderContext _context;
        public EfProductDal(RestaurantOrderContext context) : base(context)
        {
			_context = context;
        }

		public int GetProductCount()
		{
			
            return _context.Product.Count();
		}

		public List<Product> GetProductsWithCategories()
        {
            var values = _context.Product.Include(x => x.Category).ToList();
            return values;
        }

		public int ProductCountByCategoryNameDrink()
		{
			return _context.Product.Where(x=> x.CategoryID == (_context.Categories.Where(y=> y.CategoryName == "İçecek").Select(z=> z.CategoryID).FirstOrDefault())).Count();
		}

		public int ProductCountByCategoryNameHamburger()
		{
			return _context.Product.Where(x => x.CategoryID == (_context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();

		}

		public string ProductNameByMaxPrice()
		{
			return _context.Product.Where(x => x.Price == (_context.Product.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
		}

		public string ProductNameByMinPrice()
		{
			return _context.Product.Where(x => x.Price == (_context.Product.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();

		}

		public decimal ProductPriceAvg()
		{
			return _context.Product.Average(x => x.Price);
		}

		public decimal ProductPricebyHamburgerAvg()
		{
			var avg = _context.Product.Where(x => x.CategoryID == (_context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Average(w=> w.Price);
			return avg;
		}
	}
}

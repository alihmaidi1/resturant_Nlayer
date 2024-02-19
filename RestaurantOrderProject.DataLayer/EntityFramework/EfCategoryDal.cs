using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;
using RestaurantOrderProject.DataAccessLayer.Repositories;
using RestaurantOrderProject.EntityLayer.Entities;


namespace RestaurantOrderProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
		private readonly RestaurantOrderContext _context;
        public EfCategoryDal(RestaurantOrderContext context) : base(context)
        {
			_context = context;
        }

		public int ActiveCategoryCount()
		{
			int query = _context.Categories.Where(x => x.Status == true).Count();
			return query;
		}

		public int GetCategoryCount()
		{
			return _context.Categories.Count();
		}

		public int PassiveCategoryCount()
		{
			int query = _context.Categories.Where(x => x.Status == false).Count();
			return query;
		}
	}
}

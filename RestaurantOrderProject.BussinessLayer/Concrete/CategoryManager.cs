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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

		public int TActiveCategoryCount()
		{
            return _categoryDal.ActiveCategoryCount();
		}

		public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAllList()
        {
           return _categoryDal.GetAllList();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

		public int TGetCategoryCount()
		{
            return _categoryDal.GetCategoryCount();
		}

		public int TPassiveCategoryCount()
		{
			return _categoryDal.PassiveCategoryCount();
		}

		public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}

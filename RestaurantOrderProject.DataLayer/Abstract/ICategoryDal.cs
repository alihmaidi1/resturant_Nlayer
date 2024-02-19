using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        public int GetCategoryCount();
        public int ActiveCategoryCount();
        public int PassiveCategoryCount();

    }
}

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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
           _productDal.Delete(entity);
        }

        public List<Product> TGetAllList()
        {
            return _productDal.GetAllList();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

		public int TGetProductCount()
		{
            return _productDal.GetProductCount();
		}

		public List<Product> TGetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

		public int TProductCountByCategoryNameDrink()
		{
            return _productDal.ProductCountByCategoryNameDrink();
		}

		public int TProductCountByCategoryNameHamburger()
		{
            return _productDal.ProductCountByCategoryNameHamburger();
		}

		public string TProductNameByMaxPrice()
		{
            return _productDal.ProductNameByMaxPrice();
		}

		public string TProductNameByMinPrice()
		{
            return _productDal.ProductNameByMinPrice();
		}

		public decimal TProductPriceAvg()
		{
            return _productDal.ProductPriceAvg();
		}

		public decimal TProductPricebyHamburgerAvg()
		{
            return _productDal.ProductPricebyHamburgerAvg();
		}

		public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
           
        }
    }
}

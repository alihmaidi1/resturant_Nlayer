using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.BussinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
		int TGetProductCount();

		int TProductCountByCategoryNameHamburger();
		int TProductCountByCategoryNameDrink();
		decimal TProductPriceAvg();
		string TProductNameByMaxPrice();
		string TProductNameByMinPrice();
		decimal TProductPricebyHamburgerAvg();

	}
}

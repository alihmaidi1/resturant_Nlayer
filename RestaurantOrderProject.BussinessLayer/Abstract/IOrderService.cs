using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.BussinessLayer.Abstract
{
	public interface IOrderService: IGenericService<Order>
	{
		int TTotalOrderCount();
		int TActiveOrderCount();
		decimal TTodayTotalPrice();
		decimal TLastOrderPrice();
	}
}

using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrderProject.BussinessLayer.Concrete
{
	public class OrderDetailManager : IOrderDetailService
	{
		private readonly IOrderDetailDal _orderDetailDal;

		public OrderDetailManager(IOrderDetailDal orderDetailDal)
		{
			_orderDetailDal = orderDetailDal;
		}

		public void TAdd(OrderDetail entity)
		{
			_orderDetailDal.Add(entity);
		}

		public void TDelete(OrderDetail entity)
		{
			_orderDetailDal.Delete(entity);
		}

		public List<OrderDetail> TGetAllList()
		{
			return _orderDetailDal.GetAllList();
		}

		public OrderDetail TGetById(int id)
		{
			return _orderDetailDal.GetById(id);
		}

		public void TUpdate(OrderDetail entity)
		{
			_orderDetailDal.Update(entity);
		}
	}
}

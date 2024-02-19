using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrderProject.BussinessLayer.Concrete
{
	public class MoneyCaseManager : IMoneyCaseService
	{
		private readonly IMoneyCaseDal _moneyCaseDal;

		public MoneyCaseManager(IMoneyCaseDal moneyCaseDal)
		{
			_moneyCaseDal = moneyCaseDal;
		}

		public void TAdd(MoneyCase entity)
		{
			_moneyCaseDal.Add(entity);
		}

		public void TDelete(MoneyCase entity)
		{
			_moneyCaseDal.Delete(entity);
		}

		public List<MoneyCase> TGetAllList()
		{
			return _moneyCaseDal.GetAllList();
		}

		public MoneyCase TGetById(int id)
		{
			return _moneyCaseDal.GetById(id);
		}

		public decimal TTotalMoneyCaseAmount()
		{
			return _moneyCaseDal.TotalMoneyCaseAmount();
		}

		public void TUpdate(MoneyCase entity)
		{
			_moneyCaseDal.Update(entity);
		}
	}
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.BussinessLayer.Concrete
{
	public class TableManager : ITableService
	{
		private readonly ITableDal _tableDal;

		public TableManager(ITableDal tableDal)
		{
			_tableDal = tableDal;
		}

		public void TAdd(Table entity)
		{
			_tableDal.Add(entity);
		}

		public void TDelete(Table entity)
		{
			_tableDal.Delete(entity);
		}

		public List<Table> TGetAllList()
		{
			return _tableDal.GetAllList();
		}

		public Table TGetById(int id)
		{
			return _tableDal.GetById(id);
		}

		public int TMenuTableCount()
		{
			return _tableDal.MenuTableCount();
		}

		public void TUpdate(Table entity)
		{
			_tableDal.Update(entity);
		}
	}
}

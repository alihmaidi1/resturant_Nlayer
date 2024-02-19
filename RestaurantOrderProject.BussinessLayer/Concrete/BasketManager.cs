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
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket entity)
        {
            _basketDal.Add(entity);
        }

        public void TDelete(Basket entity)
        {
           _basketDal.Delete(entity);
        }

        public List<Basket> TGetAllList()
        {
           return _basketDal.GetAllList();
        }

        public List<Basket> TGetBasketByTableNumber(int id)
        {
           return _basketDal.GetBasketByTableNumber(id);
        }

        public Basket TGetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public void TUpdate(Basket entity)
        {
           _basketDal.Update(entity);
        }
    }
}

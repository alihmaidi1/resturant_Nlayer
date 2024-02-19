using Microsoft.EntityFrameworkCore;
using RestaurantOrderProject.DataAccessLayer.Abstract;
using RestaurantOrderProject.DataAccessLayer.Concrete;
using RestaurantOrderProject.DataAccessLayer.Repositories;
using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(RestaurantOrderContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByTableNumber(int id)
        {
            using var context = new RestaurantOrderContext();
            var values = context.Baskets.Where(x => x.TableID == id).Include(y=>y.Product).ToList();
            return values;
        }
    }
}

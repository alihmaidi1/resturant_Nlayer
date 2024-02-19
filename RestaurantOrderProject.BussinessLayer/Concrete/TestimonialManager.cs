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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonailDal;

        public TestimonialManager(ITestimonialDal testimonailDal)
        {
            _testimonailDal = testimonailDal;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonailDal.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonailDal.Delete(entity);
        }

        public List<Testimonial> TGetAllList()
        {
            return _testimonailDal.GetAllList();
        }

        public Testimonial TGetById(int id)
        {
            return _testimonailDal.GetById(id);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonailDal.Update(entity);
        }
    }
}

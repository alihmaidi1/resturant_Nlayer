using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DtoLayer.CategoryDtos
{
    public class GetByIdCategoryDto
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public bool Status { get; set; }
    }
}

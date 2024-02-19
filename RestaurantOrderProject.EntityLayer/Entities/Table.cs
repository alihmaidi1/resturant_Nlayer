using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.EntityLayer.Entities
{
	public class Table
	{
        public int TableID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}

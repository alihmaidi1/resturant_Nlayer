﻿using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DtoLayer.BasketsDtos
{
    public class UpdateBasketDto
    {
        public int BasketID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int TableID { get; set; }
        public Table Table { get; set; }
        public string ProductName { get; set; }
    }
}

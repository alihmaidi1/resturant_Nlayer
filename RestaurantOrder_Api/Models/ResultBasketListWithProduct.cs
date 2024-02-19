namespace RestaurantOrder_Api.Models
{
    public class ResultBasketListWithProduct
    {
        public int BasketID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int TableID { get; set; }
        public string ProductName { get; set; }
    }
}

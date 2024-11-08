namespace ASNFoodPickupProject.Models
{
    public class OrderHistory
    {
        public int OrderId { get; set; }
        public int TransactionId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FoodItem { get; set; }
        public string RestaurantName { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}

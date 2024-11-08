namespace ASNFoodPickupProject.Models
{
    public class TransactionHistory
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string FoodItem { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string RestaurantName { get; set; }
    }
}

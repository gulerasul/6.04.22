
namespace Json.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Status { get; set; } = "new";
        public decimal Total { get; set; }

        // Связь с клиентом
        public Client? Client { get; set; }
    }
}
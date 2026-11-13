using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        
        [Required]
        public string FullName { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;
    }
}
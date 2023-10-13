using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public required string Name { get; set; }

        public string? Description { get; set; }

        [StringLength(50)]
        public string? Category { get; set; }

        public decimal Price { get; set; }
    }
}

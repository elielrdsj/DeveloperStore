using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeveloperStoreAPI.Models
{
    public class Sale
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string SaleNumber { get; set; } = string.Empty;

        [Required]
        public DateTime SaleDate { get; set; } = DateTime.UtcNow;

        [Required]
        public string CustomerId { get; set; } = string.Empty; // External Identity

        [Required]
        public string BranchId { get; set; } = string.Empty; // External Identity

        [Required]
        public List<SaleItem> Items { get; set; } = new();

        public bool IsCancelled { get; set; } = false;

        [NotMapped]
        public decimal TotalAmount => Items.Sum(item => item.TotalPrice);
    }
}

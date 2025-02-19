using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DeveloperStore.BusinessEntity
{
    public class SaleItem
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string ProductId { get; set; } = string.Empty; // External Identity

        [Required]
        [Range(1, 20, ErrorMessage = "Quantity must be between 1 and 20.")]
        public int Quantity { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Unit price must be greater than 0.")]
        public decimal UnitPrice { get; set; }

        public decimal Discount => CalculateDiscount();

        [NotMapped]
        public decimal TotalPrice => (UnitPrice * Quantity) - Discount;

        private decimal CalculateDiscount()
        {
            if (Quantity < 4) return 0;
            if (Quantity >= 4 && Quantity < 10) return (UnitPrice * Quantity) * 0.10m;
            if (Quantity >= 10 && Quantity <= 20) return (UnitPrice * Quantity) * 0.20m;
            return 0;
        }
    }
}

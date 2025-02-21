using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace DeveloperStore.BusinessEntity
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}

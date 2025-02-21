using System.ComponentModel.DataAnnotations;

namespace DeveloperStore.BusinessEntity
{
    public class StoreBranch
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
    }
}

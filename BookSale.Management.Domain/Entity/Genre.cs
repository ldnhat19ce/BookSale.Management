using System.ComponentModel.DataAnnotations;

namespace BookSale.Management.Domain.Entity
{
    public class Genre : BaseEntity
    {
        [Required]
        [StringLength(500)]
        private string name { get; set; }

        [StringLength(1000)]
        private string? description { get; set; }

        [Required]
        private bool isActive { get; set; }
    }
}

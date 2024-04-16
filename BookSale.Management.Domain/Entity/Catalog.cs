using System.ComponentModel.DataAnnotations;

namespace BookSale.Management.Domain.Entity
{
    public class Catalog : BaseEntity
    {
        [Required]
        [StringLength(500)]
        private string title { get; set; }

        [StringLength(1000)]
        private string description { get; set; }

        [Required]
        private bool isActive {  get; set; }
    }
}

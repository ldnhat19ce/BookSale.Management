using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Management.Domain.Entity
{
    public class Cart : BaseEntity
    {
        [StringLength(1500)]
        private string? note {  get; set; }

        private DateTime? createdOn { get; set; }

        [Required]
        private int userId { get; set; }

        [ForeignKey(nameof(userId))]
        private User user { get; set; }

        [Required]
        private bool isActive { get; set; }

        [Required]
        private int status {  get; set; }

        [StringLength(500)]
        private string code { get; set; }
    }
}

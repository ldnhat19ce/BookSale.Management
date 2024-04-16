using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Management.Domain.Entity
{
    public class Address : BaseEntity
    {
        [StringLength(15)]
        private string? phone {  get; set; }

        [StringLength(500)]
        private string? address {  get; set; }

        [StringLength(250)]
        private string? fullName {  get; set; }

        [StringLength (150)]
        private string? email { get; set; }

        [Required]
        private bool isActive { get; set; }

        [Required]
        private int userId { get; set; }

        [ForeignKey(nameof(userId))]
        private User user { get; set; }
    }
}

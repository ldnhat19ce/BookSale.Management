using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Management.Domain.Entity
{
    public class Book : BaseEntity
    {
        [Required]
        [StringLength(500)]
        private string title { get; set; }

        [Required]
        [StringLength(500)]
        private string author { get; set; }

        [StringLength(500)]
        private string? publisher {  get; set; }

        [Required]
        private int available {  get; set; }

        [Required]
        private decimal price { get; set; }

        [Required]
        private bool isActive {  get; set; }

        private DateTime createdOn { get; set; }

        [Required]
        private int genreId { get; set; }

        [ForeignKey(nameof(genreId))]
        private Genre genre { get; set; }
    }
}

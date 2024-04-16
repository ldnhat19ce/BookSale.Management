using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Management.Domain.Entity
{
    public class CartDetail : BaseEntity
    {
        [Required]
        private int cartId {  get; set; }

        [ForeignKey(nameof(cartId))]
        private Cart cart { get; set; }

        [Required]
        private int bookId { get; set; }

        [ForeignKey(nameof(bookId))]
        private Book book { get; set; }

        [Required]
        private decimal price { get; set; }

        [Required]
        private int quantity { get; set; }

        [StringLength(1500)]
        private string? node {  get; set; }
    }
}

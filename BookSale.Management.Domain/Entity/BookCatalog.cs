using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Management.Domain.Entity
{
    public class BookCatalog : BaseEntity
    {
        [Required]
        private int bookId {  get; set; }

        [ForeignKey(nameof(bookId))]
        private Book book { get; set; }

        [Required]
        private int catalogId { get; set; }

        [ForeignKey(nameof(catalogId))]
        private Catalog catalog { get; set; }
    }
}

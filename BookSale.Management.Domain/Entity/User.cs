using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookSale.Management.Domain.Entity
{
    public class User : IdentityUser
    {
        [Required]
        private bool isActive {  get; set; }
    }
}

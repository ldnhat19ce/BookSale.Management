using BookSale.Management.Domain.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Management.DataAccess.DataAccess
{
    public class BookStoreDBContext : IdentityDbContext<User, IdentityRole, string>
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options) { 
        }
    }
}

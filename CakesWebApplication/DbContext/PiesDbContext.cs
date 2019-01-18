using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CakesWebApplication.DbContexts
{
    public class PiesDbContext : IdentityDbContext<IdentityUser>
    {
        public PiesDbContext(DbContextOptions<PiesDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        //create entites for table
        public DbSet<PieDto> Pies { get; set; }
        public DbSet<CategoryDto> Categories { get; set; }
        public DbSet<ShoppingCartItemDto> ShoppingCartItems { get  ; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
    }
}

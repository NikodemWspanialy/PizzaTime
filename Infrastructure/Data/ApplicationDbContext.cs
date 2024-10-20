using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Topping> toppings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Topping>().HasData(
                new Topping() { Name = "Peperoni", Price = 5, IsAvailable = true, NormalizeName = "PEPERONI" },
                new Topping() { Name = "Cheese", Price = 3, IsAvailable = true , NormalizeName = "CHEESE"},
                new Topping() { Name = "Chicken", Price = 4, IsAvailable = true, NormalizeName = "CHICKEN" },
                new Topping() { Name = "Mozzarella", Price = 5, IsAvailable = true, NormalizeName = "MOZZARELLA" },
                new Topping() { Name = "Brocoli", Price = 6, IsAvailable = true, NormalizeName = "BROCOLI" }
                );
        }
    }
}

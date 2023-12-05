using CoffeeApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeeApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Brew> Brews { get; set; }
    public DbSet<Brew> Coffee { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}


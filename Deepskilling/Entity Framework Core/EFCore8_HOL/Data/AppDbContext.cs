using Microsoft.EntityFrameworkCore;
using EFCore8_HOL.Models;

namespace EFCore8_HOL.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
        "Server=localhost;Database=RetailDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
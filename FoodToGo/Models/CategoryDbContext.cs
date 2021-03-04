using System;
using FoodToGo.Models;
using Microsoft.EntityFrameworkCore;

public class CategoryDbContext : DbContext
{
    public CategoryDbContext(DbContextOptions<CategoryDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Category { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<Cart> Cart { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Seed();
    }
}
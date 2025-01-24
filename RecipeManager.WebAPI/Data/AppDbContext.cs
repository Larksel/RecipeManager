using Microsoft.EntityFrameworkCore;
using RecipeManager.WebAPI.Data.Builders;
using RecipeManager.WebAPI.Objects.Models;

namespace RecipeManager.WebAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Category> Categories { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<UnitOfMeasure> UnitsOfMeasure { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        CategoryBuilder.Build(modelBuilder);
        IngredientBuilder.Build(modelBuilder);
        RecipeBuilder.Build(modelBuilder);
        UnitOfMeasureBuilder.Build(modelBuilder);
        RecipeCategoryBuilder.Build(modelBuilder);
        RecipeIngredientBuilder.Build(modelBuilder);
    }
}

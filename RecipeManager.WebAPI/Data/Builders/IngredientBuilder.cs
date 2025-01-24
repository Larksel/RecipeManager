using Microsoft.EntityFrameworkCore;
using RecipeManager.WebAPI.Objects.Models;

namespace RecipeManager.WebAPI.Data.Builders;

public class IngredientBuilder
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>().HasKey(i => i.Id);
        modelBuilder.Entity<Ingredient>().Property(i => i.Name).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Ingredient>().Property(i => i.UnitOfMeasureId).IsRequired();

        modelBuilder.Entity<Ingredient>()
            .HasData(new List<Ingredient>
            {
                new(1, "Leite Condensado", 2),
                new(2, "Achocolatado em Pó", 2),
                new(3, "Leite Integral", 4),
            });
    }
}

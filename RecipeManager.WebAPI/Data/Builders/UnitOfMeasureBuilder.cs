using Microsoft.EntityFrameworkCore;
using RecipeManager.WebAPI.Objects.Models;

namespace RecipeManager.WebAPI.Data.Builders;

public class UnitOfMeasureBuilder
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UnitOfMeasure>().HasKey(uom => uom.Id);
        modelBuilder.Entity<UnitOfMeasure>().Property(uom => uom.Abbreviation).IsRequired().HasMaxLength(3);
        modelBuilder.Entity<UnitOfMeasure>().Property(uom => uom.Description).IsRequired().HasMaxLength(30);

        modelBuilder.Entity<UnitOfMeasure>()
            .HasData(new List<UnitOfMeasure>
            {
                new(1, "Kilograma", "kg"),
                new(2, "Grama", "g"),
                new(3, "Miligrama", "mg"),
                new(4, "Litro", "l"),
                new(5, "Mililitro", "ml"),
            });
    }
}

using Microsoft.EntityFrameworkCore;
using RecipeManager.WebAPI.Objects.Models;
using RecipeManager.WebAPI.Objects.Enums;

namespace RecipeManager.WebAPI.Data.Builders;

public class RecipeBuilder
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>().HasKey(r => r.Id);
        modelBuilder.Entity<Recipe>().Property(r => r.Name).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Recipe>().Property(r => r.Instructions).IsRequired().HasMaxLength(4000);
        modelBuilder.Entity<Recipe>().Property(r => r.PreparationTimeMinutes).IsRequired();
        modelBuilder.Entity<Recipe>().Property(r => r.Difficulty).IsRequired();

        modelBuilder.Entity<Recipe>()
            .HasData(new List<Recipe>
            {
                new(1, "Leite condensado com chocolate", "Misture leite condensado com o achocolatado em pó", 5, Difficulty.BEGINNER),
                new(2, "Ovo frito", "Unte uma frigideira com óleo acenda o fogo e despeje o ovo", 10, Difficulty.BEGINNER),
            });
    }
}

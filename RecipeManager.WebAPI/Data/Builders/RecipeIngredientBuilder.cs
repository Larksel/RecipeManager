using Microsoft.EntityFrameworkCore;
using RecipeManager.WebAPI.Objects.Models;

namespace RecipeManager.WebAPI.Data.Builders;

public class RecipeIngredientBuilder
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeIngredient>().HasKey(ri => new { ri.RecipeId, ri.IngredientId });
    }
}

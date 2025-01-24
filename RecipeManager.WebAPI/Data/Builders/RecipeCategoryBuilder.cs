using Microsoft.EntityFrameworkCore;
using RecipeManager.WebAPI.Objects.Models;

namespace RecipeManager.WebAPI.Data.Builders;

public class RecipeCategoryBuilder
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeCategory>().HasKey(rc => new { rc.RecipeId, rc.CategoryId });
    }
}

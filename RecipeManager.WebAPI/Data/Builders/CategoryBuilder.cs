using Microsoft.EntityFrameworkCore;
using RecipeManager.WebAPI.Objects.Models;

namespace RecipeManager.WebAPI.Data.Builders;

public class CategoryBuilder
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasKey(c => c.Id);
        modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Category>().Property(c => c.Description).IsRequired().HasMaxLength(200);

        modelBuilder.Entity<Category>()
            .HasData(new List<Category>
            {
                new(1, "Brasileira", "Comida típica de cada região do Brasil"),
                new(2, "Bebidas", "Sucos, coquetéis, chás, cafés, etc."),
                new(3, "Sobremesa", "Doces deliciosos pós refeições"),
            });
    }
}

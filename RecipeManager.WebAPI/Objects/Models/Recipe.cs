using RecipeManager.WebAPI.Objects.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.WebAPI.Objects.Models;

[Table("recipe")]
public class Recipe
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("instructions")]
    public string Instructions { get; set; }

    [Column("preparationtimeminutes")]
    public int PreparationTimeMinutes { get; set; }

    [Column("difficulty")]
    public Difficulty Difficulty { get; set; }

    public List<Category> Categories { get; } = [];
    public List<RecipeCategory> RecipeCategories { get; } = [];

    public List<Ingredient> Ingredients { get; } = [];
    public List<RecipeIngredient> RecipeIngredients { get; } = [];

    public Recipe()
    {

    }

    public Recipe(int id, string name, string instructions, int preparationTimeMinutes, Difficulty difficulty)
    {
        Id = id;
        Name = name;
        Instructions = instructions;
        PreparationTimeMinutes = preparationTimeMinutes;
        Difficulty = difficulty;
    }
}

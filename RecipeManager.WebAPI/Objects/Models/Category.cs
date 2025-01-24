using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.WebAPI.Objects.Models;

[Table("category")]
public class Category
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("description")]
    public string Description { get; set; }

    public List<Recipe> Recipes { get; } = [];
    public List<RecipeCategory> RecipeCategories { get; } = [];

    public Category()
    {

    }

    public Category(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}

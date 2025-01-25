using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.WebAPI.Objects.Models;

/*
 * Para criar uma classe de junção customizada:
 * https://stackoverflow.com/questions/7050404/create-code-first-many-to-many-with-additional-fields-in-association-table?rq=1
 */

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

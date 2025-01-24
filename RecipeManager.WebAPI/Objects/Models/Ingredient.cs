using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.WebAPI.Objects.Models;

[Table("ingredient")]
public class Ingredient
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("unitofmeasureid")]
    public int UnitOfMeasureId { get; set; }

    [ForeignKey(nameof(UnitOfMeasureId))]
    public UnitOfMeasure UnitOfMeasure { get; init; }

    public List<Recipe> Recipes { get; } = [];
    public List<RecipeIngredient> RecipeIngredients { get; } = [];

    public Ingredient()
    {

    }

    public Ingredient(int id, string name, int unitOfMeasureId, UnitOfMeasure unitOfMeasure)
    {
        Id = id;
        Name = name;
        UnitOfMeasureId = unitOfMeasureId;
        UnitOfMeasure = unitOfMeasure;
    }
}

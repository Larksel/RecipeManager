using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.WebAPI.Objects.Models;

/*
 * Para criar uma classe de junção customizada:
 * https://stackoverflow.com/questions/7050404/create-code-first-many-to-many-with-additional-fields-in-association-table?rq=1
 */

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
    public UnitOfMeasure? UnitOfMeasure { get; init; }

    public List<Recipe> Recipes { get; } = [];

    public Ingredient()
    {

    }

    public Ingredient(int id, string name, int unitOfMeasureId)
    {
        Id = id;
        Name = name;
        UnitOfMeasureId = unitOfMeasureId;
    }
}

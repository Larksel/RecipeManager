using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.WebAPI.Objects.Models;

[Table("unitofmeasure")]
public class UnitOfMeasure
{
    [Column("id")]
    public int Id { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("abbreviation")]
    public string Abbreviation { get; set; }

    public List<Ingredient> Ingredients { get; } = [];

    public UnitOfMeasure()
    {

    }

    public UnitOfMeasure(int id, string description, string abbreviation)
    {
        Id = id;
        Description = description;
        Abbreviation = abbreviation;
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.WebAPI.Objects.Models;

[Table("recipeingredient")]
public class RecipeIngredient
{
    [Column("quantity")]
    public float Quantity { get; set; }

    [Key]
    [Column("recipeid")]
    public int RecipeId { get; set; }

    [Key]
    [Column("ingredientid")]
    public int IngredientId { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public Recipe Recipe { get; set; } = null!;

    [ForeignKey(nameof(IngredientId))]
    public Ingredient Ingredient { get; set; } = null!;
}

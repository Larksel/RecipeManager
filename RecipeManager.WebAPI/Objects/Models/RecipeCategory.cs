using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeManager.WebAPI.Objects.Models;

[Table("recipecategory")]
public class RecipeCategory
{
    [Key]
    [Column("recipeid")]
    public int RecipeId { get; set; }

    [Key]
    [Column("categoryid")]
    public int CategoryId { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public Recipe Recipe { get; set; } = null!;

    [ForeignKey(nameof(CategoryId))]
    public Category Category { get; set; } = null!;
}

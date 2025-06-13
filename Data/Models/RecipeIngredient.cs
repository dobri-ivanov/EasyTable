using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyTable.Data.Models
{
    public class RecipeIngredient
    {
        [Key]
        public int Id { get; set; }

        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        public decimal QuantityRequired { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyTable.Data.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public decimal SellingPrice { get; set; } = 0.00m;

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyTable.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public UnitOfMeasure UnitOfMeasure { get; set; }

        [Required]
        public decimal CurrentStockQuantity { get; set; }

        [Required]
        public decimal PurchasePrice { get; set; } = 0.00m;

        [MaxLength(255)]
        public string SupplierInfo { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    }
}
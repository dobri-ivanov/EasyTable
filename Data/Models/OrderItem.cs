using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyTable.Data.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Required]
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [NotMapped]
        public decimal Subtotal => Quantity * (Recipe?.SellingPrice ?? 0.00m);
    }
}

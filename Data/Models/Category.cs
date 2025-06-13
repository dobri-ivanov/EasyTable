using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyTable.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
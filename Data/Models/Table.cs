using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyTable.Data.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string TableNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string CurrentStatus { get; set; } = "Available";

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
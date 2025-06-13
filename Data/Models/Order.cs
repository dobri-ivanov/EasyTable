using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyTable.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int TableId { get; set; }
        [ForeignKey("TableId")]
        public Table Table { get; set; }

        [Required]
        public DateTime StartTime { get; set; } = DateTime.Now;

        public DateTime? EndTime { get; set; }

        [Required]
        public decimal TotalPrice { get; set; } = 0.00m;

        public decimal DiscountAmount { get; set; } = 0.00m;

        [Required]
        public bool IsClosed { get; set; } = false;

        public string FiscalInfo { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
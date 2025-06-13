using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyTable.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string HashedPassword { get; set; } = string.Empty;

        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(255)]
        public string ContactInfo { get; set; }

        public DateTime DateHired { get; set; } = DateTime.Now;
    }
}
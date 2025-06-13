using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyTable.Data.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace Doser.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public DateTime TimeCreate { get; set; }
        public DateTime TimeDeleted { get; set; }
        public bool isDeleted { get; set; }
        public string Description { get; set; }
    }
}
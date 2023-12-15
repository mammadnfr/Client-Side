using System;
using System.ComponentModel.DataAnnotations;

namespace Jalese4.Models
{
    public class Basket
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public required String Name { get; set; }
        public int Count { get; set; }
        [StringLength(50)]
        public String? Color { get; set; }

        [StringLength(200)]
        public required string Category { get; set; }
        public Nullable<int> Price { get; set; }
        [StringLength(5000)]
        public string? Description { get; set; }
    }
}
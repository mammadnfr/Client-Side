using System;
using System.ComponentModel.DataAnnotations;

namespace Jalese4.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public String Name { get; set; }
        public int Count { get; set; }
        [StringLength(50)]
        public String? Color { get; set; }

        [StringLength(200)]
        public string Category { get; set; }
        public Nullable<int> Price { get; set; }
        [StringLength(5000)]
        public string? Description { get; set; }

        public bool available { get; set; }

    }
}
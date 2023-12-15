
using System.ComponentModel.DataAnnotations;

namespace Jalese4.Models
{
    public class Users
    {
        [Required]
        [Key]
        public int id { get; set; }
        [StringLength(100)]
        public string? name { get; set; }
        [StringLength(100)]
        public string? family { get; set; }
        [EmailAddress]
        public string? email { get; set; }
        [Required]
        [StringLength(30)]
        public string password { get; set; }
        [StringLength(11)]
        public string? phone { get; set; }

    }

}
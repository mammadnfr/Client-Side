using System;
using System.ComponentModel.DataAnnotations;


namespace Jalese5
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        [StringLength(100)]
        [Required]
        public string Family { get; set; }
        [StringLength(100)]
        public string? SureName { get; set; }
        [StringLength(100)]
        public string? NameFather { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime? BirthDay { get; set; }
        public bool? Gender { get; set; }
        public bool? Active { get; set; }
        public double? weight { get; set; }




    }
}
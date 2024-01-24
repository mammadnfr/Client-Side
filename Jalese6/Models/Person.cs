using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Jalese6.Models
{
    public class Person
    {
        [Key]
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        [StringLength(100)]
        public string? Name100 { get; set; }

        [StringLength(200)]
        public string? Name200 { get; set; }


    }
}
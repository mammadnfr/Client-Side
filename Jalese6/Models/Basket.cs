using System.ComponentModel.DataAnnotations;

namespace Jalese6.Models
{
    public class Basket
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
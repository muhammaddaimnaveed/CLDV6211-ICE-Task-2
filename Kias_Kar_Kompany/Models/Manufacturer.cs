using System.ComponentModel.DataAnnotations;

namespace Kias_Kar_Kompany.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }

        public required string Name { get; set; }
    }
}
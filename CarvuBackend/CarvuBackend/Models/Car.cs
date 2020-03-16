using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
       
        [Required]
        public string VIN { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public double Rate { get; set; }
    }
}

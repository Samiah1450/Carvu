using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Models
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        public Guid CarId { get; set; }
    }
}

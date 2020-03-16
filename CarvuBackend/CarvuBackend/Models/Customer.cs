using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Zip { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string License { get; set; }
    }
}

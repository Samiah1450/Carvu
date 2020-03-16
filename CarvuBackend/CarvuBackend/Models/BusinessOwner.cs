using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Models
{
    public class BusinessOwner
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string LoginId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}

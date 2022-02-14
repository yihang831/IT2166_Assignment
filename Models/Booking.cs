using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT2166_Assignment.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 9)]
        public string NRIC { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string MaritalStatus { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8)]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }
    }
}

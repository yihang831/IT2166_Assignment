using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT2166_Assignment.ViewModels
{
    public class EditAccountViewModel
    {
        public string ImagePath { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

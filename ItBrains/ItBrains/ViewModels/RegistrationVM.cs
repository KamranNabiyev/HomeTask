using ItBrains.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.ViewModels
{
    public class RegistrationVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string Phone { get; set; }
        public List<Service> Services { get; set; }
    }
}

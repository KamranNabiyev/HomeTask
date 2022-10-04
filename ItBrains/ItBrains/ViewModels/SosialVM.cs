using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.ViewModels
{
    public class SosialVM
    {
        [Required(ErrorMessage ="Bu xana boş ola bilməz")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Bu xana boş ola bilməz")]
        public string Mobile { get; set; }
       
    }
}

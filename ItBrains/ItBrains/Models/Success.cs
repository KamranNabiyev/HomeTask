using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class Success
    {
        public int Id { get; set; }
        public string By { get; set; }
        public string Who { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public bool IsDeactive { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}

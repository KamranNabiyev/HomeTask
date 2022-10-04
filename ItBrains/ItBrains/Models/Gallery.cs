using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsTeacher { get; set; }
        public bool IsDeactive { get; set; }
    }
}

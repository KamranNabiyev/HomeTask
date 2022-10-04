using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Field { get; set; }
        public string Image { get; set; }
        public bool IsDeactive { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class VideoLesson
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string AzName { get; set; }
        public string EnName { get; set; }
        public string RuName { get; set; }
        public List<Video> Videos { get; set; }
        public bool IsDeactive { get; set; }

    }
}

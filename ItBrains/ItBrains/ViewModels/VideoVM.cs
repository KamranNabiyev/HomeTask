using ItBrains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.ViewModels
{
    public class VideoVM
    {
        public List<Video> Videos { get; set; }
        public VideoLesson VideoLesson { get; set; }
    }
}

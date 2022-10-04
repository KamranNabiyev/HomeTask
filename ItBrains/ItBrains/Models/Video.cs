using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public VideoLesson VideoLesson { get; set; }
        public int VideoLessonId { get; set; }
        public bool IsDeactive { get; set; }

    }
}

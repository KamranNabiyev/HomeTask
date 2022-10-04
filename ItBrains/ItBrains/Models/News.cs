using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string AzTitle { get; set; }
        public string EnTitle { get; set; }
        public string RuTitle { get; set; }
        public string AzSubTitle { get; set; }
        public string RuSubTitle { get; set; }
        public string EnSubTitle { get; set; }
        public string AzDescription { get; set; }
        public string RuDescription { get; set; }
        public string EnDescription { get; set; }
        public bool IsDeactive { get; set; }

    }
}

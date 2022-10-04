using ItBrains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.ViewModels
{
    public class HomeVM
    {
        public List<Service> Services { get; set; }
        public List<GraduatedOpinion> GraduatedOpinions { get; set; }
        public List<News> News { get; set; }
        public About About { get; set; }
        //public List<News> GraduatedOpinions { get; set; }
    }
}

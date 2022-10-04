using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string AzServiceName { get; set; }
        public string AzServiceDescription { get; set; }
        public string EnServiceName { get; set; }
        public string EnServiceDescription { get; set; }
        public string RuServiceName { get; set; }
        public string RuServiceDescription { get; set; }
        public string ServiceIcon { get; set; }
        public bool IsDeactive { get; set; }
        public ServiceDetail ServiceDetail { get; set; }
        public List<ServiceImage> ServiceImages { get; set; }
    }
}

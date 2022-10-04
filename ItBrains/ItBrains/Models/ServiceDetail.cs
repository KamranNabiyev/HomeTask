using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class ServiceDetail
    {
        public int Id { get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public bool IsDeactive { get; set; }
        public string AzDescription { get; set; }
        public string EnDescription { get; set; }
        public string RuDescription { get; set; }
        public string AzTagDescription { get; set; }
        public string TagIcon { get; set; }
        public string EnTagDescription { get; set; }
        public string RuTagDescription { get; set; }
        public string AzTimeDescription { get; set; }
        public string EnTimeDescription { get; set; }
        public string RuTimeDescription { get; set; }
        public string AzDateDescription { get; set; }
        public string EnDateDescription { get; set; }
        public string RuDateDescription { get; set; }
        public string AzCertfDescription { get; set; }
        public string EnCertfDescription { get; set; }
        public string RuCertfDescription { get; set; }
        public string AzLessDescription { get; set; }
        public string EnLessDescription { get; set; }
        public string RuLessDescription { get; set; }

    }
}

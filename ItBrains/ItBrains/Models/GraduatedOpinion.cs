using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Models
{
    public class GraduatedOpinion
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Field { get; set; }
        public string Image { get; set; }
        public bool IsDeactive { get; set; }
        public string AzDescription  { get; set; }
        public string RuDescription  { get; set; }
        public string EnDescription  { get; set; }
    }
}

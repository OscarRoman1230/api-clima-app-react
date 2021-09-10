using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasTestApi.Models
{
    public class History
    {
        [Key]
        public int id { get; set; }
        public string city { get; set; }
        public string info { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace summer_chore_chart.Models
{
    public class Chorelist
    {
        public int Id { get; set; }
        public string Chorename { get; set; }
        public string Choreamt { get; set; }
    }
}

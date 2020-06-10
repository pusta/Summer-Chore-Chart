using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace summer_chore_chart.Models
{
    public class Penalties
    {

        public int Id { get; set; }
        public string Penaltyname { get; set; }
        public string Penaltyamt { get; set; }
    }
}

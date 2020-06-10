using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace summer_chore_chart.Models
{
    public class BalanceTrack
    {

        public int Id { get; set; }
        public int? Childid { get; set; }
        public int? Currenttotal { get; set; }

    }
}

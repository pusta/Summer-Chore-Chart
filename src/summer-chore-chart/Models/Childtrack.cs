using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace summer_chore_chart.Models
{
    public class Childtrack
    {
        public int Id { get; set; }
        public int Childid { get; set; }
        public int Rewardid { get; set; }
        public int Penaltyid { get; set; }
        public DateTime Recorddate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace summer_chore_chart.Models
{
    public class Child
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string ChildName { get; set; }
    }
}

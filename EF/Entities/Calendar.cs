using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Entities
{
    [Table("cl.Clander")]
    public class Calendar
    {
        [Key]
        public int Persian_Date { get; set; }

        public int Gregorian_Date { get; set; }

        public byte DayOfWeek { get; set; }

        public string Pr_DateDisplay { get; set; }

        public string Gr_DateDisplay { get; set; }

        public short Pr_Year { get; set; }

        public short Gr_Year { get; set; }

        public byte Pr_Month { get; set; }

        public byte Gr_Month { get; set; }

        public byte Pr_Day { get; set; }

        public byte Gr_Day { get; set; }

        public int? DayCounter { get; set; }


    }
}

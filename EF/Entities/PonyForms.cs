using EF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Entities
{
    [Table("SL.PonyForms")]
    public class PonyForms  : BaseEntity
    {
    public long ID { get; set; }

    public long ID_Pr { get; set; }

    public long ID_Hokm { get; set; }

    public int Date { get; set; }

    public int FromDate { get; set; }

    public int ToDate { get; set; }

    public decimal? BasicSalaryPerDay { get; set; }

    public decimal? BasicSalaryPerMonth { get; set; }

    public int? DayCount { get; set; }

    public int? LeaveDay { get; set; }

    public int? LeaveHour { get; set; }

    public int? LeaveMin { get; set; }

    public decimal? LeaveRls { get; set; }

    public decimal? OtherAdditions { get; set; }

    public decimal? OtherDeductions { get; set; }

    public decimal? Eydi { get; set; }

    public decimal? Sanavat { get; set; }

}

}

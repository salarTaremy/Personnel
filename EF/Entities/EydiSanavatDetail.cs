
using EF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Entities
{

    [Table("sl.EydiSanavatDetail")]
    public class EydiSanavatDetail  : BaseEntity 
        {
            public long ID { get; set; }

            public int ID_EydiSanavat { get; set; }

            public long ID_Person { get; set; }

            public long Amount { get; set; }
            public long ID_Hokm { get; set; }
            public int DayCount { get; set; }
            public long LeavePlusRls { get; set; }
            public long LeaveMinusRls { get; set; }
            public long DelayedSalaryRls { get; set; }
            public long MoreDiscountRls { get; set; }



        [ForeignKey("ID_EydiSanavat")]      
            public virtual  EydiSanavat EydiSanavat { get; set; }

    }

}

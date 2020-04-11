
using EF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Entities
{

    [Table("Sl.EydiSanavat")]
    public class EydiSanavat  : BaseEntity 
        {
            public int ID { get; set; }

            public int Date { get; set; }

            public int FromDate { get; set; }

            public int ToDate { get; set; }

            public byte ID_Type { get; set; }

            public string Description { get; set; }
        public virtual ICollection<EydiSanavatDetail> EydiSanavatDetails { get; set; }

    }


}

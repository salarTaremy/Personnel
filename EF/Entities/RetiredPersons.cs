
using EF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Entities
{

    [Table("Pr.RetiredPersons")]
    public class RetiredPersons
    {
        public long ID { get; set; }
        public long ID_Pr { get; set; }
        public int DateOfRetired { get; set; }
        public string Description { get; set; }
    }

}

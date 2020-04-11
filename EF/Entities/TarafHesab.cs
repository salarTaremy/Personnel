using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Entities
{
    [Table("Th.Taraf_Hesab")]
    public class TarafHesab
    {
        public long Counter { get; set; }

        public DateTime? CreateDate { get; set; }

        public string HOST_NAME { get; set; }

        public string APP_NAME { get; set; }

        public long ID { get; set; }

        public string Name { get; set; }

        public string Famil { get; set; }

        public string Sh_Sh { get; set; }

        public string NamePedar { get; set; }

        public long? ID_TafsilGroup { get; set; }

        public long? ID_Tafsil { get; set; }

        public string Code_melli { get; set; }

        public string Code_Eghtesadi { get; set; }

        public int? BirthDay { get; set; }

        public int? SodoorDate { get; set; }

        public long? Serial { get; set; }

        public long? ID_MahalTavalod { get; set; }

        public long? ID_MahalSodoor { get; set; }

        public string FullName { get; set; }

        public long Credit { get; set; }

        public string WebPassword { get; set; }

        public string OldAccountingCode { get; set; }


    }
}

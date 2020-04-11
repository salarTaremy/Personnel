using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Entities
{
    [Table("pr.Personel")]
    public class Personel
    {
        public long Counter { get; set; }

        public DateTime? CreateDate { get; set; }

        public string HOST_NAME { get; set; }

        public string APP_NAME { get; set; }

        public long ID { get; set; }

        public string CodePersoneli { get; set; }

        public string ShomarehBime { get; set; }

        public long ID_TarafHesab { get; set; }

        public int ID_Din { get; set; }

        public int ID_MadrakTahsili { get; set; }

        public int ID_Mazhab { get; set; }

        public int ID_Melliat { get; set; }

        public int ID_NezamVazifeh { get; set; }

        public int ID_Taahol { get; set; }

        public int ID_Tabeiyat { get; set; }

        public int ID_Jensiat { get; set; }

        public int ID_VaziatKhedmat { get; set; }

        public byte ChildCount { get; set; }

        public byte[] Photo { get; set; }

        public byte? ID_PersonStatus { get; set; }
    }
}

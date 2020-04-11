using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public  class ClsAccontNO
    {
        public enum EnumBank
        {
            Mellat = 1,
            Melli = 2,
            Sepah = 3
        }

        public long ID_Person { get; set; }
        public  string AccontNo { get; set; }
        public long? Balance { get; set; }
        public EnumBank Bank { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public class ClsCompany
    {
        public ClsCompany()
        {

        }
        public DataTable GetAllPerPersonel(long ID_Pr)
        {

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = "[Pr].[UspGetCompanyPerPersonel]";
            Cmd.Parameters.AddWithValue("@ID_Pr", ID_Pr);
            DataTable Dt = Global.DB.FillDataTable(Cmd);
            return Dt;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public class ClsEydiSanavat
    {

        public DataTable GetKholase(short year , long ID_Kargah)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = "sl.UspGetEydiSanavatKholase";
            Cmd.Parameters.AddWithValue("@year", year);
            Cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
            DataTable Dt = Global.DB.FillDataTable(Cmd);
            return Dt;
        }
        public DataTable GetKholase(short year, long ID_Kargah, long ID_Person) 
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = "sl.UspGetEydiSanavatKholase";
            Cmd.Parameters.AddWithValue("@year", year);
            Cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
            Cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
            DataTable Dt = Global.DB.FillDataTable(Cmd);
            return Dt;
        }

    }
}

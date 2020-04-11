using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public class ClsPony
    {

        public static DataTable GetAll(long ID_Person)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetPonyForms]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ID_Person", ID_Person);
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetAll()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetPonyForms]";
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

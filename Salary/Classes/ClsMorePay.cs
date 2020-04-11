using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public class ClsMorePay
    {
        public int Save(int? ID  ,int Date , int Description, int Detail,  DataTable  SL_MorePayDetail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAddOtherPayment]";
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Detail", Detail);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

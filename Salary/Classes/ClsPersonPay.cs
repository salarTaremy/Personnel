using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public class ClsPersonPay
    {
        SqlCommand Cmd = new SqlCommand();
        public DataTable Get(short ID_MonthOfSalary)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetPersonPay]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ID_MonthOfSalary", ID_MonthOfSalary);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }
        public string AddBuyToPayroll(short ID_MonthOfSalary ,  long ID_pr , long  Price   )
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspAddPersonBuy]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_MonthOfSalary", ID_MonthOfSalary);
                Cmd.Parameters.AddWithValue("ID_pr", ID_pr);
                Cmd.Parameters.AddWithValue("Price", Price);
                Cmd.Parameters.AddWithValue("AlowInsertData", 0);
                return Global.DB.FillDataTable(Cmd).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

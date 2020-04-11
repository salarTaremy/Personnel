using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public class ClsBlackListPerson
    {
        public Boolean AddToBlackList(long ID_Person, short ID_MonthOfSalary)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand("INSERT INTO Sl.BlackList( ID_Person ,ID_MonthOfSalary) VALUES  ( @ID_Person  ,@ID_MonthOfSalary )");
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("ID_Person", ID_Person);
                Cmd.Parameters.AddWithValue("ID_MonthOfSalary", ID_MonthOfSalary);
                if (Global.DB.ExecuteNonQuery(Cmd) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Delete(int ID)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand("DELETE Sl.BlackList WHERE ID = @ID");
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@ID", ID);
                if (Global.DB.ExecuteNonQuery(Cmd) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAll(short ID_MonthOfSalary)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Sl].[UspGetBlackListPerson]";
                Cmd.Parameters.AddWithValue("@ID_MonthOfSalary", ID_MonthOfSalary);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
    }
}

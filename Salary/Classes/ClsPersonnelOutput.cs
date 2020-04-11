using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Personnely;

namespace Salary.Classes
{
    class ClsPersonnelOutput
    {
        SqlCommand Cmd = new SqlCommand();
        public ClsPersonnelOutput()
        {

        }
        public DataTable GetPerDay(ClsPersonel Person , int FromDate, int ToDate)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetWorkPerDay]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_Pr", Person.ID);
                Cmd.Parameters.AddWithValue("FromDate", FromDate);
                Cmd.Parameters.AddWithValue("ToDate", ToDate);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public DataSet GetPerDayWithDetail(ClsPersonel Person, int FromDate, int ToDate)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetWorkPerDayWithDeatail]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_Pr", Person.ID);
                Cmd.Parameters.AddWithValue("StartDate", FromDate);
                Cmd.Parameters.AddWithValue("EndDate", ToDate);
                return Global.DB.FillDataSet(Cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetPerMonth(ClsPersonel Person, byte ID_FromMonth, byte ID_ToMonth)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetWorkPerMonth]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_Pr", Person.ID);
                Cmd.Parameters.AddWithValue("ID_FromMonth", ID_FromMonth);
                Cmd.Parameters.AddWithValue("ID_ToMonth", ID_ToMonth);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

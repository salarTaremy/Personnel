using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Salary
{
    class ClsPayroll
    {
        SqlCommand Cmd= new SqlCommand() ;
        public ClsPayroll()
        {

        }
        public DataTable GetAll(short? Year, long? ID_Person, byte? ID_Month_A, byte? ID_Month_B ,short ID_MahaleKhedmat = 0 , byte? ID_Company  = null , long? ID_Kargah = null, long? ID_KargahEx = null, bool ShowAll = false, bool ShowZeroWork = false)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetAllPayroll]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("Year",Year);
                Cmd.Parameters.AddWithValue("ID_Person", ID_Person );
                Cmd.Parameters.AddWithValue("ID_Month_A", ID_Month_A);
                Cmd.Parameters.AddWithValue("ID_Month_B", ID_Month_B);
                Cmd.Parameters.AddWithValue("ID_MahaleKhedmat", ID_MahaleKhedmat);
                Cmd.Parameters.AddWithValue("ID_Kargah", ID_Kargah);
                Cmd.Parameters.AddWithValue("ID_KargahEx", ID_KargahEx);
                Cmd.Parameters.AddWithValue("ID_Company", ID_Company);
                Cmd.Parameters.AddWithValue("ShowAll", ShowAll);
                Cmd.Parameters.AddWithValue("ShowDayCount_0", ShowZeroWork);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public DataSet Get(DataTable ID_Array)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetPayroll]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ID_Array", ID_Array);
                return Global.DB.FillDataSet(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public int Delete(int ID)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspDeletePayroll]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID", ID);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }
        public int AddPayroll( int ID_MonthlyWork)
        {
            try 
	        {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspCalculatePayroll]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_MonthlyWork", ID_MonthlyWork);
                return Global.DB.ExecuteNonQuery(Cmd);
	        }
	        catch (Exception ex)
	        {
		
		        throw ex ;
	        }
        }
        public DataTable GetAmel(int? ID_WorkPerMonth = null)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[Sl].[UspGetPayrollAvamel]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_WorkPerMonth", ID_WorkPerMonth);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
 
        public DataTable GetMonthlyList( long ID_Kargah, short ID_MonthOfSalary, byte ID_Company, bool ShowAll = false) //3
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[sl].[UspGetMonthlyList]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ID_MonthOfSalary", ID_MonthOfSalary);
                Cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                Cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                Cmd.Parameters.AddWithValue("@ShowAll", ShowAll);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyList(long ID_Kargah, short ID_MonthOfSalary, short ID_MahaleKhedamt, byte ID_Company,bool ShowAll = false)//4
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[sl].[UspGetMonthlyList]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ID_MonthOfSalary", ID_MonthOfSalary);
                Cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                Cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                Cmd.Parameters.AddWithValue("@ID_MahaleKhedamt", ID_MahaleKhedamt);
                Cmd.Parameters.AddWithValue("@ShowAll", ShowAll);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyList(short ID_MonthOfSalary, byte ID_Company, bool ShowAll = false) //7
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[sl].[UspGetMonthlyList]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ID_MonthOfSalary", ID_MonthOfSalary);
                Cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                Cmd.Parameters.AddWithValue("@ShowAll", ShowAll);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyList(short ID_MonthOfSalary, short ID_MahaleKhedamt, byte ID_Company, bool ShowAll = false)//8
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandText = "[sl].[UspGetMonthlyList]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ID_MonthOfSalary", ID_MonthOfSalary);
                Cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                Cmd.Parameters.AddWithValue("@ID_MahaleKhedamt", ID_MahaleKhedamt);
                Cmd.Parameters.AddWithValue("@ShowAll", ShowAll);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Salary
{
   public class ClsMonthOfSalary
    {
       public ClsMonthOfSalary()
       {
           Exists = false;
       }
       public ClsMonthOfSalary(short ID)
       {
           Exists = false;
           ClsMonthOfSalary M =  GetByID(ID);
           this.ID = ID;
           this.Exists = M.Exists;
            if (M.Exists )
	        {
	               this.Year = M.Year;
                   this.ID_Month = M.ID_Month;
                   this.From = M.From;
                   this.To = M.To;	 
	        }
       }
        SqlCommand Cmd = new SqlCommand();
        public short? ID { get; set; }
        public short Year { get; set; }
        public byte ID_Month { get; set; }
        public int  From { get; set; }
        public int To { get; set; }
        public bool Exists { get; set; }

        public DataTable GetAll()
        {
            try 
	        {	        
		            Cmd.CommandText = "[Sl].[UspGetMonthOfYear]";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Clear();
                    return Global.DB.FillDataTable(Cmd);
	        }
	        catch (Exception ex)
	        {
		
		        throw ex ;
	        }

        }
        public DataTable GetAll(short Year)
        {
            try
            {
                Cmd.CommandText = "[Sl].[UspGetMonthOfYear]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@year", Year);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }

        }


        public int GetDayCount(short ID_MonthOfSalary )
        {
            try
            {
                Cmd.CommandText = "cl.Usp_GetdayCountOfMonth";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_MonthOfSalary", ID_MonthOfSalary);
                return (int)Global.DB.FillDataTable(Cmd).Rows[0]["DayCount"];
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public ClsMonthOfSalary GetByID(short ID) 
        {
            try
            {
                Cmd.CommandText = "[Sl].[UspGetMonthOfYearPerID]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", ID);
                DataTable Dt_Tmp = new DataTable();
                Dt_Tmp = Global.DB.FillDataTable(Cmd);
                ClsMonthOfSalary ReturnValue = new ClsMonthOfSalary();
                if (Dt_Tmp.Rows.Count ==0)
	            {   
                    ReturnValue.Exists = false ;
	            }
                else
	            {
                    ReturnValue.Exists = true;
                    ReturnValue.ID = ID;
                    ReturnValue.ID_Month = (byte)Dt_Tmp.Rows[0]["Month"];
                    ReturnValue.From = (int)Dt_Tmp.Rows[0]["From"];
                    ReturnValue.To = (int)Dt_Tmp.Rows[0]["To"];
                    ReturnValue.Year = (short)Dt_Tmp.Rows[0]["Year"];
	            }
                  return ReturnValue;  
            }
            catch (Exception ex)
            {

                throw ex ;
            }

        }




                public int Delete(short ID)
                {
                    try
                    {
                        Cmd.CommandText = "[Sl].[UspDeleteMonthOfSalary]";
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.Clear();
                        Cmd.Parameters.AddWithValue("@ID", ID);
                        return Global.DB.ExecuteNonQuery(Cmd);
                    }
                    catch (Exception ex)
                    {
                        
                        throw ex ;
                    }
                }
                public int Add(ClsMonthOfSalary MD)
                {
                    try
                    {
                    Cmd.CommandText = "[Sl].[UspAddMonthOfSalary]";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Clear();
                    Cmd.Parameters.AddWithValue("@Year", MD.Year);
                    Cmd.Parameters.AddWithValue("@ID_Month", MD.ID_Month);
                    Cmd.Parameters.AddWithValue("@From", MD.From);
                    Cmd.Parameters.AddWithValue("@To", MD.To);
                    return Global.DB.ExecuteNonQuery(Cmd);
                    }
                    catch (Exception ex)
                    {
                        
                        throw ex ;
                    }

                }
                public int Update(ClsMonthOfSalary MD)
                {
                    try
                    {
                    Cmd.CommandText = "[Sl].[UspUpdateMonthOfSalary]";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Clear();
                    Cmd.Parameters.AddWithValue("@Year", MD.Year);
                    Cmd.Parameters.AddWithValue("@ID_Month", MD.ID_Month);
                    Cmd.Parameters.AddWithValue("@From", MD.From);
                    Cmd.Parameters.AddWithValue("@To", MD.To);
                    Cmd.Parameters.AddWithValue("@ID", MD.ID);
                    return Global.DB.ExecuteNonQuery(Cmd);
                    }
                    catch (Exception ex)
                    {
                        throw ex ;
                    }
                }

    }
}

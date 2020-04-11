using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient ;
using System.Data;
using Salary;


    public class ClsMonthlyWork
    {
        SqlCommand Cmd = new SqlCommand();
        public ClsMonthlyWork()
        {

        }
        public Personnely.ClsPersonel Person { get; set; }
        public ClsMonthOfSalary MonthOfSalary { get; set; }
        public byte DayCount { get; set; }
        public byte DailyMission { get; set; }
        public byte ID_Company { get; set; }
        public short HourlyMission { get; set; }
        public byte DailyLeave { get; set; }
        public short HourlyLeave { get; set; }
        public short Absence { get; set; }
        public short OverTime { get; set; }
        public short OvertimeLastYear { get; set; }
        public long OvertimeLastYearRlsPerHour { get; set; }
        public short NightWork { get; set; }
        public short HolidayWork { get; set; }
        public long Advance { get; set; }
        public long Loan { get; set; }
        public long Bonus { get; set; }
        public long Buy { get; set; }
        public long OtherAddition { get; set; }
        public long OtherDiscount { get; set; }
        public DataTable Detail { get; set; }
        public int Save(ClsMonthlyWork Mw)
        {
            try 
	        {
                if (Mw.Person.Exists == false )
                {
                    throw new Exception("پرسنل مورد نظر نا معتبر است");
                }
                if (Mw.MonthOfSalary.Exists == false )
	            {
		             throw new Exception(" ماه حقوقی نا معتبر است");
	            }
	            Cmd.CommandText = "[Sl].[UspAddWorkPerMonth]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("ID_Person",Mw.Person.ID);
                Cmd.Parameters.AddWithValue("ID_Company", Mw.ID_Company);
                Cmd.Parameters.AddWithValue("ID_MonthOfSalary",Mw.MonthOfSalary.ID);
                Cmd.Parameters.AddWithValue("DayCount",Mw.DayCount);
                Cmd.Parameters.AddWithValue("DailyMission",Mw.DailyMission);
                Cmd.Parameters.AddWithValue("HourlyMission",Mw.HourlyMission);
                Cmd.Parameters.AddWithValue("DailyLeave",Mw.DailyLeave);
                Cmd.Parameters.AddWithValue("HourlyLeave",Mw.HourlyLeave);
                Cmd.Parameters.AddWithValue("Absence",Mw.Absence);
                Cmd.Parameters.AddWithValue("OverTime",Mw.OverTime);
                Cmd.Parameters.AddWithValue("NightWork", Mw.NightWork);
                Cmd.Parameters.AddWithValue("HolidayWork", Mw.HolidayWork);
                Cmd.Parameters.AddWithValue("Advance", Mw.Advance);
                Cmd.Parameters.AddWithValue("Loan", Mw.Loan);
                Cmd.Parameters.AddWithValue("Bonus", Mw.Bonus);
                Cmd.Parameters.AddWithValue("Buy", Mw.Buy);
                Cmd.Parameters.AddWithValue("OtherAddition", Mw.OtherAddition);
                Cmd.Parameters.AddWithValue("OtherDiscount", Mw.OtherDiscount);
                Cmd.Parameters.AddWithValue("OvertimeLastYear", Mw.OvertimeLastYear);
                Cmd.Parameters.AddWithValue("OvertimeLastYearRlsPerHour", Mw.OvertimeLastYearRlsPerHour);
                Cmd.Parameters.AddWithValue("Detail", Mw.Detail);
                return Global.DB.ExecuteNonQuery(Cmd);
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
                Cmd.CommandText = "[Sl].[UspDeleteWorkPerMonth]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("ID", ID);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }

        }
        public int Update(ClsMonthlyWork Mw,int ID)
        {
            try
            {
                if (Mw.Person.Exists == false)
                {
                    throw new Exception("پرسنل مورد نظر نا معتبر است");
                }
                if (Mw.MonthOfSalary.Exists == false)
                {
                    throw new Exception(" ماه حقوقی نا معتبر است");
                }
                Cmd.CommandText = "[Sl].[UspUpdateWorkPerMonth]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("ID", ID);
                Cmd.Parameters.AddWithValue("ID_Company", Mw.ID_Company);
                Cmd.Parameters.AddWithValue("ID_Person", Mw.Person.ID);
                Cmd.Parameters.AddWithValue("ID_MonthOfSalary", Mw.MonthOfSalary.ID);
                Cmd.Parameters.AddWithValue("DayCount", Mw.DayCount);
                Cmd.Parameters.AddWithValue("DailyMission", Mw.DailyMission);
                Cmd.Parameters.AddWithValue("HourlyMission", Mw.HourlyMission);
                Cmd.Parameters.AddWithValue("DailyLeave", Mw.DailyLeave);
                Cmd.Parameters.AddWithValue("HourlyLeave", Mw.HourlyLeave);
                Cmd.Parameters.AddWithValue("Absence", Mw.Absence);
                Cmd.Parameters.AddWithValue("OverTime", Mw.OverTime);
                Cmd.Parameters.AddWithValue("NightWork", Mw.NightWork);
                Cmd.Parameters.AddWithValue("HolidayWork", Mw.HolidayWork);
                Cmd.Parameters.AddWithValue("Advance", Mw.Advance);
                Cmd.Parameters.AddWithValue("Loan", Mw.Loan);
                Cmd.Parameters.AddWithValue("Bonus", Mw.Bonus);
                Cmd.Parameters.AddWithValue("Buy", Mw.Buy);
                Cmd.Parameters.AddWithValue("OtherAddition", Mw.OtherAddition);
                Cmd.Parameters.AddWithValue("OtherDiscount", Mw.OtherDiscount);
            Cmd.Parameters.AddWithValue("OvertimeLastYear", Mw.OvertimeLastYear);
            Cmd.Parameters.AddWithValue("OvertimeLastYearRlsPerHour", Mw.OvertimeLastYearRlsPerHour);
            Cmd.Parameters.AddWithValue("Detail", Mw.Detail);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
    
        public DataTable GetMonthlyWork(long ID_Person, byte? ID_Company, long? ID_Kargah)//1
        {
            try 
	        {
                return _GetMonthlyWork(ID_Person, null, null, null, null,null, ID_Company, ID_Kargah);
	        }
	        catch (Exception ex)
	        {
		
		        throw ex ;
	        }
        }
        public DataTable GetMonthlyWork(short Year, byte? ID_Company, long? ID_Kargah)//2
        {
            try
            {
                return _GetMonthlyWork(null, null, null, null, null,null, ID_Company, ID_Kargah);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year, byte? ID_Company, long? ID_Kargah)//3
        {
            try
            {
                return _GetMonthlyWork(ID_Person, Year, null, null, null,null, ID_Company, ID_Kargah);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year, byte FromDate, byte ToDate, short? ID_MahaleKhedmat, byte? ID_Company, long? ID_Kargah)//4
        {
            try
            {
                return _GetMonthlyWork(ID_Person, Year, FromDate, ToDate, null,ID_MahaleKhedmat, ID_Company, ID_Kargah);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(short Year, byte FromDate, byte ToDate, short? ID_MahaleKhedmat, byte? ID_Company, long? ID_Kargah)//5
        {
            try
            {
                return _GetMonthlyWork(null, Year, FromDate, ToDate, null, ID_MahaleKhedmat, ID_Company, ID_Kargah);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year, byte FromDate, byte ToDate, byte? ID_Company, long? ID_Kargah)//6
    {
        try
        {
            return _GetMonthlyWork(ID_Person, Year, FromDate, ToDate, null,null,ID_Company,ID_Kargah);
        }
        catch (Exception ex)
        {

            throw ex ;
        }
    }
        public DataTable GetMonthlyWork(short Year, byte FromDate, byte ToDate, byte? ID_Company, long? ID_Kargah)//7
    {
        try
        {
            return _GetMonthlyWork(null, Year, FromDate, ToDate, null,null, ID_Company, ID_Kargah);
        }
        catch (Exception ex)
        {

            throw ex ;
        }
    }
        public DataTable GetMonthlyWork(int ID, byte? ID_Company, long? ID_Kargah)//8
        {
            try
            {
                return _GetMonthlyWork(null, null, null, null, ID,null,ID_Company,ID_Kargah);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, byte? ID_Company)//9
        {
            try
            {
                return _GetMonthlyWork(ID_Person, null, null, null, null, null, ID_Company, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(short Year, byte? ID_Company)//10
        {
            try
            {
                return _GetMonthlyWork(null, null, null, null, null, null, ID_Company, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year, byte? ID_Company)//11
        {
            try
            {
                return _GetMonthlyWork(ID_Person, Year, null, null, null, null, ID_Company, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year, byte FromDate, byte ToDate, short? ID_MahaleKhedmat, byte? ID_Company)//12
        {
            try
            {
                return _GetMonthlyWork(ID_Person, Year, FromDate, ToDate, null, ID_MahaleKhedmat, ID_Company, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(short Year, byte FromDate, byte ToDate, short? ID_MahaleKhedmat, byte? ID_Company)//13
        {
            try
            {
                return _GetMonthlyWork(null, Year, FromDate, ToDate, null, ID_MahaleKhedmat, ID_Company, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year, byte FromDate, byte ToDate, byte? ID_Company)//14
        {
            try
            {
                return _GetMonthlyWork(ID_Person, Year, FromDate, ToDate, null, null,ID_Company, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(short Year, byte FromDate, byte ToDate, byte? ID_Company)//15
        {
            try
            {
                return _GetMonthlyWork(null, Year, FromDate, ToDate, null, null, ID_Company, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(int ID, byte? ID_Company)//16
        {
            try
            {
                return _GetMonthlyWork(null, null, null, null, ID, null, ID_Company, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person)//17
        {
            try
            {
                return _GetMonthlyWork(ID_Person, null, null, null, null, null, null, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(short Year)//18
        {
            try
            {
                return _GetMonthlyWork(null, null, null, null, null, null, null, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year)//19
        {
            try
            {
                return _GetMonthlyWork(ID_Person, Year, null, null, null, null, null, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year, byte FromDate, byte ToDate, short? ID_MahaleKhedmat)//20
        {
            try
            {
                return _GetMonthlyWork(ID_Person, Year, FromDate, ToDate, null, ID_MahaleKhedmat, null, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(short Year, byte FromDate, byte ToDate, short? ID_MahaleKhedmat)//21
        {
            try
            {
                return _GetMonthlyWork(null, Year, FromDate, ToDate, null, ID_MahaleKhedmat, null, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(long ID_Person, short Year, byte FromDate, byte ToDate)//22
        {
            try
            {
                return _GetMonthlyWork(ID_Person, Year, FromDate, ToDate, null, null, null, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(short Year, byte FromDate, byte ToDate)//23
        {
            try
            {
                return _GetMonthlyWork(null, Year, FromDate, ToDate, null, null, null, null);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetMonthlyWork(int ID)//24
    {
        try
        {
            return _GetMonthlyWork(null, null, null, null, ID, null, null, null);
        }
        catch (Exception ex)
        {

            throw ex ;
        }
    }
    private DataTable _GetMonthlyWork(long? ID_Person, short? Year, byte? FromDate, byte? ToDate, int? ID , short? ID_MahaleKhedmat, byte? ID_Company, long? ID_Kargah)
        {
            try
            {
                Cmd.CommandText = "[Sl].[UspGetMonthlyWork]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                Cmd.Parameters.AddWithValue("@ID", ID);
                Cmd.Parameters.AddWithValue("@Year", Year);
                Cmd.Parameters.AddWithValue("@StartMonth", FromDate);
                Cmd.Parameters.AddWithValue("@EndMonth", ToDate);
                Cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat);
                Cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                Cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
            return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }
    }

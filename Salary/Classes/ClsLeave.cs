using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Personnely;
namespace Salary
{
    class ClsLeave
    {
        SqlCommand Cmd = new SqlCommand();
        public long? ID { get; set; }
        public long? ID_Personel { get; set; }
        public int Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public byte Type { get; set; }
        public DataTable GetAllTypes()
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspGetLeaveType]";
                Cmd.Parameters.Clear();
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public int DeleteType(int IDType)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspDeleteLeaveType]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", IDType);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public int AddLeave(ClsLeave leave)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspAddHourlyLeave]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_Personel", leave.ID_Personel);
                Cmd.Parameters.AddWithValue("@Date", leave.Date);
                Cmd.Parameters.AddWithValue("@StartTime", leave.StartTime);
                Cmd.Parameters.AddWithValue("@EndTime", leave.EndTime);
                Cmd.Parameters.AddWithValue("@ID_Type", leave.Type);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public int AddLeaveType(String Name)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspAddHourlyLeaveType]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Name", Name);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public DataTable GetAllLeave(ClsPersonel Pr, int Date1, int Date2)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspGetAllLeave]";
                Cmd.Parameters.Clear();
                if (Pr.Exists)
                {
                    Cmd.Parameters.AddWithValue("@ID_Personel", Pr.ID);
                }
                Cmd.Parameters.AddWithValue("@Date1", Date1);
                Cmd.Parameters.AddWithValue("@Date2", Date2);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public DataTable GetLeave(long LeaveID)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspGetLeave]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", LeaveID);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public int Delete(long LeaveID)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspDeleteHourlyLeave]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", LeaveID);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public int UpdateLeave(ClsLeave Leave)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspUpdateHourlyLeave]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_Leave", Leave.ID);
                Cmd.Parameters.AddWithValue("@Date", Leave.Date);
                Cmd.Parameters.AddWithValue("@StartTime", Leave.StartTime);
                Cmd.Parameters.AddWithValue("@EndTime", Leave.EndTime);
                Cmd.Parameters.AddWithValue("@ID_Type", Leave.Type);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public int SetConfirm(Boolean Value, DataTable Items)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspUpdateConfirmHourlyLeave]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Items", Items);
                Cmd.Parameters.AddWithValue("@Value", Value);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public int UpdateLeaveType(DataTable Items)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspUpdateLeaveType]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Items", Items);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        public   ClsLeave getOverlap(ClsLeave Leave)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspGetOverlapHourlyLeave]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_Personel", Leave.ID_Personel);
                Cmd.Parameters.AddWithValue("@PersianDate", Leave.Date);
                Cmd.Parameters.AddWithValue("@FromTime", Leave.StartTime);
                Cmd.Parameters.AddWithValue("@ToTime", Leave.EndTime);
                Cmd.Parameters.AddWithValue("@ID", Leave.ID);
                DataTable DtLeave = new DataTable();
                DtLeave = Global.DB.FillDataTable(Cmd);
                ClsLeave ReturnLeave = new ClsLeave();
                if (DtLeave.Rows.Count > 0)
	                {
                    
                        ReturnLeave.ID  = (long)DtLeave.Rows[0]["ID_Personel"];
                        ReturnLeave.Date = (int)DtLeave.Rows[0]["Date"];
                        ReturnLeave.StartTime = DtLeave.Rows[0]["FromTime"].ToString();
                        ReturnLeave.EndTime = DtLeave.Rows[0]["Totime"].ToString();
                        ReturnLeave.Type = (byte)DtLeave.Rows[0]["ID_Type"];
	                }
                else
                {
                    ReturnLeave.ID = null;
                }
                return ReturnLeave;

            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public int DoSync(int StartDate, int EndDate,string PrCode  = null)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspReadHourlyMissionFromPersonWork]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@PrCode",  PrCode);
                Cmd.Parameters.AddWithValue("@StartDate", StartDate);
                Cmd.Parameters.AddWithValue("@EndDate", EndDate);
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
   
        }
    }
}

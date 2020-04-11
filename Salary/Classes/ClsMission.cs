using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data ;
using System.Data.Sql;
using System.Data.SqlClient ;
using Personnely;
namespace Salary
{
    class ClsMission
    {
        DAL.ClsDataAccessLayer DB = new DAL.ClsDataAccessLayer();
        SqlCommand Cmd  = new SqlCommand() ;
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
                Cmd.CommandText = "[Pr].[UspGetMissionType]";
                Cmd.Parameters.Clear();
                return DB.FillDataTable(Cmd);
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
                Cmd.CommandText = "[Pr].[UspDeleteMissionType]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", IDType);
                return DB.ExecuteNonQuery(Cmd);
	        }
	        catch (Exception ex)
	        {
		        throw ex ;
	        }
        }
        public int AddMission( ClsMission Miss)
        {
            try 
	        {	        
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = "[Pr].[UspAddHourlyMission]";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@ID_Personel",Miss.ID_Personel);
            Cmd.Parameters.AddWithValue("@Date",Miss.Date);
            Cmd.Parameters.AddWithValue("@StartTime",Miss.StartTime);
            Cmd.Parameters.AddWithValue("@EndTime",Miss.EndTime);
            Cmd.Parameters.AddWithValue("@ID_Type",Miss.Type);
            return DB.ExecuteNonQuery(Cmd);
	        }
	        catch (Exception ex)
	        {
		
		        throw ex ;    
	        }
        }
        public int AddMissionType(String Name)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspAddHourlyMissionType]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Name", Name);
                return DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }
        public DataTable GetAllMission(ClsPersonel Pr, int Date1 , int Date2)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspGetAllMission]";
                Cmd.Parameters.Clear();
                if (Pr.Exists)
                {
                    Cmd.Parameters.AddWithValue("@ID_Personel", Pr.ID);
                }
                Cmd.Parameters.AddWithValue("@Date1", Date1);
                Cmd.Parameters.AddWithValue("@Date2", Date2);
                return DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {   
                throw ex ;
            }
        }
        public DataTable GetMission(long MissionID)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspGetMission]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", MissionID);
                return DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public int Delete(long MissionID)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspDeleteHourlyMission]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", MissionID);
                return DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            { 
                throw ex ;
            }
        }
        public int UpdateMission(ClsMission Miss)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspUpdateHourlyMission]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_Mission", Miss.ID);
                Cmd.Parameters.AddWithValue("@Date", Miss.Date);
                Cmd.Parameters.AddWithValue("@StartTime", Miss.StartTime);
                Cmd.Parameters.AddWithValue("@EndTime", Miss.EndTime);
                Cmd.Parameters.AddWithValue("@ID_Type", Miss.Type);
                return DB.ExecuteNonQuery(Cmd);
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
                Cmd.CommandText = "[Pr].[UspUpdateConfirmHourlyMission]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Items", Items);
                Cmd.Parameters.AddWithValue("@Value", Value);
                return DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }
        public int UpdateMissionType(DataTable Items)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspUpdateMissionType]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@Items", Items);
                return DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }

        }
        public  ClsMission getOverlap(ClsMission Mission)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspGetOverlapHourlyMission]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_Personel", Mission.ID_Personel);
                Cmd.Parameters.AddWithValue("@PersianDate", Mission.Date);
                Cmd.Parameters.AddWithValue("@FromTime", Mission.StartTime);
                Cmd.Parameters.AddWithValue("@ToTime", Mission.EndTime);
                Cmd.Parameters.AddWithValue("@ID", Mission.ID);
                DataTable DtMission = new DataTable();
                DtMission = DB.FillDataTable(Cmd);
                ClsMission ReturnMiss = new ClsMission();
                if (DtMission.Rows.Count > 0)
	                {
                    
                        ReturnMiss.ID  = (long)DtMission.Rows[0]["ID_Personel"];
                        ReturnMiss.Date = (int)DtMission.Rows[0]["Date"];
                        ReturnMiss.StartTime = DtMission.Rows[0]["FromTime"].ToString();
                        ReturnMiss.EndTime = DtMission.Rows[0]["Totime"].ToString();
                        ReturnMiss.Type = (byte)DtMission.Rows[0]["ID_Type"];
	                }
                else
                {
                    ReturnMiss.ID = null;
                }
                return ReturnMiss;

            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }

        public int DoSync(int StartDate, int EndDate, string PrCode = null)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspReadHourlyLeaveFromPersonWork]";
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@PrCode", PrCode);
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

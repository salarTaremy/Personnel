using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Personnely;
namespace Salary
{
    class ClsDailyMission
    {
        public long? ID { get; set; }
        public int FromDate { get; set; }
        public int ToDate { get; set; }
        public ClsPersonel Person { get; set; }
        public Byte ID_Type { get; set; }
        public bool IsConfirm { get; set; }
        SqlCommand Cmd = new SqlCommand();
        public DataTable GetAll(Personnely.ClsPersonel Person, int FromDate, int ToDate)
        {
            try
            {
                Cmd.CommandText = "[Pr].[UspGetAllDailyMission]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                if (Person.Exists)
                {
                    Cmd.Parameters.AddWithValue("@ID_Personel", Person.ID);
                }
                Cmd.Parameters.AddWithValue("@FromDate", FromDate);
                Cmd.Parameters.AddWithValue("@Todate", ToDate);
                return Global.DB.FillDataTable(Cmd);
            }
            catch (Exception ex)
            {   
                throw ex ;
            }
        }
        public int Save(ClsDailyMission Dm)
        {
            try
            {
                if (Dm.Person.Exists ==  false)
                {
                    Exception Ex = new Exception( "personel Not Exist") ;
                    throw Ex;
                }
                Cmd.CommandText = "[Pr].[UspSaveDailyMission]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_Personel", Dm.Person.ID);
                Cmd.Parameters.AddWithValue("@FromDate",Dm.FromDate );
                Cmd.Parameters.AddWithValue("@ToDate", Dm.ToDate);
                Cmd.Parameters.AddWithValue("@ID_Type", Dm.ID_Type);
                if (Dm.ID != null)
                {
                    Cmd.Parameters.AddWithValue("@ID", Dm.ID);
                }
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {   
                throw ex ;
            }
        }
        public ClsDailyMission Get(long? ID)
        {
            try
            {
                Cmd.CommandText = "[Pr].[UspGetDailyMission]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", ID);
                DataTable DT_DailyMission = new DataTable() ;
                DT_DailyMission = Global.DB.FillDataTable(Cmd);
                ClsDailyMission ReturnClsDailyMission = new ClsDailyMission();
                if (DT_DailyMission.Rows.Count == 0 )
	                {
		                return null ;
	                }
                ReturnClsDailyMission.ID =   (long)DT_DailyMission.Rows[0]["ID"] ;
                ReturnClsDailyMission.Person =  new  ClsPersonel( DT_DailyMission.Rows[0]["ID_Personel"].ToString()) ;
                ReturnClsDailyMission.FromDate =  (int)DT_DailyMission.Rows[0]["FromDate"] ;
                ReturnClsDailyMission.ToDate = (int)DT_DailyMission.Rows[0]["ToDate"];
                ReturnClsDailyMission.ID_Type = (byte)DT_DailyMission.Rows[0]["ID_Type"];
                ReturnClsDailyMission.IsConfirm = (bool)DT_DailyMission.Rows[0]["IsConfirm"];
                return ReturnClsDailyMission;
            }
            catch (Exception ex)
            {
                throw ex ;
            }

        }
        public int Delete(long ID)
        {
            try
            {
                Cmd.CommandText = "[Pr].[UspDeleteDailyMission]";
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
        public int SetConfirm(Boolean Value, DataTable Items)
        {
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[Pr].[UspUpdateConfirmDailyMission]";
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
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Personnely;
namespace Salary
{
    class ClsDailyLeave
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
                Cmd.CommandText = "[Pr].[UspGetAllDailyLeave]";
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
        public int Save(ClsDailyLeave Dm)
        {
            try
            {
                if (Dm.Person.Exists == false)
                {
                    Exception Ex = new Exception("personel Not Exist");
                    throw Ex;
                }
                Cmd.CommandText = "[Pr].[UspSaveDailyLeave]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID_Personel", Dm.Person.ID);
                Cmd.Parameters.AddWithValue("@FromDate", Dm.FromDate);
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
        public ClsDailyLeave Get(long? ID)
        {
            try
            {
                Cmd.CommandText = "[Pr].[UspGetDailyLeave]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Clear();
                Cmd.Parameters.AddWithValue("@ID", ID);
                DataTable DT_DailyLeave = new DataTable();
                DT_DailyLeave = Global.DB.FillDataTable(Cmd);
                ClsDailyLeave ReturnClsDailyLeave = new ClsDailyLeave();
                if (DT_DailyLeave.Rows.Count == 0)
                {
                    return null;
                }
                ReturnClsDailyLeave.ID = (long)DT_DailyLeave.Rows[0]["ID"];
                ReturnClsDailyLeave.Person = new ClsPersonel(DT_DailyLeave.Rows[0]["ID_Personel"].ToString());
                ReturnClsDailyLeave.FromDate = (int)DT_DailyLeave.Rows[0]["FromDate"];
                ReturnClsDailyLeave.ToDate = (int)DT_DailyLeave.Rows[0]["ToDate"];
                ReturnClsDailyLeave.ID_Type = (byte)DT_DailyLeave.Rows[0]["ID_Type"];
                ReturnClsDailyLeave.IsConfirm = (bool)DT_DailyLeave.Rows[0]["IsConfirm"];
                return ReturnClsDailyLeave;
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
                Cmd.CommandText = "[Pr].[UspDeleteDailyLeave]";
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
                Cmd.CommandText = "[Pr].[UspUpdateConfirmDailyLeave]";
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

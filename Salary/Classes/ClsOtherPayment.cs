using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public class ClsOtherPayment
    {
        public byte ID { get; set; }
        public string FormulName { get; set; }
        public string Formula { get; set; }
        public byte ID_Type { get; set; }
        public DataTable GetAllFormula()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllFormulaEydiSanavat]";
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetAllFormula(byte ID_Type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllFormulaEydiSanavat]";
                cmd.Parameters.AddWithValue("@ID_Type", ID_Type);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetFormula(byte ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllFormulaEydiSanavat]";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetAllFormulTypes()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT ID, Name FROM Sl.FormulType";
                cmd.CommandType = CommandType.Text;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetPriceWithFormula(byte ID_Formul, long ID_Person, byte ID_Company , int DayCount  ,int Year)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetEydiSanavatWithFormula]";
                cmd.Parameters.AddWithValue("@ID_Formul", ID_Formul);
                cmd.Parameters.AddWithValue("@ID_PR", ID_Person);
                //cmd.Parameters.AddWithValue("@DateA", DateA);
                //cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@Year", Year);
                cmd.Parameters.AddWithValue("@ID_Company", @ID_Company);
                cmd.Parameters.AddWithValue("@DayCount", DayCount);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable Dt = Global.DB.FillDataTable(cmd);
                return Dt; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllField()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetPaymentFormulField]";
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Boolean AddFormula(ClsOtherPayment Pym)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAddEditPaymentFormula]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Formula", Pym.Formula);
                cmd.Parameters.AddWithValue("@FormulName", Pym.FormulName);
                cmd.Parameters.AddWithValue("@ID_Type", Pym.ID_Type);
                int RowAffect = Global.DB.ExecuteNonQuery(cmd);
                if (RowAffect > 0)
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
        public Boolean EditFormula(ClsOtherPayment Pym)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAddEditPaymentFormula]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Pym.ID);
                cmd.Parameters.AddWithValue("@Formula", Pym.Formula);
                cmd.Parameters.AddWithValue("@FormulName", Pym.FormulName);
                cmd.Parameters.AddWithValue("@ID_Type", Pym.ID_Type);
                int RowAffect = Global.DB.ExecuteNonQuery(cmd);
                if (RowAffect > 0)
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

        public DataTable GetValidPersonList(byte ID_Company, long ID_Kargah, short ID_MonthA, short ID_MonthB)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspOtherPaymentGetValidPersonList]";
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                cmd.Parameters.AddWithValue("@ID_MonthA", ID_MonthA);
                cmd.Parameters.AddWithValue("@ID_MonthB", ID_MonthB);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Delete(int ID_EydiSanavat)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[sl].[UspDeleteEydiSanavat]";
                cmd.Parameters.AddWithValue("@ID_EydiSanavat", ID_EydiSanavat);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteItem(long ID_EydiSanavatDetail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[sl].[UspDeleteEydiSanavatDetail]";
                cmd.Parameters.AddWithValue("@ID_EydiSanavatDetail", ID_EydiSanavatDetail);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetEydiSanavat(int DateA, int DateB ,byte ID_Type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[sl].[UspGetEydiSanavat]";
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ID_Type", ID_Type);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetEydiSanavatDetail(int ID_EydiSanavat )
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[sl].[UspGetEydiSanavatDetail]";
                cmd.Parameters.AddWithValue("@ID_EydiSanavat", ID_EydiSanavat);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Boolean DeleteFormula(byte ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete Sl.EydiSanavatFormula Where ID = @ID  ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", ID);
                int RowAffect = Global.DB.ExecuteNonQuery(cmd);
                if (RowAffect > 0)
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
    }
}

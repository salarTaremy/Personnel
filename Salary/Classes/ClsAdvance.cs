using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Salary
{
    class ClsAdvance
    {
        public ClsAdvance()
        {

        }
        public ClsAdvance(long NotKargah )
        {
            this.NotKargah = NotKargah;
        }
        public long? NotKargah { get; set; }
        public byte ID { get; set; }
        public string FormulName { get; set; }
        public string Formula { get; set; }
        public int Date { get; set; }
        public long ID_Person { get; set; }
        public long Amount { get; set; }
        public bool IsManual { get; set; }
        public string  Detail { get; set; }
        public bool AddAdvance(ClsAdvance Adv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAddAdvance]";
                cmd.Parameters.AddWithValue("@Date", Adv.Date);
                cmd.Parameters.AddWithValue("@ID_Person", Adv.ID_Person);
                cmd.Parameters.AddWithValue("@Amount", Adv.Amount);
                cmd.Parameters.AddWithValue("@IsManual", Adv.IsManual);
                cmd.Parameters.AddWithValue("@Detail", Adv.Detail);
                cmd.CommandType = CommandType.StoredProcedure;
                return Convert.ToBoolean( Global.DB.ExecuteNonQuery(cmd));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetAll(short ID_Month , long ID_Person)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvance]";
                cmd.Parameters.AddWithValue("@ID_Month", ID_Month);
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAll(short ID_Month)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvance]";
                cmd.Parameters.AddWithValue("@ID_Month", ID_Month);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Overload1
        public DataTable GetValidPersonList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAdvanceGetValidPersonList]";
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Overload1
        public DataTable GetValidPersonList( byte ID_Company)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAdvanceGetValidPersonList]";
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetValidPersonList(byte ID_Company , string ValidKargah)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAdvanceGetValidPersonList]";
                cmd.Parameters.AddWithValue("@ID_Company"   ,ID_Company);
                cmd.Parameters.AddWithValue("@ValidKargah"  ,ValidKargah);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllWithDetail(int DateA, int DateB , bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllWithDetail(byte ID_Company ,int DateA, int DateB, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//0
        public DataTable GetAllWithDetail(byte ID_Company, short ID_MahaleKhedmat, int DateA, int DateB, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//1
        public DataTable GetAllWithDetail(byte ID_Company ,long ID_Kargah, int DateA, int DateB, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//2
        public DataTable GetAllWithDetail(byte ID_Company, long ID_Kargah, short ID_MahaleKhedmat, int DateA, int DateB, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//3
        public DataTable GetAllWithDetail(int DateA, int DateB, long ID_Person, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//4
        public DataTable GetAllWithDetail(byte ID_Company ,  int DateA, int DateB, long ID_Person, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//5
        public DataTable GetAllWithDetail(byte ID_Company, long ID_Kargah, int DateA, int DateB, long ID_Person, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//6
        public DataTable GetAllWithDetail(byte ID_Company, long ID_Kargah, short ID_MahaleKhedmat, int DateA, int DateB, long ID_Person, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//7
        public DataTable GetAllWithDetail(int DateA, int DateB, short IDMonthOfSalary, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//8
        public DataTable GetAllWithDetail(byte ID_Company ,  int DateA, int DateB, short IDMonthOfSalary, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//9
        public DataTable GetAllWithDetail(byte ID_Company, long ID_Kargah, int DateA, int DateB, short IDMonthOfSalary, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //10
        public DataTable GetAllWithDetail(byte ID_Company, long ID_Kargah, short ID_MahaleKhedmat, int DateA, int DateB, short IDMonthOfSalary, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //11
        public DataTable GetAllWithDetail(int DateA, int DateB, short IDMonthOfSalary, long ID_Person, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//12
        public DataTable GetAllWithDetail(byte ID_Company,  int DateA, int DateB, short IDMonthOfSalary, long ID_Person, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//13
        public DataTable GetAllWithDetail(byte ID_Company, long ID_Kargah, int DateA, int DateB, short IDMonthOfSalary, long ID_Person, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//14
        public DataTable GetAllWithDetail(byte ID_Company, long ID_Kargah , short ID_MahaleKhedmat, int DateA, int DateB, short IDMonthOfSalary, long ID_Person, bool ShowGheyrBazneshasteh = true, bool ShowBazneshasteh = true)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllAdvanceWithDetail]";
                cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                cmd.Parameters.AddWithValue("@ID_Person", ID_Person);
                cmd.Parameters.AddWithValue("@DateA", DateA);
                cmd.Parameters.AddWithValue("@DateB", DateB);
                cmd.Parameters.AddWithValue("@ShowGheyrBazneshasteh", ShowGheyrBazneshasteh);
                cmd.Parameters.AddWithValue("@ShowBazneshasteh", ShowBazneshasteh);
                cmd.Parameters.AddWithValue("@ID_Company", ID_Company);
                cmd.Parameters.AddWithValue("@ID_Kargah", ID_Kargah);
                cmd.Parameters.AddWithValue("@ID_MahaleKhedmat", ID_MahaleKhedmat);
                if (NotKargah != null)
                {
                    cmd.Parameters.AddWithValue("@ID_NotKargah", this.NotKargah);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//15
        public int AddGroup(DataTable Dt , int Date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[SL].[UspAddAdvanceGroup]";
                cmd.Parameters.AddWithValue("@Items", Dt);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Delete(List<long> IDList)
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt.Columns.Add("Value", typeof(long));
                foreach (var item in IDList)
                {
                    DataRow Dr = Dt.NewRow();
                    Dr["Value"] = item;
                    Dt.Rows.Add(Dr);
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspDeleteAdvance]";
                cmd.Parameters.AddWithValue("@IDList", Dt);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.ExecuteNonQuery(cmd);
    }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        public DataTable GetAllField()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAdvanceField]";
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetAllFormula()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllFormula]";
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable GetAllFormula(byte ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAllFormula]";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public long GetPriceWithFormula(string Formul, long ID_Person , int Date, byte ID_Company)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspGetAdvanceWithFormula]";
                cmd.Parameters.AddWithValue("@StrFormul", Formul);
                cmd.Parameters.AddWithValue("@ID_PR", ID_Person);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@ID_Company", @ID_Company);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable Dt = Global.DB.FillDataTable(cmd);
                if (Dt.Rows.Count == 0)
                {
                    return 0;
                }
                return long.Parse(Dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Boolean AddFormula(ClsAdvance Adv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAddEditAdvanceFormula]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Formula", Adv.Formula);
                cmd.Parameters.AddWithValue("@FormulName", Adv.FormulName);
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

                throw ex ;
            }
        }
        public Boolean EditFormula(ClsAdvance Adv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAddEditAdvanceFormula]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Adv.ID);
                cmd.Parameters.AddWithValue("@Formula", Adv.Formula);
                cmd.Parameters.AddWithValue("@FormulName", Adv.FormulName);
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
        public Boolean DeleteFormula(byte ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete Sl.AdvanceFormula Where ID = @ID  ";
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
        public  DataTable GetBlackList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[UspAdvanceGetBlackList]";
                cmd.CommandType = CommandType.StoredProcedure;
                return Global.DB.FillDataTable(cmd);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public int AddBlackList(DataTable ID_Persons)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[Sl].[AdvanceAddBlackList]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Persons", ID_Persons);
                int RowAffect = Global.DB.ExecuteNonQuery(cmd);
                return RowAffect;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Salary
{
    class ClsLoan
    {
        public int ID { get; set; }
        public long ID_Person { get; set; }
        public byte ID_Type { get; set; }
        public int BorrowingDate { get; set; }
        public short StartYear { get; set; }
        public byte StartMonth { get; set; }
        public long TotalAmount { get; set; }
        public bool IsActive { get; set; }
        public string Warranty { get; set; }
        public string Detail { get; set; }
        public List<LoanItems> items { get; set; }

        public ClsLoan()
        {
            this.items = new List<LoanItems>() ;
        }
        public Boolean Update(ClsLoan Loan , DataTable DtItems)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspEditLoan]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("ID_Loan", Loan.ID);
                Cmd.Parameters.AddWithValue("ID_Type", Loan.ID_Type);
                Cmd.Parameters.AddWithValue("BorrowingDate", Loan.BorrowingDate);
                Cmd.Parameters.AddWithValue("TotalAmount", Loan.TotalAmount);
                Cmd.Parameters.AddWithValue("IsActive", Loan.IsActive);
                Cmd.Parameters.AddWithValue("Warranty", Loan.Warranty);
                Cmd.Parameters.AddWithValue("Detail", Loan.Detail);
                Cmd.Parameters.AddWithValue("item", DtItems);
                int Result =Global.DB.ExecuteNonQuery(Cmd);
                return Convert.ToBoolean(Result);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public int Save( ClsLoan Loan)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspAddLoan]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@ID_Person",Loan.ID_Person);
                Cmd.Parameters.AddWithValue("@ID_Type", Loan.ID_Type);
                Cmd.Parameters.AddWithValue("@BorrowingDate", Loan.BorrowingDate);
                Cmd.Parameters.AddWithValue("@StartYear", Loan.StartYear);
                Cmd.Parameters.AddWithValue("@StartMonth", Loan.StartMonth);
                Cmd.Parameters.AddWithValue("@TotalAmount", Loan.TotalAmount);
                Cmd.Parameters.AddWithValue("@IsActive", Loan.IsActive);
                Cmd.Parameters.AddWithValue("@Warranty", Loan.Warranty);
                Cmd.Parameters.AddWithValue("@Detail", Loan.Detail);
                Cmd.Parameters.AddWithValue("@Items", this.ItemsToDataTable());
                return Global.DB.ExecuteNonQuery(Cmd);
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        public DataTable ItemsToDataTable()
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt.Columns.Add("Priority", typeof(short));
                Dt.Columns.Add("Amount", typeof(long));
                DataRow Dr;
                foreach (var item in this.items)
                {
                    Dr = Dt.NewRow();
                    Dr["Priority"] = item.Priority;
                    Dr["Amount"] = item.Amount;
                    Dt.Rows.Add(Dr);
                }
                return Dt;
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        public DataTable GetAllTypes()
        {
            try
            {
                DataTable ReturnDt = new DataTable();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspGetLoanTypes]";
                Cmd.CommandType = CommandType.StoredProcedure;
                ReturnDt = Global.DB.FillDataTable(Cmd);
                return ReturnDt;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public DataTable GetAllLoan() //OverLoad0
        {
            try
            {
                DataTable ReturnDt = new DataTable();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspGetAllLoan]";
                Cmd.CommandType = CommandType.StoredProcedure;
                ReturnDt = Global.DB.FillDataTable(Cmd);
                return ReturnDt;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public DataTable GetAllLoan(long ID_Person) //OverLoad1
        {
            try
            {
                DataTable ReturnDt = new DataTable();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspGetAllLoan]";
                Cmd.Parameters.AddWithValue("ID_Person", ID_Person);
                Cmd.CommandType = CommandType.StoredProcedure;
                ReturnDt = Global.DB.FillDataTable(Cmd);
                return ReturnDt;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public DataTable GetAllLoan(int ID_Loan) //OverLoad2
        {
            try
            {
                DataTable ReturnDt = new DataTable();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspGetAllLoan]";
                Cmd.Parameters.AddWithValue("ID_Loan", ID_Loan);
                Cmd.CommandType = CommandType.StoredProcedure;
                ReturnDt = Global.DB.FillDataTable(Cmd);
                return ReturnDt;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public DataTable GetLoanDetail(int ID_Loan)
        {
            try
            {
                DataTable ReturnDt = new DataTable();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspGetLoanDetail]";
                Cmd.Parameters.AddWithValue("ID_Loan", ID_Loan);
                Cmd.CommandType = CommandType.StoredProcedure;
                ReturnDt = Global.DB.FillDataTable(Cmd);
                return ReturnDt;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public DataSet GetLoanAndAdvanceFull(long ID_Pr , byte ID_MonthOfSalary)
        {
            try
            {
                DataSet ReturnDs = new DataSet();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspGetLoanAndAdvance]";
                Cmd.Parameters.AddWithValue("@ID_Pr", ID_Pr);
                Cmd.Parameters.AddWithValue("@ID_MonthOfSalary", ID_MonthOfSalary);
                Cmd.CommandType = CommandType.StoredProcedure;
                ReturnDs = Global.DB.FillDataSet(Cmd);
                return ReturnDs;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public Boolean CheckOut(int ID_loan, short Priority)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand( );
                Cmd.CommandText = "[Sl].[UspSetCheckOutLoanDetail]";
                Cmd.Parameters.AddWithValue("ID_loan", ID_loan);
                Cmd.Parameters.AddWithValue("Priority", Priority);
                Cmd.CommandType = CommandType.StoredProcedure;
                return  Convert.ToBoolean(Global.DB.ExecuteNonQuery(Cmd));
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public Boolean CheckOut(int ID_loan, short Priority,Boolean CheckOutValue )
        {
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspSetCheckOutLoanDetail]";
                Cmd.Parameters.AddWithValue("ID_loan", ID_loan);
                Cmd.Parameters.AddWithValue("Priority", Priority);
                Cmd.Parameters.AddWithValue("CheckOutValue", CheckOutValue);
                Cmd.CommandType = CommandType.StoredProcedure;
                return Convert.ToBoolean(Global.DB.ExecuteNonQuery(Cmd));
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public Boolean DeleteLoan(int ID_loan)
        {
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[SL].[UspDeleteLoan]";
                Cmd.Parameters.AddWithValue("ID_loan", ID_loan);
                Cmd.CommandType = CommandType.StoredProcedure;
                return Convert.ToBoolean(Global.DB.ExecuteNonQuery(Cmd));
    }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
    }
    class LoanItems
    {
        public short Priority { get; set; }
        public long Amount { get; set; }
    }
}




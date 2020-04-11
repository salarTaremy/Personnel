using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Personnely;

namespace Salary.Classes
{
    class ClsInsurance
    {
        DataSet _InternalDS;
        public ClsInsurance(byte IDCompany, long? IDKargah, short IDMonthOfSalary, long? IDKargahEx = null) //1
        {
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspGetInsureList]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                Cmd.Parameters.AddWithValue("@IDCompany", IDCompany);
                Cmd.Parameters.AddWithValue("@IDKargahEx", IDKargahEx);
                if (IDKargah != null && IDKargah != 0)
                {
                    this.Kargah = new ClsPersonBase.Kargah(IDKargah);
                    Cmd.Parameters.AddWithValue("@IDKargah", IDKargah);
                }
                this._InternalDS = Global.DB.FillDataSet(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public ClsInsurance(byte IDCompany, long? IDKargah, short IDMahalKhedmat, short IDMonthOfSalary, long? IDKargahEx=null) //2
        {
            try
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "[Sl].[UspGetInsureList]";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IDMonthOfSalary", IDMonthOfSalary);
                Cmd.Parameters.AddWithValue("@IDMahalKhedmat", IDMahalKhedmat);
                Cmd.Parameters.AddWithValue("@IDCompany", IDCompany);
                Cmd.Parameters.AddWithValue("@IDKargahEx", IDKargahEx);
                if (IDKargah != null && IDKargah != 0 )
                {
                    this.Kargah = new ClsPersonBase.Kargah(IDKargah);
                    Cmd.Parameters.AddWithValue("@IDKargah", IDKargah);
                }

                this._InternalDS = Global.DB.FillDataSet(Cmd);
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        public ClsPersonBase.Kargah Kargah { get; }
        public DataTable List
        {
            get {
                if (_InternalDS.Tables.Count >0)
                {
                    return _InternalDS.Tables[0];
                }
                else
                {
                    return null;
                }
            }
                
            //set { myVar = value; }
        }







    }
    
}



using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.Classes
{
    public class ClsBank
    {
        public ClsBank()
        {
           
        }
        public DataTable GetAllAccontNo(int ID)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "SELECT  ID_Personel  , value FROM pr.Link_Personel_Property WHERE ID_Property = @ID ";
            Cmd.Parameters.AddWithValue("@ID", ID);
            DataTable Dt = Global.DB.FillDataTable(Cmd);
            return Dt;
        }
        public List<ClsAccontNO> GetAllAccontNoList(int ID)
        {
            DataTable Dt = GetAllAccontNo(ID);
            List<ClsAccontNO> Lst = new List<ClsAccontNO>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Lst.Add(new ClsAccontNO { ID_Person = (long)Dt.Rows[i]["ID_Personel"], AccontNo = Dt.Rows[i]["value"].ToString() });
            }
            return Lst;

        }
    }
}

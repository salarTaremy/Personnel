using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salary
{
    static class Global
    {
        public static UserControls.ClsDialog Dialog = new   UserControls.ClsDialog() ;
        public static DAL.ClsDataAccessLayer DB = new DAL.ClsDataAccessLayer();
        public static Common.ClsTools Tools = new Common.ClsTools();
        public static short SalMali = short.Parse(Common.SalMali.Value);
        
    }
}

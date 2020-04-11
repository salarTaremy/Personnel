using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Salery
namespace Salary
{
    public class ClsInformation
    {
        //public String Version
        //{
        //    get {
        //        string YY = "96";
        //        string MM = "06";
        //        string DD = "26";
        //        string HH = "10";
        //        string mmm = "30";
        //        return YY + MM + DD + HH + mmm;
        //    }
        //}
        public string Version()
        {
            string Ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Ver = Ver.Replace(".", null);
            return Ver;
        }
        
    }
}

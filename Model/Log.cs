using Dental_Managment.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Managment.Model
{
    public class Log
    {
        
        public static int? ClinicId { get; set; }
        public static string Email { get; set; }
        public static string LogReport { get; set; }
        public DateTime Date { get; set; }
        public static string AccountType { get; set; }

        public void SaveLog(string report)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Type",ActionType.Insert);
            prm[1] = new SqlParameter("@ClinicId", Log.ClinicId == null ? -1 : Log.ClinicId);
            prm[2] = new SqlParameter("@Email", Log.Email == null ? "" : Log.Email);
            prm[3] = new SqlParameter("@LogReport", report);
            prm[4] = new SqlParameter("@Date",DateTime.Now);
            GetData.Sp_ExecuteQurey("sp_Log", prm);
           
        }
        public static void Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Delete);
            prm[1] = new SqlParameter("@LogID",id);
            GetData.Sp_ExecuteQurey("sp_Log", prm);
        }

        public  DataTable Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
           return GetData.Sp_ExecuteQurey("sp_Log", prm);
        }
    }
}

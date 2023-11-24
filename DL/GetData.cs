using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Managment.DL
{
    public class GetData
    {
        static SqlConnection con = new SqlConnection("data source=DESKTOP-ND0BS6M\\SQLEXPRESS2019;initial catalog=db_Dental_clinic;integrated Security=true");

        public static void ExecuteQurey(string ProcedureName, SqlParameter[] prm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ProcedureName;
            cmd.Parameters.AddRange(prm);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable Sp_ExecuteQurey(string ProcedureName, SqlParameter[] prm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ProcedureName;
            cmd.Parameters.AddRange(prm);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       


    }
}

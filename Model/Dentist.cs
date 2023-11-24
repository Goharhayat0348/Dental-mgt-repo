using Dental_Managment.DL;
using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Managment.Model
{
    
    [Alias("dentists")]
    public class Dentist
    {
        
        public int DentistId { get; set; }

        public string Name { get; set; } 
        public string Phone { get; set; } 
        public string Address { get; set; } 
        public string Email { get; set; } 
        public DateTime DOB { get; set; } 
        public string Gender { get; set; } 
        
        public DateTime CreatedAt { get; set; }







        public void save(Dentist dentist)
        {
            SqlParameter[] prm = new SqlParameter[9];
            if (dentist.DentistId != 0)
            {
                prm[0] = new SqlParameter("@Type", ActionType.Update);
            }
            else
            {
                prm[0] = new SqlParameter("@Type", ActionType.Insert);
            }
            prm[1] = new SqlParameter("@DentistId", dentist.DentistId);
            prm[2] = new SqlParameter("@Name", dentist.Name);
            prm[3] = new SqlParameter("@Phone", dentist.Phone);
            prm[4] = new SqlParameter("@Address", dentist.Address);
            prm[5] = new SqlParameter("@Email", dentist.Email);
            prm[6] = new SqlParameter("@DOB", dentist.DOB);
            prm[7] = new SqlParameter("@Gender", dentist.Gender);
            prm[8] = new SqlParameter("@CreatedAt", dentist.CreatedAt);
           

            GetData.Sp_ExecuteQurey("sp_Dentist", prm);

        }



        public static void Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Delete);
            prm[1] = new SqlParameter("@DentistId", id);
            GetData.Sp_ExecuteQurey("sp_Dentist", prm);
        }



        public static DataTable Select(string id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.SelectID);
            prm[1] = new SqlParameter("DentistId", id);
            return GetData.Sp_ExecuteQurey("sp_Dentist", prm);
        }
        public static DataTable Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
            return GetData.Sp_ExecuteQurey("sp_Dentist", prm);
        }

        public DataTable IDCount()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.IDCount);
            return GetData.Sp_ExecuteQurey("sp_Dentist", prm);
        }
    }
}

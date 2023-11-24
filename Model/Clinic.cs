using Dental_Managment.DL;
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
    [Alias("clinic")]
    public class Clinic
    {
        public int ClinicId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Logo { get; set; }
        public DateTime CreatedAt { get; set; }






        public void save(Clinic clinic)
        {
            SqlParameter[] prm = new SqlParameter[9];
            if (clinic.ClinicId != 0)
            {
                prm[0] = new SqlParameter("@Type", ActionType.Update);
            }
            else
            {
                prm[0] = new SqlParameter("@Type", ActionType.Insert);
            }
            prm[1] = new SqlParameter("@ClinicId", clinic.ClinicId);
            prm[2] = new SqlParameter("@Name", clinic.Name);
            prm[3] = new SqlParameter("@Phone", clinic.Phone);
            prm[4] = new SqlParameter("@Address", clinic.Address);
            prm[5] = new SqlParameter("@Email", clinic.Email);
            prm[6] = new SqlParameter("@Password", clinic.Password);
            prm[7] = new SqlParameter("@Logo", clinic.Logo);
            prm[8] = new SqlParameter("@CreatedAt", clinic.CreatedAt);
            GetData.Sp_ExecuteQurey("sp_Clinic", prm);

        }



        public static void Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Delete);
            prm[1] = new SqlParameter("@ClinicId", id);
            GetData.Sp_ExecuteQurey("sp_Clinic", prm);
        }


        public  void Select(string id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
            prm[1] = new SqlParameter("@ClinicId", id);
           GetData.Sp_ExecuteQurey("sp_Clinic", prm);
        }
        public void Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
            GetData.Sp_ExecuteQurey("sp_Clinic", prm);
        }
        public  DataTable SelectUser(string Email, string Password)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Type", ActionType.SelectID);
            prm[1] = new SqlParameter("@Email", Email);
            prm[2] = new SqlParameter("@Password", Password);
            return GetData.Sp_ExecuteQurey("sp_Clinic", prm);
        }
        public static void ChangePassword(Clinic x)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Type", ActionType.ChangePassword);
            prm[1] = new SqlParameter("@ClinicId", x.ClinicId);
            prm[2] = new SqlParameter("@Password", x.Password);
            GetData.Sp_ExecuteQurey("sp_Clinic", prm);
        }



    }


}

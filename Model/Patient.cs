using Dental_Managment.DL;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Dental_Managment.Model
{

    public class Patient
    {

        public int PatientId { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Allergies { get; set; }
        public DateTime CreatedAt { get; set; }






        public void save(Patient patient)
        {
            SqlParameter[] prm = new SqlParameter[10];
            if (patient.PatientId != 0)
            {
                prm[0] = new SqlParameter("@Type", ActionType.Update);
            }
            else
            {
                prm[0] = new SqlParameter("@Type", ActionType.Insert);
            }
            prm[1] = new SqlParameter("@PatientId", patient.PatientId);
            prm[2] = new SqlParameter("@Name", patient.Name);
            prm[3] = new SqlParameter("@Phone", patient.Phone);
            prm[4] = new SqlParameter("@Address", patient.Address);
            prm[5] = new SqlParameter("@Email", patient.Email);
            prm[6] = new SqlParameter("@DOB", patient.DOB);
            prm[7] = new SqlParameter("@Gender", patient.Gender);
            prm[8] = new SqlParameter("@Allergies", patient.Allergies);
            prm[9] = new SqlParameter("@CreatedAt", patient.CreatedAt);

            GetData.Sp_ExecuteQurey("sp_Patient", prm);

        }



        public static void Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Delete);
            prm[1] = new SqlParameter("@PatientId", id);
            GetData.Sp_ExecuteQurey("sp_Patient", prm);
        }



        public  DataTable SelectThreeValues()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.SelectID);          
            return GetData.Sp_ExecuteQurey("sp_Patient", prm);
        }
        public static DataTable Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
            return GetData.Sp_ExecuteQurey("sp_Patient", prm);
        }

        public DataTable IDCount()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.IDCount);
            return GetData.Sp_ExecuteQurey("sp_Patient", prm);
        }
    }



}

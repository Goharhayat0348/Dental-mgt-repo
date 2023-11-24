using Dental_Managment.DL;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kimtoo.DbManager;
using ServiceStack;
using ServiceStack.OrmLite;

namespace Dental_Managment.Model
{
    [Alias("treatments")]
    public class Treatment
    {
        public int TreatmentId { get; set; }

        public int AppointmentId { get; set; }
       
        public string CosultationNote { get; set; }
        public string Prescriptions { get; set; }
        
        public DateTime CreatedAt { get; set; }


       


      public Appointment GetApointment()
            => Connections.GetConnection().SingleById<Appointment>(this.AppointmentId);

       

        public void save(Treatment treatment)
        {
            SqlParameter[] prm = new SqlParameter[6];
            if (treatment.TreatmentId != 0)
            {
                prm[0] = new SqlParameter("@Type", ActionType.Update);
            }
            else
            {
                prm[0] = new SqlParameter("@Type", ActionType.Insert);
            }
            prm[1] = new SqlParameter("@TreatmentId", treatment.TreatmentId);
            prm[2] = new SqlParameter("@AppointmentId", treatment.AppointmentId);
            prm[3] = new SqlParameter("@CosultationNote", treatment.CosultationNote);
            prm[4] = new SqlParameter("@Prescriptions", treatment.Prescriptions);
            prm[5] = new SqlParameter("@CreatedAt", treatment.CreatedAt);


            GetData.Sp_ExecuteQurey("sp_Treatment", prm);

        }



        public static void Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Delete);
            prm[1] = new SqlParameter("@TreatmentId", id);
            GetData.Sp_ExecuteQurey("sp_Treatment", prm);
        }



        public  DataTable Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.SelectID);
            return GetData.Sp_ExecuteQurey("sp_Treatment", prm);
        }
       
    }
}

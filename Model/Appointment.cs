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
using ServiceStack.OrmLite;
using System.Drawing;
using System.Linq.Expressions;

namespace Dental_Managment.Model
{

    [Alias("appointments")]
    public class Appointment
    { 
        public int AppointmentId { get; set; }

        public string DentistId { get; set; }
        public string PatientId { get; set; }
        public string Notes { get; set; }       
        public DateTime Date { get; set; } 
        public string Time { get; set; }
        public bool Cancelled { get; set; } = false;
        public DateTime CreatedAt { get; set; }



       


        public Treatment GetTreatment()
           => Connections.GetConnection().Single<Treatment>(r => r.AppointmentId == this.AppointmentId);


        public bool HasSession()
            => GetTreatment() == null;



        public void save(Appointment appointed)
        {
            SqlParameter[] prm = new SqlParameter[8];
            if (appointed.AppointmentId != 0)
            {
                prm[0] = new SqlParameter("@Type", ActionType.Update);
            }
            else
            {
                prm[0] = new SqlParameter("@Type", ActionType.Insert);
            }
            prm[1] = new SqlParameter("@AppointmentId", appointed.AppointmentId);
            prm[2] = new SqlParameter("@PatientId", appointed.PatientId);
            prm[3] = new SqlParameter("@DentistId", appointed.DentistId);
            prm[4] = new SqlParameter("@Date", appointed.Date);
            prm[5] = new SqlParameter("@Time", appointed.Time);
            prm[6] = new SqlParameter("@Notes", appointed.Notes);
            prm[7] = new SqlParameter("@CreatedAt", appointed.CreatedAt);
            GetData.Sp_ExecuteQurey("sp_Appointment", prm);

        }



        public static void Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Delete);
            prm[1] = new SqlParameter("@AppointmentId", id);
            GetData.Sp_ExecuteQurey("sp_Appointment", prm);
        }


        public DataTable SelectDate(DateTime date)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
            prm[2] = new SqlParameter("@Date", date);
            return GetData.Sp_ExecuteQurey("sp_Appointment", prm);
        }

        public  DataTable Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
            return GetData.Sp_ExecuteQurey("sp_Appointment", prm);
        }
        public DataTable IDCount()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.IDCount);           
            return GetData.Sp_ExecuteQurey("sp_Appointment", prm);
        }





    }
}

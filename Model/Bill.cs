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
    [Alias("billing")]
    public class Bill
    {


        public int BillId { get; set; }

        public int TreatmentId { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
       
        public DateTime CreatedAt { get; set; }





        public static void save(Bill bil)
        {
            SqlParameter[] prm = new SqlParameter[6];
            if (bil.BillId != 0)
            {
                prm[0] = new SqlParameter("@Type", ActionType.Update);
            }
            else
            {
                prm[0] = new SqlParameter("@Type", ActionType.Insert);
            }
            prm[1] = new SqlParameter("@BillId", bil.BillId);
            prm[2] = new SqlParameter("@TreatmentId", bil.TreatmentId);
            prm[3] = new SqlParameter("@Description", bil.Description);
            prm[4] = new SqlParameter("@Amount", bil.Amount);
            prm[5] = new SqlParameter("@CreatedAt", bil.CreatedAt);


            GetData.Sp_ExecuteQurey("sp_Billing", prm);

        }



        public static void Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Delete);
            prm[1] = new SqlParameter("@BillId", id);
            GetData.Sp_ExecuteQurey("sp_Billing", prm);
        }



        public DataTable SelectAmount()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.SelectID);
           

            return GetData.Sp_ExecuteQurey("sp_Billing", prm);
        }
        public DataTable Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
            return GetData.Sp_ExecuteQurey("sp_Billing", prm);
        }

        public DataTable IDCount()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", ActionType.IDCount);
            return GetData.Sp_ExecuteQurey("sp_Billing", prm);
        }

        public List<Bill> GetAppointment(int bilid)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Type", ActionType.Select);
            prm[1] = new SqlParameter("@BillId", bilid);
            DataTable dt = GetData.Sp_ExecuteQurey("sp_Billing", prm);
            List<Bill> list = new List<Bill>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Bill x = new Bill();
                    x.BillId = Convert.ToInt32(dt.Rows[i]["BillId"]);
                    x.TreatmentId = Convert.ToInt32(dt.Rows[i]["TreatmentId"]);
                    x.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    x.Amount = Convert.ToDouble(dt.Rows[i]["Amount"]);
                    x.CreatedAt = Convert.ToDateTime(dt.Rows[i]["CreatedAt"]);

                    list.Add(x);
                }
                return list;
            }
            else
            {
                return new List<Bill>();
            }

        }
    }
}

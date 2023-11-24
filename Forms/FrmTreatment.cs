using Dental_Managment.DL;
using Dental_Managment.Model;
using Dental_Managment.Pages;
using Kimtoo.BindingProvider;
using Kimtoo.DbManager;
using Org.BouncyCastle.Asn1.Ocsp;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Dental_Managment.Forms
{
    public partial class FrmTreatment : Form
    {

        public FrmTreatment(string appointID, string dName, string pName)
        {
            InitializeComponent();

            lnkAppointid.Text = appointID;
            lnkDentistName.Text = dName;
            lnkPatientName.Text = pName;
            LoadData();
            grid.Columns["TreatmentId"].Visible = false;
            grid.Columns["BillId"].Visible = false;
            grid.Columns["CreatedAt"].Visible = false;

            Cursor.Current = Cursors.Default;
        }

        int row = -1;
        Treatment obj = new Treatment();
        Bill obj1 = new Bill();
        public void LoadData()
        {

            grid.DataSource = obj1.Select();
            lblTot.Text = $"Total:{obj1.SelectAmount().Rows[0][0].ToString()}";

        }

        public void masterclean()
        {
            txtConsultNotes.Text = txtPrescription.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtConsultNotes.Text == "")
                {
                    lblCosultNote.Text = "Please Select ConsultNote";
                }
                else if (txtPrescription.Text == "")
                {
                    lblPrescript.Text = "Please Select Prescription";
                }

                else
                {

                    if (pnlID.Text != "")
                    {
                        obj.TreatmentId = Convert.ToInt32(pnlID.Text);

                    }

                    obj.CosultationNote = txtConsultNotes.Text;
                    obj.Prescriptions = txtPrescription.Text;

                    if (pnlID.Text != "")
                    {
                        obj.CreatedAt = Convert.ToDateTime(DateTime.Now);
                    }


                    DialogResult dr = MessageBox.Show("Are you Sure!...", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        obj.save(obj);
                        LoadData();
                        bunifuSnackbar1.Show(this.FindForm(), "Saved", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        masterclean();
                        pnlID.Text = "0";
                    }

                }

            }

            catch (Exception x)
            {

                MessageBox.Show(x.Message + " Please Enter Values First");
            }

        }



        private void btnRefress_Click(object sender, EventArgs e)
        {


            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            DataTable dt = obj.Select();
            obj1.TreatmentId = Convert.ToInt32(dt.Rows[0]["TreatmentId"]);

            if (obj1.BillId != 0)
            {

                for (int i = 0; i < grid.Rows.Count - 1; i++)
                {
                    if (i == row)
                    {
                        obj1.Description = Convert.ToString(grid.Rows[i].Cells[3].Value);
                        obj1.Amount = Convert.ToDouble(grid.Rows[i].Cells[4].Value);
                        obj1.CreatedAt = Convert.ToDateTime(DateTime.Now);
                    }

                }
            }
            else
            {
                for (int i = 0; i < grid.Rows.Count - 1; i++)
                {
                    obj1.Description = Convert.ToString(grid.Rows[i].Cells[3].Value);
                    obj1.Amount = Convert.ToInt32(grid.Rows[i].Cells[4].Value);
                }
                obj1.CreatedAt = Convert.ToDateTime(DateTime.Now);
            }

            Bill.save(obj1);
            LoadData();
            bunifuSnackbar1.Show(this.FindForm(), "Saved", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);





        }
        int id;
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Bill.Delete(id);
                LoadData();
                //lblTot.Text = $"Total: {_treatment.ge().Sum(r => r.Amount).ToString("C1")}";
                bunifuSnackbar1.Show(this.FindForm(), "Saved", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                MessageBox.Show("Deleted Succsesfully");
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                row = e.RowIndex;
                obj1.BillId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["BillId"].Value);
                obj1.TreatmentId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["TreatmentId"].Value);

                //obj1.Description =Convert.ToString(grid.Rows[e.RowIndex].Cells["Description"].Value);
                //obj1.Amount =Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Amount"].Value);
                //obj1.CreatedAt = Convert.ToDateTime(grid.Rows[e.RowIndex].Cells["CreatedAt"].Value);

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }


        }
    }
}

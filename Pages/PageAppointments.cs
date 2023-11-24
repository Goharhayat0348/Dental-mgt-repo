using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Dental_Managment.DL;
using Dental_Managment.Forms;
using Dental_Managment.Model;
using ExCSS;
using FluentValidation.Results;
using Kimtoo.BindingProvider;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Ocsp;
using ServiceStack.OrmLite;

namespace Dental_Managment.Pages
{
    public partial class PageAppointments : UserControl
    {

        public bool IsAppointment { get; set; } = true;
        public PageAppointments()
        {

            if (this.IsInDesignMode()) return;
            InitializeComponent();
            LoadData();
            grid.Columns["AppointmentId"].Visible = false;
            grid.Columns["Notes"].Visible = false;
            grid.Columns["Cancelled"].Visible = false;


            LoadPatient();
            LoadDentist();


        }

        Appointment obj = new Appointment();


       


        public void LoadData()
        {
            tabCat.Visible = this.IsAppointment;
            Cursor.Current = Cursors.WaitCursor;

            List<Appointment> list = new List<Appointment>();
            list = list.Where(r => r.Date.Date == DatePick.Value.Date).ToList();
            if (this.IsAppointment)
            {
                if (btnPending.Text.Trim() == "Pending")
                {
                    list = list.Where(r => !r.HasSession() && !r.Cancelled).ToList();
                }
                else if (btnCanceled.Text.Trim() == "Canceled")
                {
                    list = list.Where(r => r.Cancelled).ToList();
                }
            }
            else
            {
                list = list.Where(r => r.HasSession()).ToList();
            }


            grid.DataSource = obj.Select();
            Cursor.Current = Cursors.Default;
        }


        void LoadPatient()
        {

            ddlPatient.DataSource = GetData.GetTable("Select * from tbl_Patient");
            ddlPatient.DisplayMember = "Name";
            ddlPatient.ValueMember = "PatientId";
        }

        void LoadDentist()
        {
            ddlDentist.DataSource = GetData.GetTable("Select * from tbl_Dentist");
            ddlDentist.DisplayMember = "Name";
            ddlDentist.ValueMember = "DentistId";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlDrawwer.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            pnlID.Text = "0";

            btnSave.Visible = chk.Enabled = true;
            masterclean();
            pnlDrawwer.Visible = true;
        }

        public void masterclean()
        {
            ddlPatient.Text = ddlDentist.Text = DatTimPickr.Text = txttime.Text = txtNotes.Text = "";
        }


        private void DatTimPickr_ValueChanged(object sender, EventArgs e)
        {
            DatTimPickr.CustomFormat = Convert.ToString(DateTime.Now);
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Trim().Length > 0)
                    grid.SearchRows(txtSearch.Text);
                else
                    LoadData();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (ddlPatient.Text == "")
                {
                    lblPatient.Text = "Please Select Name";
                }
                else if (ddlDentist.Text == "")
                {
                    lblDentist.Text = "Please Select Name";
                }

                else if (txttime.Text == "")
                {
                    lblTime.Text = "Please Enter Time";
                }
                else if (txtNotes.Text == "")
                {
                    lblNotes.Text = "Please Enter Notes";
                }

                else
                {

                    if (pnlID.Text != "")
                    {
                        obj.AppointmentId = Convert.ToInt32(pnlID.Text);

                    }

                    obj.PatientId = ddlPatient.Text;
                    obj.DentistId = ddlDentist.Text;
                    obj.Date = Convert.ToDateTime(DatTimPickr.Text);
                    obj.Time = txttime.Text;
                    obj.Notes = txtNotes.Text;
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
                        pnlDrawwer.Visible = false;
                        pnlID.Text = "0";
                    }

                }

            }

            catch (Exception x)
            {

                MessageBox.Show(x.Message + " Please Enter Values First");
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (grid.Rows.Count > 0)
                {


                    PageAppointments a = new PageAppointments();
                    btnOpen.Visible = true;

                }
                else
                {
                    btnOpen.Visible = false;
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }


        }

        private void btnRefress_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }

        private void ddlPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPatient.Text != "")
            {
                lblPatient.Text = "";
            }
        }

        private void ddlDentist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDentist.Text != "")
            {
                lblDentist.Text = "";
            }
        }

        private void txttime_TextChanged(object sender, EventArgs e)
        {
            if (txttime.Text != "")
            {
                lblTime.Text = "";
            }
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            if (txtNotes.Text != "")
            {
                lblNotes.Text = "";
            }
        }



        private void btnOpen_Click(object sender, EventArgs e)
        {


            FrmTreatment rr = new FrmTreatment(grid.SelectedRows[0].Cells[3].Value.ToString(),
                                               grid.SelectedRows[0].Cells[4].Value.ToString(),
                                               grid.SelectedRows[0].Cells[5].Value.ToString());

            rr.ShowDialog();
            
        }



        private void btnPending_Click(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            LoadData();
        }
       public DateTime date;
        private void DatePick_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DatTimPickr.Text.Trim().Length > 0)
                    grid.SearchRows(DatTimPickr.Text);
                else
                    LoadData();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

            //LoadData();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;


                if (grid.Columns[grid.CurrentCell.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Appointment.Delete(Convert.ToInt32(grid.Rows[e.RowIndex].Cells["AppointmentId"].Value));
                        LoadData();
                        MessageBox.Show("Deleted Succsesfully");
                    }

                }
                if (grid.Columns[grid.CurrentCell.ColumnIndex].Name == "Update")
                {

                    if (btnSave.Visible = chk.Enabled = false)
                    {
                        pnlID.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells["AppointmentId"].Value);
                        ddlDentist.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[4].Value);
                        ddlPatient.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[5].Value);
                        DatTimPickr.Value = Convert.ToDateTime(grid.Rows[e.RowIndex].Cells[7].Value);
                        txttime.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[8].Value);
                        txtNotes.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[6].Value);

                    }
                    pnlDrawwer.Show();



                }


            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void PageAppointments_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

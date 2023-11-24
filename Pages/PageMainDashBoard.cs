using Dental_Managment.DL;
using Dental_Managment.Model;
using Kimtoo.BindingProvider;
using Kimtoo.DbManager;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Managment.Pages
{
    public partial class PageMainDashBoard : UserControl
    {
        public PageMainDashBoard()
        {
            if (this.IsInDesignMode()) return;
            InitializeComponent();
            LoadDate();

        }

        Appointment ap = new Appointment();
        Dentist da = new Dentist();
        Patient pa = new Patient();
        Bill bill = new Bill();


        public void LoadGrid()
        {
            grid1.DataSource = pa.SelectThreeValues();
        }
        private void LoadDate()
        {

            var appoint = ap.Select();
            var patient = Patient.Select();
            var dentist = Dentist.Select();
            var billing = ap.Select();

            lblAppointment.Text = ap.IDCount().Rows[0][0].ToString();
            lblDentist.Text = da.IDCount().Rows[0][0].ToString();
            lblPatient.Text = pa.IDCount().Rows[0][0].ToString();
            lblBilling.Text = bill.IDCount().Rows[0][0].ToString();

        }

        public void HideValue()
        {
            grid1.Columns["PatientId"].Visible = false;
            grid1.Columns["Phone"].Visible = false;
            grid1.Columns["Address"].Visible = false;
            grid1.Columns["DOB"].Visible = false;
            grid1.Columns["Gender"].Visible = false;
            grid1.Columns["Allergies"].Visible = false;
        }

        private void PageMainDashBoard_Load(object sender, EventArgs e)
        {
            LoadDate();
        }

        private void btnRefress1_Click(object sender, EventArgs e)
        {
            LoadGrid();
            HideValue();
        }

        private void btnRefress2_Click(object sender, EventArgs e)
        {
            LoadDate();
        }
    }
}

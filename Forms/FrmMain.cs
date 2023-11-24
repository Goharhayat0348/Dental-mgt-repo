using Bunifu.UI.WinForms;
using Dental_Managment.DL;
using Dental_Managment.Forms;
using Dental_Managment.Model;
using Dental_Managment.Pages;
using Kimtoo.DbManager;
using ServiceStack;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Xml;

namespace Dental_Managment
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        Validation V = new Validation();
        Clinic obj = new Clinic();

        private void menu_OnItemSelected(object sender, string path, EventArgs e)
        {
            if (path == "Settings")
            {
                Kimtoo.DbManager.Connections.Show();
                return;
            }
            bunifuAppBar1.Title = path;
            pages.SetPage(path);
        }


        private void btnPatient_Click(object sender, EventArgs e)
        {
            if (bunifuAppBar1.Title != "")
            {
                bunifuAppBar1.Title = "PATIENT";
            }
            PagePatients obj = new PagePatients();
            MainControl obj2 = new MainControl();
            obj2.Show(obj, panel2);
        }

        private void btnDentist_Click(object sender, EventArgs e)
        {
            if (bunifuAppBar1.Title != "")
            {
                bunifuAppBar1.Title = "DENTIST";
            }
            PageDentists obj = new PageDentists();
            MainControl obj2 = new MainControl();
            obj2.Show(obj, panel2);
        }



        private void btnAppointmnt_Click(object sender, EventArgs e)
        {
            if (bunifuAppBar1.Title != "")
            {
                bunifuAppBar1.Title = "APPOINTMENT";
            }
            PageAppointments obj = new PageAppointments();
            MainControl obj2 = new MainControl();
            obj2.Show(obj, panel2);
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            if (bunifuAppBar1.Title != "")
            {
                bunifuAppBar1.Title = "SESSION";
            }
        }





        private void FrmMain_Load(object sender, EventArgs e)
        {
            pages.SetPage("MainDashboard");
            pnlMenu.Enabled = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (bunifuAppBar1.Title != "")
            {
                bunifuAppBar1.Title = "DASHBOARD";
            }
            PageMainDashBoard obj = new PageMainDashBoard();
            MainControl obj2 = new MainControl();
            obj2.Show(obj, panel2);
        }




        private void btnClinic_Click(object sender, EventArgs e)
        {
            if (bunifuAppBar1.Title != "")
            {
                bunifuAppBar1.Title = "CLINIC";
            }
            FrmClinic obj = new FrmClinic();
            obj.Show();

        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            if (bunifuAppBar1.Title != "")
            {
                bunifuAppBar1.Title = "SETTING";
            }

            Setting obj = new Setting();
            MainControl obj2 = new MainControl();
            obj2.Show(obj, panel2);
        }

       


        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void btnBackcolor_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        
    }
}

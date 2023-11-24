using Dental_Managment.Lib;
using Dental_Managment.Model;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Managment.Forms
{
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }
        ToolTip toolTip = new ToolTip();
        Clinic obj = new Clinic();
        FrmMain frm = new FrmMain();
        Log lg = new Log();

        int a = 0;
        public bool result { get; set; }
        private void mtbtn_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_UserName.Text) && !string.IsNullOrEmpty(txt_Password.Text) /*&& !string.IsNullOrEmpty(cmb_Branch.Text)*/)
                {



                    DataTable dt = obj.SelectUser(txt_UserName.Text, txt_Password.Text);

                    if (dt.Rows.Count > 0)
                    {

                        Log.ClinicId = Convert.ToInt32(dt.Rows[0]["ClinicId"]);
                        Log.Email = Convert.ToString(dt.Rows[0]["Email"]);
                        //Log.AccountType = Convert.ToString(dt.Rows[0]["AccountType"]);
                        lg.SaveLog("Loged In To The System");


                        bunifuSnackbar1.Show(this.FindForm(), "Success", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        frm.Show();
                        this.Hide();



                    }
                    else
                    {
                        Log.Email = txt_UserName.Text;
                        lg.SaveLog("Tried To Login");
                        AnimtedMsgBoxx.ShowMedium("Incorrect User Name or Password", AnimtedMsgBoxx.Buttons.OK, AnimtedMsgBoxx.Icon.Info, AnimtedMsgBoxx.AnimateStyle.FadeIn);
                        txt_UserName.ResetText();
                        txt_Password.ResetText();
                        txt_UserName.Focus();
                        result = false;

                    }


                }
                else
                {
                    AnimtedMsgBoxx.ShowMedium("Incorrect User Name or Password", AnimtedMsgBoxx.Buttons.OK, AnimtedMsgBoxx.Icon.Info, AnimtedMsgBoxx.AnimateStyle.FadeIn);
                    txt_UserName.ResetText();
                    txt_Password.ResetText();
                    txt_UserName.Focus();
                    result = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbtn_LogIn.Focus();

            }
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
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progresbarLoadLog.Value < 100)
            {

                progresbarLoadLog.Value = a;
                a++;
            }
            else
            {
                picLoader.Visible = false;
                timer1.Enabled = false;
                progresbarLoadLog.Visible = false;

            }
        }
    }
}

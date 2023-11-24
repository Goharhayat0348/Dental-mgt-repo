using MySqlX.XDevAPI.Common;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dental_Managment.Lib;
using Bunifu.UI.WinForms;
using Dental_Managment.Model;

namespace Dental_Managment.Forms
{

    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        ToolTip toolTip = new ToolTip();
        Clinic obj = new Clinic();
        FrmMain frm = new FrmMain();
        public bool result { get; set; }
        private void UserLogin_Load(object sender, EventArgs e)
        {

        }



        private void txt_UserName_KeyDown_1(object sender, KeyEventArgs e)
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
        private void bttn_Minimize_MouseHover_1(object sender, EventArgs e)
        {
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btn_minimized, "Minimize");
        }
        private void bttn_Close_MouseHover(object sender, EventArgs e)
        {
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(btn_Close, "Close");
        }

        private void mtbtn_LogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_UserName.Text) && !string.IsNullOrEmpty(txt_Password.Text) /*&& !string.IsNullOrEmpty(cmb_Branch.Text)*/)
                {



                    DataTable dt = obj.SelectUser(txt_UserName.Text, txt_Password.Text);

                    if (dt.Rows.Count > 0)
                    {

                        bunifuSnackbar1.Show(this.FindForm(), "Success", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        frm.Show();
                        this.Hide();
                        


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
        int a = 0;
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

        private void picLoader_Click(object sender, EventArgs e)
        {

        }

        private void picloader_Click_1(object sender, EventArgs e)
        {

        }
    }
}

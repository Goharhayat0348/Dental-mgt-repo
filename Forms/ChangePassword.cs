using Bunifu.UI.WinForms;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        Clinic obj = new Clinic();
        public bool result { get; set; }
        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            try
            {
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtNewPasword.Text = "";
                txtConfirmPasword.Text = "";
            }
            catch
            {

            }

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "")
                {
                    lblEmail.Text = "Please Enter Email";
                }
                else if (txtPassword.Text == "")
                {
                    lblPassword.Text = "Please Enter Password";
                }
                else if (txtNewPasword.Text == "")
                {
                    lblNewpassword.Text = "Please Enter New Password";
                }
                else if (txtConfirmPasword.Text == "")
                {
                    lblConfirmpassword.Text = "Please Enter Confirm Password";
                }
                else
                {
                    if (txtNewPasword.Text==txtConfirmPasword.Text)
                    {
                      
                        if (!string.IsNullOrEmpty(txtEmail.Text)&&!string.IsNullOrEmpty(txtPassword.Text)&&!string.IsNullOrEmpty(txtNewPasword.Text)&&!string.IsNullOrEmpty(txtConfirmPasword.Text))
                        {
                            DataTable dt = obj.SelectUser(txtEmail.Text, txtPassword.Text);
                            if (dt.Rows.Count>0) 
                            {
                               
                                obj.ClinicId = Convert.ToInt32(dt.Rows[0]["ClinicId"].ToString());
                                obj.Password = txtNewPasword.Text;
                                Clinic.ChangePassword(obj);
                                bunifuSnackbar1.Show(this.FindForm(), "Success", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                                Clear();
                            }
                            else
                            {
                                AnimtedMsgBoxx.ShowMedium("Incorrect User Name or Password", AnimtedMsgBoxx.Buttons.OK, AnimtedMsgBoxx.Icon.Info, AnimtedMsgBoxx.AnimateStyle.FadeIn);
                                txtEmail.ResetText();
                                txtPassword.ResetText();
                                txtNewPasword.ResetText();
                                txtConfirmPasword.ResetText();
                                txtEmail.Focus();
                                result = false;
                            }
                        }
                        else
                        {
                            AnimtedMsgBoxx.ShowMedium("Incorrect User Name or Password", AnimtedMsgBoxx.Buttons.OK, AnimtedMsgBoxx.Icon.Info, AnimtedMsgBoxx.AnimateStyle.FadeIn);
                            txtEmail.ResetText();
                            txtPassword.ResetText();
                            txtNewPasword.ResetText();
                            txtConfirmPasword.ResetText();
                            txtEmail.Focus();
                            result = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("New Password And Confirm Password Are Not Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }
    }
}

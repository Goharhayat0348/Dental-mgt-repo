using Dental_Managment.Lib;
using Dental_Managment.Model;
using Google.Protobuf.WellKnownTypes;
using Kimtoo.DbManager;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Managment.Forms
{
    public partial class FrmClinic : Form
    {
        private Clinic record;
        public FrmClinic()
        {
            InitializeComponent();
            
            obj.Select(Convert.ToString(record));
            Cursor.Current = Cursors.Default;
        }


        Validation V = new Validation();
        Clinic obj= new Clinic();


       

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (V.checkPhone(txtPhone.Text, sender, e))
            {
                if (txtPhone.TextLength >= 10)
                {
                    lblPhone.ForeColor = Color.Green;
                    lblPhone.Text = "Valid Phone";
                   
                }
                else
                {
                    lblPhone.ForeColor = Color.Red;
                    lblPhone.Text = "Invalid Phone";
                }

                
            }
           



        }


        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (V.checkEmail(txtEmail.Text.ToString()))
            {
                
                lblEmail.ForeColor = Color.Green;
                lblEmail.Text = "Valid Email";

            }
            else
            {
                lblEmail.ForeColor = Color.Red;
                lblEmail.Text = "InValid Email";
            }


        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (V.checkPassword(txtPassword.Text.ToString()))
            {

                lblPassword.ForeColor = Color.Green;
                lblPassword.Text = "Valid Password";


            }
            else
            {
                lblPassword.ForeColor = Color.Red;
                lblPassword.Text = "InValid Password";
            }
            
        }

       

        private void btnChange_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            picLogo.Image = Image.FromFile(openFileDialog1.FileName);
        }
        public void masterclean()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            lblAddress.Text = "";
            lblEmail.Text = "";
            lblName.Text = "";
            lblPassword.Text = "";
            lblPhone.Text = "";
            
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    lblName.Text = "Please Enter Name";
                }
                else if (txtPhone.Text == "")
                {
                    lblPhone.Text = "Please Enter Phone";
                }
                else if (txtEmail.Text == "")
                {
                    lblEmail.Text = "Please Enter Email";
                }
                else if (txtAddress.Text == "")
                {
                    lblAddress.Text = "Please Enter Address";
                }

                else if (txtPassword.Text == "")
                {
                    lblPassword.Text = "Please Enter Password";
                }
                else
                {
                    if (pnlID.Text!="")
                    {
                        obj.ClinicId =Convert.ToInt32(pnlID.Text);
                    }
                    obj.Name = txtName.Text;
                    obj.Phone = txtPhone.Text;
                    obj.Email = txtEmail.Text;
                    obj.Address = txtAddress.Text;
                    obj.Password = txtPassword.Text;
                    obj.Logo = picLogo.Image.ToBytes();
                    if (pnlID.Text != "")
                    {
                        obj.CreatedAt = Convert.ToDateTime(DateTime.Now);
                    }
                    obj.save(obj);
                    masterclean();
                    bunifuSnackbar1.Show(this.FindForm(), "Saved", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    pnlID.Text = "0";
                }
               
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text!="")
            {
                lblName.Text = "";
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text != "")
            {
                lblPhone.Text = "";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                lblEmail.Text = "";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text != "")
            {
                lblAddress.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                lblPassword.Text = "";
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (lblPhone.Text=="Valid Phone"|| lblPhone.Text == "Invalid Phone")
            {
                lblPhone.Text = "";
            }
        }
    }
}

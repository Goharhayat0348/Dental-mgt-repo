using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Dental_Managment.DL;
using Dental_Managment.Model;
using FluentValidation.Results;
using Google.Protobuf.WellKnownTypes;
using Kimtoo.BindingProvider;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Ocsp;
using ServiceStack;
using ServiceStack.OrmLite;

namespace Dental_Managment.Pages
{
    public partial class PageDentists : UserControl
    {
        public PageDentists()
        {

            if (this.IsInDesignMode()) return;
            InitializeComponent();
            LoadData();
            grid.Columns["DentistId"].Visible = false;


        }

        Dentist obj = new Dentist();
        Regex r = new Regex(@"^[0-9]{11}$");



        public void LoadData()
        {

            grid.DataSource = Dentist.Select();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlDrawwer.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlID.Text = "0";
            masterclean();
            pnlDrawwer.Visible = true;
        }

        public void masterclean()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            ddlList.Text = "";
            DatTimPickr.Text="";
        }






        public static int id;
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0) return;

                if (grid.Columns[grid.CurrentCell.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Dentist.Delete(Convert.ToInt32(grid.Rows[e.RowIndex].Cells["DentistId"].Value));
                        LoadData();
                        bunifuSnackbar1.Show(this.FindForm(), "Deleted", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                    }

                }
                if (grid.Columns[grid.CurrentCell.ColumnIndex].Name == "Update")
                {


                    pnlID.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells["DentistId"].Value);
                    txtName.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[5].Value);
                    txtPhone.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[6].Value);
                    txtAddress.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[7].Value);
                    txtEmail.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[8].Value);
                    DatTimPickr.Value = Convert.ToDateTime(grid.Rows[e.RowIndex].Cells[9].Value);
                    ddlList.Text = Convert.ToString(grid.Rows[e.RowIndex].Cells[10].Value);

                    pnlDrawwer.Show();
                   


                }
                
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }




        }


        public void SpecialCharacterNotAllowdButDigiAllow(KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) && char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back)
            {
                // These characters may pass
                e.Handled = false;
            }
            else
            {
                // Everything that is not a letter, nor a backspace nor a space will be blocked
                e.Handled = true;
            }
        }


        private void DatTimPickr_ValueChanged(object sender, EventArgs e)
        {
            DatTimPickr.CustomFormat = Convert.ToString(DateTime.Now);
        }

        private void btnDentistSave_Click_1(object sender, EventArgs e)
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
               
                else if (ddlList.Text == "")
                {
                    lblGender.Text = "Please Enter Gender";
                }
                else
                {
                    if (r.IsMatch(txtPhone.Text))
                    {

                        if (pnlID.Text != "")
                        {
                            obj.DentistId = Convert.ToInt32(pnlID.Text);

                        }


                        obj.Name = txtName.Text;
                        obj.Phone = txtPhone.Text;
                        obj.Email = txtEmail.Text;
                        obj.Address = txtAddress.Text;
                        obj.DOB = Convert.ToDateTime(DatTimPickr.Value);
                        obj.Gender = ddlList.Text;
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
                           
                        }

                    }
                    else
                    {
                        lblPhone.Text = "Please Enter Valid Phone Number";
                    }
                    pnlID.Text = "0";
                }

            }

            catch (Exception x)
            {

                MessageBox.Show(x.Message + " Please Enter Values First");
            }
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

        private void ddlList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlList.Text != "")
            {
                lblGender.Text = "";
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                SpecialCharacterNotAllowdButDigiAllow(e);
                if (char.IsDigit(e.KeyChar))
                {
                 
                  
                        //Count the digits already in the text.  I'm using linq:
                        if ((sender as TextBox).Text.Count(Char.IsDigit) >= 11)
                            e.Handled = true;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

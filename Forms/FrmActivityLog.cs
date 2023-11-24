using Bunifu.UI.WinForms;
using Dental_Managment.Model;
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
    public partial class FrmActivityLog : Form
    {
        public FrmActivityLog()
        {
            InitializeComponent();
            LoadGrid();
        }

        Log obj = new Log();
        public void LoadGrid()
        {
            grid.DataSource = obj.Select();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               

                if (e.ColumnIndex==0)
                {
                    DialogResult dr = MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        Log.Delete(Convert.ToInt32(grid.Rows[e.RowIndex].Cells["LogID"].Value));
                        LoadGrid();
                        bunifuSnackbar1.Show(this.FindForm(), "Deleted", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                    }
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }
    }
}

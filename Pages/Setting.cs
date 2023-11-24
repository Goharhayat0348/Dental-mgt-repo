using Dental_Managment.Forms;
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

namespace Dental_Managment.Pages
{
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
            LoadData();
            grid.Columns["TreatmentId"].Visible = false;
            grid.Columns["BillId"].Visible = false;
            grid.Columns["CreatedAt"].Visible = false;
        }

        Bill obj1 = new Bill();
        double Total;
        public void LoadData()
        {

            grid.DataSource = obj1.Select();
           Total =Convert.ToDouble(obj1.SelectAmount().Rows[0][0].ToString());

        }
       

        private void btnBackColr_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                
            }
        }

        private void btnChangePasword_Click(object sender, EventArgs e)
        {
            FrmChangePassword obj=new FrmChangePassword();
            obj.ShowDialog();
        }

        

        private void btnReport_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        int pos = 80;
        double Amount;
        string Description;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Dental Clinic Software", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(43));
            e.Graphics.DrawString("Description\tAMOUNT", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(42, 52));
            foreach (DataGridViewRow row in grid.Rows)
            {
                Description =""+row.Cells["Column2"].Value;
                Amount = Convert.ToDouble(row.Cells["Column3"].Value);
                e.Graphics.DrawString("" + Description, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(60, pos));
                e.Graphics.DrawString("$" + Amount, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(174, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Total Amount: $" + Total, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("************DentalShop**************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(0, pos + 85));
            //grid.Rows.Clear();
            grid.Refresh();
            pos = 100;
            Total= 0;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmActivityLog obj= new FrmActivityLog();
            obj.ShowDialog();
        }
    }
}

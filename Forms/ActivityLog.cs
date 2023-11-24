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
    public partial class ActivityLog : Form
    {
        public ActivityLog()
        {
            InitializeComponent();
        }
        ActivityLog obj=new ActivityLog();

        public void LoadGrid()
        {
            grid.DataSource = obj.Select();
        }
    }
}

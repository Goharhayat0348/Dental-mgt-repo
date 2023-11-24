using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Managment.Model
{
    class MainControl
    {
        public void Show(Control control, Panel panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel.Controls.Add(control);

        }
    }

}

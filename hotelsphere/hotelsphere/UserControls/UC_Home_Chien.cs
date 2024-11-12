using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.UserControls
{
    public partial class UC_Home_Chien : UserControl
    {
        public UC_Home_Chien()
        {
            InitializeComponent();
            timer1.Start();
            CenterControl(panel6, panel4);
            panel4.Resize += Panel4_Resize;

        }

        private void Panel4_Resize(object sender, EventArgs e)
        {
            CenterControl(panel6, panel4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
        }


        private void CenterControl(Control control, Panel parentPanel)
        {
            control.Left = (parentPanel.Width - control.Width) / 2;
            control.Top = (parentPanel.Height - control.Height) / 2;
        }

        private void UC_Home_Chien_Load(object sender, EventArgs e)
        {
            CenterControl(panel6, panel4);
        }
    }
}

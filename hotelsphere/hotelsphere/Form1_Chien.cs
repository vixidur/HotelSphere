using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere
{
    public partial class Form1_Chien : Form
    {
        public Form1_Chien()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if (panel2.Width >= 800)
            {
                timer1.Stop();
                frmLogin_Chien frmLogin_Chien = new frmLogin_Chien();
                frmLogin_Chien.Show();
                this.Hide();
            }
        }
    }
}

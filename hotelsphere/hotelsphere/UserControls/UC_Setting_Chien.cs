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
    public partial class UC_Setting_Chien : UserControl
    {
        public UC_Setting_Chien()
        {
            InitializeComponent();
            InitializeWebView();
        }


        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("http://duongkenh24h.site/INFO-MEMBER/info1.html");
        }
    }
}

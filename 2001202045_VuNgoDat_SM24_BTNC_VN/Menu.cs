using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001202045_VuNgoDat_SM24_BTNC_VN
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }       
        private void menuBTNC_Click(object sender, EventArgs e)
        {
            new Views.BTNC.B1().Show();
        }

        private void menuBTVN_1_Click(object sender, EventArgs e)
        {
            new Views.BTVN.TimerForm().Show();
        }

        private void menuBTVN_2_Click(object sender, EventArgs e)
        {

        }

        private void bài1BTVNToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }
    }
}

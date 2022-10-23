using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001202045_VuNgoDat_SM24_BTNC_VN.Views.BTVN
{
    public partial class TimerForm : Form
    {
        DateTime startTime = DateTime.Now.AddMinutes(30);
        public TimerForm()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = (startTime - DateTime.Now)
                   .ToString("hh\\:mm\\:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1_Tick(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001202045_VuNgoDat_SM24_BTNC_VN.Views.BTNC
{
    public partial class Input : Form
    {
        B1 B1Frm = (B1)Application.OpenForms["B1"];
        public Input()
        {
            InitializeComponent();
            cboClass.Items.AddRange(B1Frm.eClassList.ToArray());
            cboClass.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Yêu cầu nhập tên!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (B1Frm.eClassList.IndexOf((string)cboClass.SelectedItem))
            {
                case 0:
                    B1Frm.AddNewStudent(txtName.Text, 1);
                    break;
                case 1:
                    B1Frm.AddNewStudent(txtName.Text, 2);
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Bạn có muốn thoát?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rsl == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
    }
}

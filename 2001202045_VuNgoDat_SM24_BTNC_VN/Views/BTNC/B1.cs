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
    public partial class B1 : Form
    {
        public List<string> eClassList = new List<string>(){ "Lớp A", "Lớp B"};
        public B1()
        {
            InitializeComponent();
        }
        public void AddNewStudent(string name, int classN)
        {
            switch (classN)
            {
                case 1:
                    lstbA.Items.Add(name);
                    break;
                case 2:
                    lstbB.Items.Add(name);
                    break;
            }
        }
        private void mbtnCreate_Click(object sender, EventArgs e)
        {
            Input InputFrm = new Input();
            InputFrm.Show();
        }

        private void mbtnMoveToB_Click(object sender, EventArgs e)
        {
            if (lstbA.SelectedIndex != -1)
            {
                var tmpList = lstbA.SelectedItems.OfType<string>().ToList();
                tmpList.ForEach(x => {
                    lstbA.Items.Remove(x);
                    lstbB.Items.Add(x);
                });
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học viên!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void mbtnMoveToA_Click(object sender, EventArgs e)
        {
            if (lstbB.SelectedIndex != -1)
            {
                var tmpList = lstbB.SelectedItems.OfType<string>().ToList();
                tmpList.ForEach(x => {
                    lstbB.Items.Remove(x);
                    lstbA.Items.Add(x);
                });
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học viên!", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            if (lstbA.SelectedIndex != -1)
            {
                var tmpList = lstbA.SelectedItems.OfType<string>().ToList();
                tmpList.ForEach(x => {
                    lstbA.Items.Remove(x);
                });
            }
            if (lstbB.SelectedIndex != -1)
            {
                var tmpList = lstbB.SelectedItems.OfType<string>().ToList();
                tmpList.ForEach(x => {
                    lstbB.Items.Remove(x);
                });
            }
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Bạn có muốn thoát?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rsl == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}

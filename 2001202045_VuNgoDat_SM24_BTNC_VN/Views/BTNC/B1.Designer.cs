
namespace _2001202045_VuNgoDat_SM24_BTNC_VN.Views.BTNC
{
    partial class B1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbtnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnMoveToB = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnMoveToA = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbA = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstbB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnUpdate,
            this.mbtnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mbtnUpdate
            // 
            this.mbtnUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnCreate,
            this.mbtnMoveToB,
            this.mbtnMoveToA,
            this.mbtnDelete});
            this.mbtnUpdate.Name = "mbtnUpdate";
            this.mbtnUpdate.Size = new System.Drawing.Size(82, 24);
            this.mbtnUpdate.Text = "Cập nhật";
            // 
            // mbtnExit
            // 
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(77, 24);
            this.mbtnExit.Text = "&Kết thúc";
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // mbtnCreate
            // 
            this.mbtnCreate.Name = "mbtnCreate";
            this.mbtnCreate.Size = new System.Drawing.Size(224, 26);
            this.mbtnCreate.Text = "Nhập học viên mới";
            this.mbtnCreate.Click += new System.EventHandler(this.mbtnCreate_Click);
            // 
            // mbtnMoveToB
            // 
            this.mbtnMoveToB.Name = "mbtnMoveToB";
            this.mbtnMoveToB.Size = new System.Drawing.Size(224, 26);
            this.mbtnMoveToB.Text = "Chuyển sang lớp B";
            this.mbtnMoveToB.Click += new System.EventHandler(this.mbtnMoveToB_Click);
            // 
            // mbtnMoveToA
            // 
            this.mbtnMoveToA.Name = "mbtnMoveToA";
            this.mbtnMoveToA.Size = new System.Drawing.Size(224, 26);
            this.mbtnMoveToA.Text = "Chuyển sang lớp A";
            this.mbtnMoveToA.Click += new System.EventHandler(this.mbtnMoveToA_Click);
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Size = new System.Drawing.Size(224, 26);
            this.mbtnDelete.Text = "Xóa học viên";
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp A";
            // 
            // lstbA
            // 
            this.lstbA.FormattingEnabled = true;
            this.lstbA.ItemHeight = 22;
            this.lstbA.Location = new System.Drawing.Point(14, 21);
            this.lstbA.Name = "lstbA";
            this.lstbA.Size = new System.Drawing.Size(224, 268);
            this.lstbA.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstbA);
            this.panel1.Location = new System.Drawing.Point(132, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 306);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstbB);
            this.panel2.Location = new System.Drawing.Point(578, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 306);
            this.panel2.TabIndex = 6;
            // 
            // lstbB
            // 
            this.lstbB.FormattingEnabled = true;
            this.lstbB.ItemHeight = 22;
            this.lstbB.Location = new System.Drawing.Point(17, 21);
            this.lstbB.Name = "lstbB";
            this.lstbB.Size = new System.Drawing.Size(224, 268);
            this.lstbB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp B";
            // 
            // B1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "B1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mbtnUpdate;
        private System.Windows.Forms.ToolStripMenuItem mbtnCreate;
        private System.Windows.Forms.ToolStripMenuItem mbtnMoveToB;
        private System.Windows.Forms.ToolStripMenuItem mbtnMoveToA;
        private System.Windows.Forms.ToolStripMenuItem mbtnDelete;
        private System.Windows.Forms.ToolStripMenuItem mbtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstbB;
        private System.Windows.Forms.Label label2;
    }
}
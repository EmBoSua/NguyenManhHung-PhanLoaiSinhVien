using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4
{
    public partial class fStudentRights : Form
    {
        public fStudentRights()
        {
            InitializeComponent();
        }

        private void bảnĐiểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_SR_ScoresOfStudent f = new f_SR_ScoresOfStudent();
            f.MdiParent = this;
            f.Show();
        }

        private void fStudentRights_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show("Bạn có muốn đóng lại không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }*/
        }

        private void fStudentRights_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void gợiÝChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_SR_Specialized f = new f_SR_Specialized();
            f.MdiParent = this;
            f.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*fLogin f = new fLogin();
            f.Show();
            this.Close();*/
        }
    }
}

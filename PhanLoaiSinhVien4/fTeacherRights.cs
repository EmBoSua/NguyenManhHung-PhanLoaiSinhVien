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
    public partial class fTeacherRights : Form
    {
        public fTeacherRights()
        {
            InitializeComponent();
        }

        private void fTeacherRights_FormClosing(object sender, FormClosingEventArgs e)
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

        private void fTeacherRights_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void dfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_TR_MainClass f = new f_TR_MainClass();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýLớpTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInputScores f = new fInputScores();
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
            this.Parent.Show();
        }

        private void báoCáoĐiểmLớpTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBaoCaoDiemLopTinChi f = new fBaoCaoDiemLopTinChi();
            f.MdiParent = this;
            f.Show();
        }
    }
}

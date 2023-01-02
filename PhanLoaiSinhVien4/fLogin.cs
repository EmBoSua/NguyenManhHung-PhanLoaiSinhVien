using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;

namespace PhanLoaiSinhVien4
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        int dem = 0;
        private void fLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAccount_Click(object sender, EventArgs e)
        {
            txtAccount.BackColor = Color.White;
            pnAccount.BackColor = Color.White;
            txtPassword.BackColor = SystemColors.Control;
            pnPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtAccount.BackColor = SystemColors.Control;
            pnAccount.BackColor = SystemColors.Control;
            txtPassword.BackColor = Color.White;
            pnPassword.BackColor = Color.White;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void CheckLogin()
        {
            string query = "exec CheckDangNhap @Account , @Pass ";

            object[] obj = new object[2];
            obj[0] = txtAccount.Text;
            obj[1] = txtPassword.Text;

            DataTable table = DataProvider.Instance.ExcuteQuery(query, obj);

            if (table.Rows.Count <= 0)
            {
                lbError.Text = "Tài khoản hoặc mật khẩu không đúng !. (sai "+dem+"/3"+")";
                lbError.Visible = true;
                dem++;
                if(dem == 3)
                {
                    string qeurrK = @"update TaiKhoan
                                    set DangNhap = 0
                                    where TaiKhoan = '"+ txtAccount.Text + "'";

                    DataProvider.Instance.ExcuteNoneQuery(qeurrK);
                }


            }
            else
            {
                AccountDTO.Ma = table.Rows[0][0].ToString();
                AccountDTO.TaiKhoan = table.Rows[0][1].ToString();
                AccountDTO.MatKhau = table.Rows[0][2].ToString();
                AccountDTO.DangNhap = (int)table.Rows[0][3];

                switch (table.Rows[0][3])
                {
                    case 0:
                        lbError.Text = @"Tài khoản đã bị khóa, liên hệ với 'văn phòng khoa để cấp lại'.";
                        lbError.Visible = true;
                        break;
                    case 1:
                        fAdminRights fAdmin = new fAdminRights();
                        this.Hide();
                        fAdmin.ShowDialog();
                        this.Show();
                        txtAccount.Text = "";
                        txtPassword.Text = "";
                        dem = 0;
                        break;
                    case 2:
                        fTeacherRights fTeacher = new fTeacherRights();
                        this.Hide();
                        fTeacher.ShowDialog();
                        this.Show();
                        txtAccount.Text = "";
                        txtPassword.Text = "";
                        dem = 0;
                        break;
                    case 3:
                        fStudentRights fStudent = new fStudentRights();
                        this.Hide();
                        fStudent.ShowDialog();
                        this.Show();
                        txtAccount.Text = "";
                        txtPassword.Text = "";
                        dem = 0;
                        break;
                }
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

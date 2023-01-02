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
    public partial class fChangePassword : Form
    {
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {
            if (CheckChangePass())
            {
                string query = "exec UpdateTaiKhoan @Ma , @MatKhauMoi ";
                object[] obj = new object[2];
                obj[0] = AccountDTO.Ma;
                obj[1] = tbPasswordNew1.Text;

                int ck = DataProvider.Instance.ExcuteNoneQuery(query,obj);

                if(ck != 0)
                {
                    this.Close();
                    MessageBox.Show("Đổi mật khẩu thành công");
                }else
                    MessageBox.Show("Lỗi khi đổi tài khoản");
            }
        }

        private bool CheckChangePass()
        {
            if (string.IsNullOrEmpty(tbPasswordOld.Text))
            {
                SetErr("Không được bỏ trống", tbPasswordOld);
                return false;
            }

            if(" ".Contains(tbPasswordOld.Text))
            {
                SetErr("Không sử dụng ký tự Space", tbPasswordOld);
                return false;
            }

            if (string.IsNullOrEmpty(tbPasswordNew1.Text))
            {
                SetErr("Không được bỏ trống", tbPasswordNew1);
                return false;
            }

            if (" ".Contains(tbPasswordNew1.Text))
            {
                SetErr("Không sử dụng ký tự Space", tbPasswordNew1);
                return false;
            }


            if (tbPasswordNew1.Text.Length < 8 || tbPasswordNew1.Text.Length >50)
            {
                SetErr("Số ký tự phải từ 8 đến 50", tbPasswordNew1);
                return false;
            }
            
            if (string.IsNullOrEmpty(tbPasswordNew2.Text))
            {
                SetErr("Không được bỏ trống", tbPasswordNew2);
                return false;
            }

            if (" ".Contains(tbPasswordNew2.Text))
            {
                SetErr("Không sử dụng ký tự Space", tbPasswordNew2);
                return false;
            }

            if (tbPasswordNew2.Text.Length < 8 || tbPasswordNew2.Text.Length > 50)
            {
                SetErr("Số ký tự phải từ 8 đến 50", tbPasswordNew2);
                return false;
            }

            //MessageBox.Show(AccountDTO.MatKhau);

            if (!tbPasswordOld.Text.Equals(AccountDTO.MatKhau))
            {
                tbPasswordNew1.Text = "";
                tbPasswordNew2.Text = "";
                SetErr("Mật khẩu cũ không đúng", tbPasswordOld);
                return false;
            }

            if (!tbPasswordNew1.Text.Equals(tbPasswordNew2.Text))
            {
                tbPasswordNew1.Text = "";
                tbPasswordNew2.Text = "";
                SetErr("Mật khẩu mới nhập lần 2 không giống lần 1", tbPasswordNew1);
                return false;
            }

            return true;
        }

        private void SetErr(string err, Control ct)
        {
            tbErr.Visible = true;
            tbErr.Text = err;
            ct.Focus();
        }

        private void pbPasswordOld_MouseDown(object sender, MouseEventArgs e)
        {
            tbPasswordOld.UseSystemPasswordChar = false;
        }

        private void pbPasswordOld_MouseUp(object sender, MouseEventArgs e)
        {
            tbPasswordOld.UseSystemPasswordChar = true;
        }

        private void pbPasswordNew1_MouseDown(object sender, MouseEventArgs e)
        {
            tbPasswordNew1.UseSystemPasswordChar = false;
        }

        private void pbPasswordNew1_MouseUp(object sender, MouseEventArgs e)
        {
            tbPasswordNew1.UseSystemPasswordChar = true;
        }

        private void pbPasswordNew2_MouseDown(object sender, MouseEventArgs e)
        {
            tbPasswordNew2.UseSystemPasswordChar = false;
        }

        private void pbPasswordNew2_MouseUp(object sender, MouseEventArgs e)
        {
            tbPasswordNew2.UseSystemPasswordChar = true;
        }
    }
}

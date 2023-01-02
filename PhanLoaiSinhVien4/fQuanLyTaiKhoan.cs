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
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            string query = @"select Ma as N'Mã', TaiKhoan as N'Tài khoản', MatKhau as N'Mật khẩu',
                            case when DangNhap != 0 then N'Mở' else N'Khóa' end as N'Trạng thái'
                            from TaiKhoan where Ma not like 'AD10001'";

            DataTable table = DataProvider.Instance.ExcuteQuery(query);

            dgvAccount.DataSource = table;
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbCode.Text = dgvAccount.Rows[index].Cells[0].Value.ToString();
                tbPass.Text = dgvAccount.Rows[index].Cells[2].Value.ToString();
                if (!dgvAccount.Rows[index].Cells[3].ToString().Equals("Mở"))
                    rdoNotOk.Checked = true;
                else
                    rdoOK.Checked = true;
            }
        }

        private void btCancelText_Click(object sender, EventArgs e)
        {
            tbCode.Text = "";
            tbPass.Text = "";
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCode.Text))
            {
                int dangnhap;
                if (rdoNotOk.Checked == true)
                {
                    if (tbCode.Text.Contains("AD"))
                        dangnhap = 1;
                    else if (tbCode.Text.Contains("GV"))
                        dangnhap = 2;
                    else
                        dangnhap = 3;
                }
                else
                    dangnhap = 0;

                string query = @"exec UpdateTaiKhoan '"+tbCode.Text+"' , '"+tbPass.Text+"' , "+dangnhap+" ";

                try
                {
                    DataProvider.Instance.ExcuteNoneQuery(query);
                    MessageBox.Show("Đổi thành công");
                    tbCode.Text = "";
                    tbPass.Text = "";
                    LoadList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi "+ ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn tài khoản cần cập nhập");
            }
        }
    }
}

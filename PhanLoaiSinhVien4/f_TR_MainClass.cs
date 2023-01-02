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
    public partial class f_TR_MainClass : Form
    {
        DataView tbStudent = new DataView();

        public f_TR_MainClass()
        {
            InitializeComponent();
        }

        private void f_TR_MainClass_Load(object sender, EventArgs e)
        {
            LoadMainClass();
            LoadListStudentsOfMainClass();
        }

        private void LoadListStudentsOfMainClass()
        {
            DataRowView row = (DataRowView)cbMainClass.SelectedItem;
            string query = @"select MaSV as N'Mã sinh viên', TenSV as N'Tên sinh viên', GioiTinhSV as N'Giới tính', NgaySinhSV as N'Ngày sinh', EmailSV as N'Email', SdtSV as N'Số điện thoại', MaLHC as N'Mã lớp hành chính' 
                            from SinhVien as sv where sv.MaLHC = '" + row[0] + "'";
            try
            {
                /*if (tbStudent.ToTable().Rows.Count > 0)
                    tbStudent.ToTable().Clear();*/
                tbStudent = DataProvider.Instance.ExcuteQuery(query).DefaultView;
                dgvListStudent.DataSource = tbStudent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (f_TR_MainClass)\n" + ex.Message);
            }
        }

        private void LoadMainClass()
        {
            string query = @"select  MaLHC from LopHanhChinh 
                            where MaGV = '"+AccountDTO.Ma+"'  -- Year(NgayLap) = YEAR(GETDATE())";
            try
            {
                cbMainClass.DataSource = DataProvider.Instance.ExcuteQuery(query);
                cbMainClass.DisplayMember = "MaLHC";
                cbMainClass.ValueMember = "MaLHC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (MainClassDAO)\n" + ex.Message);
            }
        }

        private void cbMainClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadListStudentsOfMainClass();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string query = "";

            if (!string.IsNullOrEmpty(tbCode.Text))
                query += " [Mã sinh viên]" + " Like '%"+ tbCode.Text + "%' and ";
            if (!string.IsNullOrEmpty(tbName.Text))
                query += " [Tên sinh viên]" + " Like '%" + tbName.Text + "%' and ";
            if (!string.IsNullOrEmpty(tbEmail.Text))
                query += " [Email]" + " Like '%" + tbEmail.Text + "%' and ";
            if (!string.IsNullOrEmpty(tbPhone.Text))
                query += " [Số điện thoại]" + " Like '%" + tbPhone.Text + "%' and ";

            if (!string.IsNullOrEmpty(query))
                query = query.Substring(0,  query.LastIndexOf("and"));

            tbStudent.RowFilter = query;
            dgvListStudent.DataSource = tbStudent;
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            TeacherDAO.Instance.ExportExcel(dgvListStudent);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbCode.Text = "";
            tbName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
        }
    }
}

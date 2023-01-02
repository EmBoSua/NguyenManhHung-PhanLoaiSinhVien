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
    public partial class f_SR_ScoresOfStudent : Form
    {
        DataView table = new DataView();
        
        public f_SR_ScoresOfStudent()
        {
            InitializeComponent();
        }

        private void f_SR_ScoresOfStudent_Load(object sender, EventArgs e)
        {
            string query = @"select m.TenMon as N'Tên môn', SoTin as N'Số tín', lhp.MaLHP as N'Mã lớp', TenGV as N'Giảng viên', 
                            case when DATEDIFF(DAY,NgayKT, GETDATE()) > 10 then CONVERT(nvarchar(5), DiemM) else '?' end as 'Điểm môn'  
                            from DiemMonSinhVien as dmsv, LopHocPhan as lhp, Mon as m, GiangVien as gv 
                            where dmsv.MaLHP = lhp.MaLHP and lhp.MaM = m.MaM and lhp.MaGV = gv.MaGV and MaSV = '"+AccountDTO.Ma+"'";

            table = DataProvider.Instance.ExcuteQuery(query).DefaultView;

            dgvScores.DataSource = table;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string query = "[Tên môn]" + " Like '%" + tbSearch.Text + "%'";

            table.RowFilter = query;
            dgvScores.DataSource = table;
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            TeacherDAO.Instance.ExportExcel(dgvScores);
        }
    }
}


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
    public partial class f_SR_Specialized : Form
    {
        DataTable table;

        public f_SR_Specialized()
        {
            InitializeComponent();
        }

        private void f_SR_Specialized_Load(object sender, EventArgs e)
        {
            string query = @"select dm.CSLT, dm.CSDL, dm.LTHDT, dm.NTKW, dm.MMT, dm.QTM, dm.LTWE, 
                            case when dm.CNPM = 1 and dm.CSLT >=5 and dm.CSDL >=5 and dm.LTHDT >=5  then N'Đạt'
                            when dm.CNPM = 1 and dm.CSLT <5
                            or dm.CNPM = 1 and dm.CSDL <5
                            or dm.CNPM = 1 and dm.LTHDT <5  then N'Có khả năng'
                            else N'Không Đạt' end as 'CNPM',
                            case when dm.DPT = 1 and dm.CSLT >=5 and dm.CSDL >=5 and dm.LTHDT >=5  then N'Đạt'
                            when dm.DPT = 1 and dm.CSLT <5
                            or dm.DPT = 1 and dm.NTKW <5
                            or dm.DPT = 1 and dm.LTWE <5  then N'Có khả năng'
                            else N'Không Đạt' end as 'DPT',
                            case when dm.Mang = 1 and dm.CSLT >=5 and dm.CSDL >=5 and dm.LTHDT >=5  then N'Đạt'
                            when dm.Mang = 1 and dm.CSLT <5
                            or dm.Mang = 1 and dm.MMT <5
                            or dm.Mang = 1 and dm.QTM <5  then N'Có khả năng'
                            else N'Không Đạt' end as 'Mang'
                            from SinhVien as sv, km_data_2 as dm
                            where sv.MaSV = dm.MaSV and dm.MaSV = '" + AccountDTO.Ma+"'";

            table = DataProvider.Instance.ExcuteQuery(query);
            dataGridView1.DataSource = table;
        }
    }
}

    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace PhanLoaiSinhVien4
{
    public partial class fSpecialized : Form
    {
        DataTable dtPointFilter;
        string FilterData = " ";
        int Count;

        string strTitle = "";
        object[] ojbCNPM;
        object[] ojbDPT;
        object[] ojbMang;

        string[] MonCN;

        bool DulieuNgoai;

        DataTable tableReport;

        public fSpecialized()
        {
            InitializeComponent();
        }

        private void fSpecialized_Load(object sender, EventArgs e)
        {
        }

        private void btPointFilter_Click(object sender, EventArgs e)
        {
            fPointFilter f = new fPointFilter(dtPointFilter);
            f.ShowDialog();
            dtPointFilter = f.table;

            for (int i = 0; i < dtPointFilter.Rows.Count; i++)
            {
                DataRow row = dtPointFilter.Rows[i];
                FilterData += " " + row[0].ToString()
                    + " " + row[1].ToString()
                    + " " + row[2].ToString()
                    + " " + row[3].ToString();
            }
        }

        private void CheckSpecialized()
        {
            strTitle = "";
            Count = 0;
            int dem = 0;
            MonCN = new string[7];
            if (CNPM.Checked == true)
            {
                ojbCNPM = new object[6];
                ojbCNPM[0] = tbMon1_T_CNPM.Text;
                ojbCNPM[1] = tbMon2_T_CNPM.Text;
                ojbCNPM[2] = tbMon3_T_CNPM.Text;
                ojbCNPM[3] = tbMon1_F_CNPM.Text;
                ojbCNPM[4] = tbMon2_F_CNPM.Text;
                ojbCNPM[5] = tbMon3_F_CNPM.Text;

                Count++;
                strTitle += " CNPM -";

                MonCN[dem++] = "CSDL";
                MonCN[dem++] = "LTHDT";
            }
            
            if (DPT.Checked == true)
            {
                ojbDPT = new object[6];
                ojbDPT[0] = tbMon1_T_DPT.Text;
                ojbDPT[1] = tbMon2_T_DPT.Text;
                ojbDPT[2] = tbMon3_T_DPT.Text;
                ojbDPT[3] = tbMon1_F_DPT.Text;
                ojbDPT[4] = tbMon2_F_DPT.Text;
                ojbDPT[5] = tbMon3_F_DPT.Text;

                Count++;
                strTitle += " DPT -";

                MonCN[dem++] = "NTKW";
                MonCN[dem++] = "LTWE";
            }
            
            if (Mang.Checked == true)
            {
                ojbMang = new object[6];
                ojbMang[0] = tbMon1_T_Mang.Text;
                ojbMang[1] = tbMon2_T_Mang.Text;
                ojbMang[2] = tbMon3_T_Mang.Text;
                ojbMang[3] = tbMon1_F_Mang.Text;
                ojbMang[4] = tbMon2_F_Mang.Text;
                ojbMang[5] = tbMon3_F_Mang.Text;

                Count++;
                strTitle += " Mang -";

                MonCN[dem++] = "MMT";
                MonCN[dem++] = "QTM";
            }

            if(!string.IsNullOrEmpty(strTitle))
                strTitle = strTitle.Substring(0, strTitle.LastIndexOf("-"));
        }
        private void CNPM_CheckedChanged(object sender, EventArgs e)
        {
            plCNPM.Enabled = CNPM.Checked;
        }

        private void DPT_CheckedChanged(object sender, EventArgs e)
        {
            plDPT.Enabled = DPT.Checked;
        }

        private void Mang_CheckedChanged(object sender, EventArgs e)
        {
            plMang.Enabled = Mang.Checked;
        }

        private void Kmean()
        {
            string queryData;
            if (rdoBenNgoai.Checked)
            {
                queryData = "exec FilterData2 '" + FilterData + "'";
            }
            else
            {
                queryData = "exec FilterData '" + FilterData + "'";
            }


            DataProvider.Instance.ExcuteNoneQuery(queryData);

            //MessageBox.Show("Da loc xong");

            CheckSpecialized();

            string queryCNPM = "exec PhanCum_CNPM @M1T , @M2T , @M3T , @M1F , @M2F , @M3F ";
            if (CNPM.Checked)
                DataProvider.Instance.ExcuteNoneQuery(queryCNPM, ojbCNPM);

            //MessageBox.Show("Da chay xong CNPM");

            string queryDPT = "exec PhanCum_DPT @M1T , @M2T , @M3T , @M1F , @M2F , @M3F ";
            if (DPT.Checked)
                DataProvider.Instance.ExcuteNoneQuery(queryDPT, ojbDPT);

            string queryMang = "exec PhanCum_Mang @M1T , @M2T , @M3T , @M1F , @M2F , @M3F ";
            if (Mang.Checked)
                DataProvider.Instance.ExcuteNoneQuery(queryMang, ojbMang);
        }

        private void LoadDataView()
        {
            string cn = "";
            string query = "";
            string[] column = strTitle.Split('-');

            string inform = "";

            if (!rdoBenNgoai.Checked)
            {
                inform = "  sv.TenSV, sv.GioiTinhSV, sv.NgaySinhSV, sv.MaLHC, ";
            }
            else
            {
                inform = " 'TenSV' as 'TenSV', 'GioiTinhSV' as 'GioiTinhSV', 'NgaySinhSV' as 'NgaySinhSV', 'MaLHC' as 'MaLHC', ";
            }

            if (!string.IsNullOrEmpty(strTitle))
            {
                int dem1 = 0, dem2 = 0;
                for (int i = 0; i < column.Length; i++)
                {
                    //cn += " case when dm." + column[i].ToString().Trim() + " = 1 then N'Đạt' else N'Không đạt' end as 'CN" + (i + 1) + "', ";
                    cn += @" case when dm." + column[i].ToString().Trim() + " = 1 and dm.CSLT >=5 and dm."+MonCN[dem1++]+">=5 and dm."+ MonCN[dem1++] + ">=5  then N'Đạt' "
                           + " when dm." + column[i].ToString().Trim() + " = 1 and dm.CSLT <5 " +
                           " or dm." + column[i].ToString().Trim() + " = 1 and dm."+ MonCN[dem2++] + " <5 " +
                           " or dm." + column[i].ToString().Trim() + " = 1 and dm."+ MonCN[dem2++] + " <5  then N'Có khả năng' "
                           + " else N'Không Đạt' end as 'CN" + (i + 1) + "', ";
                }
                cn = cn.Substring(0, cn.LastIndexOf(","));

                query = "select sv.MaSV, " + inform
                               + " dm.CSLT, dm.CSDL, dm.LTHDT, dm.NTKW, dm.MMT, dm.QTM, dm.LTWE, "
                               + cn
                               + " from SinhVien as sv, km_data_2 as dm "
                               + " where sv.MaSV = dm.MaSV";
            }else
                query = "select sv.MaSV, " + inform
                               + " dm.CSLT, dm.CSDL, dm.LTHDT, dm.NTKW, dm.MMT, dm.QTM, dm.LTWE "
                               + " from SinhVien as sv, km_data_2 as dm "
                               + " where sv.MaSV = dm.MaSV";

            //MessageBox.Show(query);

            tableReport = DataProvider.Instance.ExcuteQuery(query);

            dgvSpecialized.DataSource = tableReport;
            dgvSpecialized.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvSpecialized.Columns["MaSV"].HeaderText = "Mã sinh viên";
            dgvSpecialized.Columns["TenSV"].HeaderText = "Tên sinh viên";
            dgvSpecialized.Columns["GioiTinhSV"].HeaderText = "Giới tính";
            dgvSpecialized.Columns["NgaySinhSV"].HeaderText = "Ngày sinh";
            dgvSpecialized.Columns["CSLT"].HeaderText = "CSLT";
            dgvSpecialized.Columns["CSDL"].HeaderText = "CSDL";
            dgvSpecialized.Columns["LTHDT"].HeaderText = "LTHDT";
            dgvSpecialized.Columns["NTKW"].HeaderText = "NTKW";
            dgvSpecialized.Columns["MMT"].HeaderText = "MMT";
            dgvSpecialized.Columns["QTM"].HeaderText = "QTM";
            dgvSpecialized.Columns["LTWE"].HeaderText = "LTWE";

            if(!string.IsNullOrEmpty(strTitle))
            for (int i = 0; i < column.Length; i++)
            {
                dgvSpecialized.Columns["CN" + (i + 1)].HeaderText = column[i].ToString().Trim();
            }

            btReport.Enabled = true;
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            try
            {
                Kmean();
                LoadDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (fSpecialized)\n" + ex.Message);
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            fCrystalReport f = new fCrystalReport(tableReport, strTitle);
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void rdoHeThong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHeThong.Checked)
            {
                DulieuNgoai = false;
            }
        }

        private void rdoBenNgoai_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBenNgoai.Checked)
            {
                fInputDataOutside f = new fInputDataOutside();
                f.ShowDialog();
                DulieuNgoai = f.DuLieuNgoai;
            }
        }
    }
}

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class fBaoCaoDiemLopTinChi : Form
    {
        public fBaoCaoDiemLopTinChi()
        {
            InitializeComponent();
        }

        private void LoadClass()
        {
            string query;
            if (!AccountDTO.Ma.Contains("AD"))
                query = "select MaLHP from LopHocPhan where MaGV = '"+AccountDTO.Ma+"'";
            else
                query = "select MaLHP from LopHocPhan";

            DataTable tbClass = DataProvider.Instance.ExcuteQuery(query);

            cbClass.DataSource = tbClass;
            cbClass.DisplayMember = "MaLHP";
            cbClass.ValueMember = "MaLHP";
        }

        private void fBaoCaoDiemLopTinChi_Load(object sender, EventArgs e)
        {
            LoadClass();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            string DieuKien = "";
            DieuKien += "{LopHocPhan.MaLHP} ='" + cbClass.Text + "'";

            showReport(@"E:\DangHoc\LapTrinhHuongSuKien\code\PhanLoaiSinhVien4\BaoCaoDiemLopTinChi.rpt", DieuKien);
        }

        public void showReport(string reportFileName, string recordFilter = "")
        {

            ReportDocument reportDocument = new ReportDocument();
            //string reportfile = string.Format("{0}\\CrystalReport\\{1}", Application.ExecutablePath, reportFileName);
            //MessageBox.Show(reportfile);
            reportDocument.Load(reportFileName);

            /*TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
            tableLogOnInfo.ConnectionInfo.ServerName = "NMH";
            tableLogOnInfo.ConnectionInfo.DatabaseName = "PhanLoaiSinhVien";
            tableLogOnInfo.ConnectionInfo.IntegratedSecurity = true;
            tableLogOnInfo.ConnectionInfo.UserID = "sa";
            tableLogOnInfo.ConnectionInfo.Password = "123";

            foreach (Table table in reportDocument.Database.Tables)
            {
                table.ApplyLogOnInfo(tableLogOnInfo);
            }*/

            if (!string.IsNullOrEmpty(recordFilter))
            {
                reportDocument.RecordSelectionFormula = recordFilter;
            }

            string queryUser = "select * from GiangVien where MaGV = '" + AccountDTO.Ma + "'";
            DataTable tbUser = DataProvider.Instance.ExcuteQuery(queryUser);

                
            TextObject Name = (TextObject)reportDocument.ReportDefinition.Sections["Section1"].ReportObjects["txtNameUser"];
            Name.Text = tbUser.Rows[0]["TenGV"].ToString();

            TextObject Email = (TextObject)reportDocument.ReportDefinition.Sections["Section1"].ReportObjects["txtEmail"];
            Email.Text = AccountDTO.TaiKhoan; 

            DateTime dt = DateTime.Now;
            TextObject Ngay = (TextObject)reportDocument.ReportDefinition.Sections["Section4"].ReportObjects["txtDateNow"];
            Ngay.Text = string.Format("{0:d}", dt);

            TextObject Gio = (TextObject)reportDocument.ReportDefinition.Sections["Section4"].ReportObjects["txtTimeNow"];
            Gio.Text = string.Format("{0:t}", dt);

            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            MessageBox.Show("date: "+string.Format("{0:t}", dt)+" - "+ string.Format("{0:d}", dt));
        }
    }
}

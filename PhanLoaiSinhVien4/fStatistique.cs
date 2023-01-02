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
    public partial class fStatistique : Form
    {
        string CN;

        int Tong, Dat, KhongDat;

        float D_M1L, D_M1N;
        float D_M1TB;
        float D_M2L, D_M2N;
        float D_M2TB;
        float D_M3L, D_M3N;
        float D_M3TB;

        float KD_M1L, KD_M1N;
        float KD_M1TB;
        float KD_M2L, KD_M2N;
        float KD_M2TB;
        float KD_M3L, KD_M3N;
        float KD_M3TB;

        public fStatistique(string ChuyenNganh)
        {
            InitializeComponent();
            CN = ChuyenNganh;
        }

        private void fStatistique_Load(object sender, EventArgs e)
        {
            string M1, M2, M3;
            switch (CN)
            {
                case "CNPM":
                    M1 = "CSLT";
                    M2 = "CSDL";
                    M3 = "LTHDT";
                    break;
                case "DPT":
                    M1 = "CSLT";
                    M2 = "NTKW";
                    M3 = "LTWE";
                    break;
                case "Mang":
                    M1 = "CSLT";
                    M2 = "MMT";
                    M3 = "QTM";
                    break;
                default:
                    M1 = "CSLT";
                    M2 = "MMT";
                    M3 = "QTM";
                    break;
            }
            try
            {
                Tong = (int)DataProvider.Instance.ExcuteScalar("select count(*) from km_data_2");
                txtTong.Text = Tong.ToString();

                // dat
                Dat = (int) DataProvider.Instance.ExcuteScalar("select count(*) from km_data_2 where " + CN + " = 1");
                txtDat.Text = ""+Dat+" (" + Math.Round((Dat / (float)Tong),4)*100 +"% )";

                txtMon1.Text = M1;
                //txtM1Lon.Text = DataProvider.Instance.ExcuteScalar("select MAX(" + M1 + ") from km_data_2 where " + CN + " = 1").ToString();
                txtM1TB.Text = DataProvider.Instance.ExcuteScalar("select ROUND(SUM("+ M1 +")/COUNT(*),2) from km_data_2 where " + CN + " = 1").ToString();
                //txtM1Nho.Text = DataProvider.Instance.ExcuteScalar("select MIN(" + M1 + ") from km_data_2 where " + CN + " = 1").ToString();

                txtMon2.Text = M2;
                //txtM2Lon.Text = DataProvider.Instance.ExcuteScalar("select MAX(" + M2 + ") from km_data_2 where " + CN + " = 1").ToString();
                txtM2TB.Text = DataProvider.Instance.ExcuteScalar("select ROUND(SUM(" + M2 + ")/COUNT(*),2) from km_data_2 where " + CN + " = 1").ToString();
                //txtM2Nho.Text = DataProvider.Instance.ExcuteScalar("select MIN(" + M2 + ") from km_data_2 where " + CN + " = 1").ToString();

                txtMon3.Text = M3;
                //txtM3Lon.Text = DataProvider.Instance.ExcuteScalar("select MAX(" + M3 + ") from km_data_2 where " + CN + " = 1").ToString();
                txtM3TB.Text = DataProvider.Instance.ExcuteScalar("select ROUND(SUM(" + M3 + ")/COUNT(*),2) from km_data_2 where " + CN + " = 1").ToString();
                //txtM3Nho.Text = DataProvider.Instance.ExcuteScalar("select MIN(" + M3 + ") from km_data_2 where " + CN + " = 1").ToString();

                // khong dat
                KhongDat = (int)DataProvider.Instance.ExcuteScalar("select count(*) from km_data_2 where " + CN + " = 0");
                txtKhongDat.Text = "" + KhongDat + " (" + Math.Round((KhongDat / (float)Tong), 4) * 100 + "% )";

                txtMon1_kd.Text = M1;
                //txtM1Lon_kd.Text = DataProvider.Instance.ExcuteScalar("select MAX(" + M1 + ") from km_data_2 where " + CN + " = 0").ToString();
                txtM1TB_kd.Text = DataProvider.Instance.ExcuteScalar("select ROUND(SUM(" + M1 + ")/COUNT(*),2) from km_data_2 where " + CN + " = 0").ToString();
                //txtM1Nho_kd.Text = DataProvider.Instance.ExcuteScalar("select MIN(" + M1 + ") from km_data_2 where " + CN + " = 0").ToString();

                txtMon2_kd.Text = M2;
                //txtM2Lon_kd.Text = DataProvider.Instance.ExcuteScalar("select MAX(" + M2 + ") from km_data_2 where " + CN + " = 0").ToString();
                txtM2TB_kd.Text = DataProvider.Instance.ExcuteScalar("select ROUND(SUM(" + M2 + ")/COUNT(*),2) from km_data_2 where " + CN + " = 0").ToString();
                //txtM2Nho_kd.Text = DataProvider.Instance.ExcuteScalar("select MIN(" + M2 + ") from km_data_2 where " + CN + " = 0").ToString();

                txtMon3_kd.Text = M3;
                //txtM3Lon_kd.Text = DataProvider.Instance.ExcuteScalar("select MAX(" + M3 + ") from km_data_2 where " + CN + " = 0").ToString();
                txtM3TB_kd.Text = DataProvider.Instance.ExcuteScalar("select ROUND(SUM(" + M3 + ")/COUNT(*),2) from km_data_2 where " + CN + " = 0").ToString();
                //txtM3Nho_kd.Text = DataProvider.Instance.ExcuteScalar("select MIN(" + M3 + ") from km_data_2 where " + CN + " = 0").ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL\n"+ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace PhanLoaiSinhVien4
{
    public partial class fCrystalReport : Form
    {
        DataTable table;
        string strTitle;
        string[] cn;
        string tableName;

        ReportClass BaoCao;

        string formula = "";

        public fCrystalReport(DataTable table, string strTitle)
        {
            InitializeComponent();
            LoadMainClass();

            this.table = table;
            this.strTitle = strTitle;
            this.cn = strTitle.Split('-');

            if (!string.IsNullOrEmpty(strTitle))
            {
                rdoAll.Enabled = true;
                rdoOK.Enabled = true;
                rdoNotOk.Enabled = true;
                rdoAbility.Visible = true;

                switch (cn.Length)
                {
                    case 1:
                        tableName = "BaoCao1";
                        BaoCao = new BaoCao1();
                        ViewCrystal();
                        SetTextCrystal(BaoCao, "Section1", "txtCN", "VÀO CHUYÊN NGÀNH " + cn[0].Trim());
                        btThongKe.Enabled = true;
                        break;
                    case 2:
                        tableName = "BaoCao2";
                        BaoCao = new BaoCao2();
                        ViewCrystal();
                        SetTextCrystal(BaoCao, "Section1", "txtCN", "VÀO CHUYÊN NGÀNH " + cn[0].Trim() + " VÀ " + cn[1].Trim());
                        break;
                    case 3:
                        tableName = "BaoCao3";
                        table.TableName = tableName;
                        BaoCao = new BaoCao3();
                        ViewCrystal();
                        SetTextCrystal(BaoCao, "Section1", "txtCN", "VÀO TỪNG CHUYÊN NGÀNH");
                        break;
                }
            }
            else
            {
                tableName = "BaoCao0";
                BaoCao = new BaoCao0();
                ViewCrystal();
            }
        }

        private void ViewCrystal()
        {
            table.TableName = tableName;
            BaoCao.SetDataSource(table);
            crvSpecialized.ReportSource = BaoCao;
            if(!string.IsNullOrEmpty(strTitle))
                for(int i = 0; i < cn.Length; i++)
                    SetTextCrystal(BaoCao, "Section2", "clCN"+(i+1), cn[i].Trim());
        }

        private void SetTextCrystal(ReportClass BaoCao, string section, string Name, string value)
        {
            TextObject ChuyenNganh = (TextObject)BaoCao.ReportDefinition.Sections[section].ReportObjects[Name];
            ChuyenNganh.Text = value;
        }

        private void LoadMainClass()
        {
            string query = @"select distinct MaLHC 
                            from km_data_2 as d, SinhVien as sv
                            where sv.MaSV = d.MaSV
                            order by MaLHC asc";
            List<string> lsClass = new List<string>();
            lsClass.Add("Tất cả");
            try
            {
                DataTable tb = DataProvider.Instance.ExcuteQuery(query);
                for (int i = 0; i < tb.Rows.Count; i++)
                    lsClass.Add(tb.Rows[i][0].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL\n"+ex.ToString());
            }
            
            cbMainClass.DataSource = lsClass;
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAll.Checked)
            {
                formula = "";

                BaoCao.RecordSelectionFormula = formula;
                crvSpecialized.ReportSource = BaoCao;

                cbMainClass.Text = "Tất cả";
            }
        }

        private void rdoOK_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOK.Checked)
            {
                formula = "";
                for (int i = 0; i < cn.Length; i++)
                    formula += "{" + tableName + ".CN" + (i + 1) + "} = 'Đạt' and ";

                formula = formula.Substring(0, formula.LastIndexOf("and"));

                BaoCao.RecordSelectionFormula = formula;
                crvSpecialized.ReportSource = BaoCao;

                cbMainClass.Text = "Tất cả";
            }
        }

        private void rdoNotOk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNotOk.Checked)
            {
                formula = "";
                for (int i = 0; i < cn.Length; i++)
                    formula += "{" + tableName + ".CN" + (i + 1) + "} = 'Không đạt' and ";         

                formula = formula.Substring(0, formula.LastIndexOf("and"));

                BaoCao.RecordSelectionFormula = formula;
                crvSpecialized.ReportSource = BaoCao;

                cbMainClass.Text = "Tất cả";
            }
        }

        private void rdoAbility_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAbility.Checked)
            {
                formula = "";
                for (int i = 0; i < cn.Length; i++)
                    formula += "{" + tableName + ".CN" + (i + 1) + "} = 'Có khả năng' and ";

                formula = formula.Substring(0, formula.LastIndexOf("and"));

                BaoCao.RecordSelectionFormula = formula;
                crvSpecialized.ReportSource = BaoCao;

                cbMainClass.Text = "Tất cả";
            }
        }

        bool first = true;

        private void cbMainClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!first)
            {
                string formula2 = formula;
                if (!rdoAll.Checked) // nếu không check vào tất cả
                {
                    if (!cbMainClass.Text.ToString().Equals("Tất cả")) // nếu không select vào tất cả
                        formula2 += " and {" + tableName + ".MaLHC} = '" + cbMainClass.Text + "'";
                }
                else// nếu check vào tất cả
                    if (!cbMainClass.Text.ToString().Equals("Tất cả")) // nếu không select vào tất cả
                        formula2 += " {" + tableName + ".MaLHC} = '" + cbMainClass.Text + "'";

                BaoCao.RecordSelectionFormula = formula2;
                crvSpecialized.ReportSource = BaoCao;
            }
            else
                first = false;
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            fStatistique f = new fStatistique(cn[0].Trim());
            f.MdiParent = this.MdiParent;
            f.Show();
        }

    }
}

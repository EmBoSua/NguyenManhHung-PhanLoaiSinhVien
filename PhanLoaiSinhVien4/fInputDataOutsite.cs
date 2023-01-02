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
    public partial class fInputDataOutside : Form
    {
        private DataTable table;
        private int[] Choose = new int[8];

        public bool addNew = false;

        public bool DuLieuNgoai { get; set; }

        public fInputDataOutside()
        {
            InitializeComponent();

            DuLieuNgoai = false;
            this.cbCode.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbCSLT.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbCSDL.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbLTHDT.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbNTKW.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbMMT.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbQTM.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbLTWE.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void btIPChooseFile_Click(object sender, EventArgs e)
        {
            table = DataProvider.Instance.ImportExcel();
            if (table.Rows.Count > 0)
            {
                dgvListStudent.DataSource = table;
                ListNameColumn();
            }
            else
                MessageBox.Show("Bạn chưa chọn file!");
        }

        private void ListNameColumn()
        {
            List<string> column0 = new List<string>();
            column0.Add("Chọn");
            List<string> column1 = new List<string>();
            column1.Add("Chọn");
            List<string> column2 = new List<string>();
            column2.Add("Chọn");
            List<string> column3 = new List<string>();
            column3.Add("Chọn");
            List<string> column4 = new List<string>();
            column4.Add("Chọn");
            List<string> column5 = new List<string>();
            column5.Add("Chọn");
            List<string> column6 = new List<string>();
            column6.Add("Chọn");

            List<string> column7 = new List<string>();
            column7.Add("Chọn");

            for (int i = 0; i < table.Columns.Count; i++)
            {
                column0.Add(table.Columns[i].ColumnName);
                column1.Add(table.Columns[i].ColumnName);
                column2.Add(table.Columns[i].ColumnName);
                column3.Add(table.Columns[i].ColumnName);
                column4.Add(table.Columns[i].ColumnName);
                column5.Add(table.Columns[i].ColumnName);
                column6.Add(table.Columns[i].ColumnName);
                column7.Add(table.Columns[i].ColumnName);
            }

            cbCode.DataSource = column0;
            cbCSLT.DataSource = column1;
            cbCSDL.DataSource = column2;
            cbLTHDT.DataSource = column3;
            cbNTKW.DataSource = column4;
            cbMMT.DataSource = column5;
            cbQTM.DataSource = column6;
            cbLTWE.DataSource = column7;
        }

        #region event combobox
        private void cbIPCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPCode_Click(object sender, EventArgs e)
        {
            cbCode.DroppedDown = true;
        }

        private void cbIPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPName_Click(object sender, EventArgs e)
        {
            cbCSLT.DroppedDown = true;
        }

        private void cbIPSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPSex_Click(object sender, EventArgs e)
        {
            cbCSDL.DroppedDown = true;
        }

        private void cbIPDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPDate_Click(object sender, EventArgs e)
        {
            cbLTHDT.DroppedDown = true;
        }

        private void cbIPEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPEmail_Click(object sender, EventArgs e)
        {
            cbNTKW.DroppedDown = true;
        }

        private void cbIPPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPPhone_Click(object sender, EventArgs e)
        {
            cbMMT.DroppedDown = true;
        }

        private void cbIPClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPClass_Click(object sender, EventArgs e)
        {
            cbQTM.DroppedDown = true;
        }

        private void CheckSelect(ComboBox cb, int stt, int[] nho)
        {
            if (cb.SelectedIndex == 0)
            {
                nho[stt] = 0;
            }
            else
            {
                bool ok = true;
                for (int i = 0; i < nho.Length; i++)
                {
                    if (i != stt && cb.SelectedIndex == nho[i])
                    {
                        ok = false;
                    }
                }
                if (ok)
                {
                    nho[stt] = cb.SelectedIndex;
                }
                else
                {
                    cb.SelectedIndex = nho[stt];
                }
            }
        }

        private void cbIPCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbCode, 0, Choose);
        }

        private void cbIPName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbCSLT, 1, Choose);
        }

        private void cbIPSex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbCSDL, 2, Choose);
        }

        private void cbIPDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbLTHDT, 3, Choose);
        }

        private void cbIPEmail_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbNTKW, 4, Choose);
        }

        private void cbIPPhone_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbMMT, 5, Choose);
        }

        private void cbIPClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbQTM, 6, Choose);
        }

        Font fontT = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        Font fontF = new Font("Microsoft Sans Serif", 8, FontStyle.Strikeout);

        private void SetSelect(ComboBox cb, DrawItemEventArgs e, int[] nho)
        {
            if (e.Index == 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(cb.Items[e.Index].ToString(), fontT, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
            else if ((e.Index == nho[0] || e.Index == nho[1] || e.Index == nho[2] ||
                e.Index == nho[3] || e.Index == nho[4] || e.Index == nho[5] || e.Index == nho[6] || e.Index == nho[7]))
                e.Graphics.DrawString(cb.Items[e.Index].ToString(), fontF, Brushes.LightSlateGray, e.Bounds);
            else
            {
                e.DrawBackground();
                e.Graphics.DrawString(cb.Items[e.Index].ToString(), fontT, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void cbIPCode_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbCode, e, Choose);
        }

        private void cbIPName_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbCSLT, e, Choose);
        }

        private void cbIPSex_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbCSDL, e, Choose);
        }

        private void cbIPDate_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbLTHDT, e, Choose);
        }

        private void cbIPEmail_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbNTKW, e, Choose);
        }

        private void cbIPPhone_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbMMT, e, Choose);
        }

        private void cbIPClass_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbQTM, e, Choose);
        }

        #endregion

        private bool CheckInput()
        {
            if (!CheckChoose(cbCode, erCode) ||
                !CheckChoose(cbCSLT, erName) ||
                !CheckChoose(cbCSDL, erGender) ||
                !CheckChoose(cbLTHDT, erBirthday) ||
                !CheckChoose(cbNTKW, erEmail) ||
                !CheckChoose(cbMMT, erPhone) ||
                !CheckChoose(cbQTM, erCode) ||
                !CheckChoose(cbLTWE, erCode))
                return false;

            return true;
        }

        private bool CheckChoose(ComboBox control, ErrorProvider er)
        {
            if (control.Text.Equals("Chọn"))
            {
                control.DroppedDown = true;
                er.SetError(control, "Bạn chưa chọn");
                return false;
            }
            else
            {
                er.SetError(control, "");
                return true;
            }
        }

        private void btIPOK_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string[] column = new string[]
                {
                    cbCode.Text,
                    cbCSLT.Text,
                    cbCSDL.Text,
                    cbLTHDT.Text,
                    cbNTKW.Text,
                    cbMMT.Text,
                    cbQTM.Text,
                    cbLTWE.Text,
                };

                dgvListStudent = MainClassDAO.Instance.AddTo_Km_data_2(column, dgvListStudent);

                if (dgvListStudent.Rows.Count > 0)
                    MessageBox.Show("Có " + table.Rows.Count + " dòng không thể thêm");
                else
                {
                    addNew = true;
                    MessageBox.Show("Hoàn thành.");
                    DuLieuNgoai = true;
                    this.Close();
                }
            }
        }

        private void cbLTWE_Click(object sender, EventArgs e)
        {
            cbLTWE.DroppedDown = true;
        }

        private void cbLTWE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbLTWE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbLTWE, 7, Choose);
        }

        private void cbLTWE_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbLTWE, e, Choose);
        }
    }
}


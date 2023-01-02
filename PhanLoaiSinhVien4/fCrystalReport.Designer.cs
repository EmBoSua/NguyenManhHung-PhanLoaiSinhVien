
namespace PhanLoaiSinhVien4
{
    partial class fCrystalReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crvSpecialized = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAbility = new System.Windows.Forms.RadioButton();
            this.btThongKe = new System.Windows.Forms.Button();
            this.cbMainClass = new System.Windows.Forms.ComboBox();
            this.rdoNotOk = new System.Windows.Forms.RadioButton();
            this.rdoOK = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.crvSpecialized);
            this.groupBox2.Location = new System.Drawing.Point(145, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 533);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // crvSpecialized
            // 
            this.crvSpecialized.ActiveViewIndex = -1;
            this.crvSpecialized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSpecialized.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSpecialized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSpecialized.Location = new System.Drawing.Point(3, 16);
            this.crvSpecialized.Name = "crvSpecialized";
            this.crvSpecialized.Size = new System.Drawing.Size(794, 514);
            this.crvSpecialized.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.rdoAbility);
            this.groupBox1.Controls.Add(this.btThongKe);
            this.groupBox1.Controls.Add(this.cbMainClass);
            this.groupBox1.Controls.Add(this.rdoNotOk);
            this.groupBox1.Controls.Add(this.rdoOK);
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 533);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiển";
            // 
            // rdoAbility
            // 
            this.rdoAbility.AutoSize = true;
            this.rdoAbility.Location = new System.Drawing.Point(6, 202);
            this.rdoAbility.Name = "rdoAbility";
            this.rdoAbility.Size = new System.Drawing.Size(86, 17);
            this.rdoAbility.TabIndex = 5;
            this.rdoAbility.Text = "Có khả năng";
            this.rdoAbility.UseVisualStyleBackColor = true;
            this.rdoAbility.Visible = false;
            this.rdoAbility.CheckedChanged += new System.EventHandler(this.rdoAbility_CheckedChanged);
            // 
            // btThongKe
            // 
            this.btThongKe.Enabled = false;
            this.btThongKe.Location = new System.Drawing.Point(6, 29);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(121, 23);
            this.btThongKe.TabIndex = 4;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // cbMainClass
            // 
            this.cbMainClass.FormattingEnabled = true;
            this.cbMainClass.Location = new System.Drawing.Point(6, 251);
            this.cbMainClass.Name = "cbMainClass";
            this.cbMainClass.Size = new System.Drawing.Size(121, 21);
            this.cbMainClass.TabIndex = 3;
            this.cbMainClass.Visible = false;
            this.cbMainClass.SelectedIndexChanged += new System.EventHandler(this.cbMainClass_SelectedIndexChanged);
            // 
            // rdoNotOk
            // 
            this.rdoNotOk.AutoSize = true;
            this.rdoNotOk.Enabled = false;
            this.rdoNotOk.Location = new System.Drawing.Point(6, 160);
            this.rdoNotOk.Name = "rdoNotOk";
            this.rdoNotOk.Size = new System.Drawing.Size(75, 17);
            this.rdoNotOk.TabIndex = 2;
            this.rdoNotOk.Text = "Không đạt";
            this.rdoNotOk.UseVisualStyleBackColor = true;
            this.rdoNotOk.CheckedChanged += new System.EventHandler(this.rdoNotOk_CheckedChanged);
            // 
            // rdoOK
            // 
            this.rdoOK.AutoSize = true;
            this.rdoOK.Enabled = false;
            this.rdoOK.Location = new System.Drawing.Point(6, 113);
            this.rdoOK.Name = "rdoOK";
            this.rdoOK.Size = new System.Drawing.Size(42, 17);
            this.rdoOK.TabIndex = 1;
            this.rdoOK.Text = "Đạt";
            this.rdoOK.UseVisualStyleBackColor = true;
            this.rdoOK.CheckedChanged += new System.EventHandler(this.rdoOK_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Enabled = false;
            this.rdoAll.Location = new System.Drawing.Point(6, 67);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(56, 17);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "Tất cả";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // fCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fCrystalReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In dữ liệu";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSpecialized;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNotOk;
        private System.Windows.Forms.RadioButton rdoOK;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.ComboBox cbMainClass;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.RadioButton rdoAbility;
    }
}
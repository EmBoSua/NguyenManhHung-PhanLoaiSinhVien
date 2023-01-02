
namespace PhanLoaiSinhVien4
{
    partial class fInputDataOutside
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.dgvListStudent = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cbQTM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMMT = new System.Windows.Forms.ComboBox();
            this.cbNTKW = new System.Windows.Forms.ComboBox();
            this.cbLTHDT = new System.Windows.Forms.ComboBox();
            this.cbCSDL = new System.Windows.Forms.ComboBox();
            this.cbCSLT = new System.Windows.Forms.ComboBox();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.btChooseFile = new System.Windows.Forms.Button();
            this.erCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.erName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.erBirthday = new System.Windows.Forms.ErrorProvider(this.components);
            this.erEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.erClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbLTWE = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLTWE);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Controls.Add(this.dgvListStudent);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbQTM);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbMMT);
            this.panel1.Controls.Add(this.cbNTKW);
            this.panel1.Controls.Add(this.cbLTHDT);
            this.panel1.Controls.Add(this.cbCSDL);
            this.panel1.Controls.Add(this.cbCSLT);
            this.panel1.Controls.Add(this.cbCode);
            this.panel1.Controls.Add(this.btChooseFile);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 512);
            this.panel1.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(758, 12);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 17;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btIPOK_Click);
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AllowUserToAddRows = false;
            this.dgvListStudent.AllowUserToDeleteRows = false;
            this.dgvListStudent.AllowUserToResizeColumns = false;
            this.dgvListStudent.AllowUserToResizeRows = false;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Location = new System.Drawing.Point(11, 121);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.ReadOnly = true;
            this.dgvListStudent.RowHeadersVisible = false;
            this.dgvListStudent.Size = new System.Drawing.Size(822, 382);
            this.dgvListStudent.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "LTWE";
            // 
            // cbQTM
            // 
            this.cbQTM.FormattingEnabled = true;
            this.cbQTM.Location = new System.Drawing.Point(639, 80);
            this.cbQTM.Name = "cbQTM";
            this.cbQTM.Size = new System.Drawing.Size(88, 21);
            this.cbQTM.TabIndex = 14;
            this.cbQTM.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPClass_DrawItem);
            this.cbQTM.SelectionChangeCommitted += new System.EventHandler(this.cbIPClass_SelectionChangeCommitted);
            this.cbQTM.Click += new System.EventHandler(this.cbIPClass_Click);
            this.cbQTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPClass_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "MMT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "NTKW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "LTHDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CSDL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CSLT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sinh viên";
            // 
            // cbMMT
            // 
            this.cbMMT.FormattingEnabled = true;
            this.cbMMT.Location = new System.Drawing.Point(535, 80);
            this.cbMMT.Name = "cbMMT";
            this.cbMMT.Size = new System.Drawing.Size(88, 21);
            this.cbMMT.TabIndex = 7;
            this.cbMMT.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPEmail_DrawItem);
            this.cbMMT.SelectionChangeCommitted += new System.EventHandler(this.cbIPPhone_SelectionChangeCommitted);
            this.cbMMT.Click += new System.EventHandler(this.cbIPPhone_Click);
            this.cbMMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPPhone_KeyPress);
            // 
            // cbNTKW
            // 
            this.cbNTKW.FormattingEnabled = true;
            this.cbNTKW.Location = new System.Drawing.Point(431, 80);
            this.cbNTKW.Name = "cbNTKW";
            this.cbNTKW.Size = new System.Drawing.Size(88, 21);
            this.cbNTKW.TabIndex = 6;
            this.cbNTKW.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPEmail_DrawItem);
            this.cbNTKW.SelectionChangeCommitted += new System.EventHandler(this.cbIPEmail_SelectionChangeCommitted);
            this.cbNTKW.Click += new System.EventHandler(this.cbIPEmail_Click);
            this.cbNTKW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPEmail_KeyPress);
            // 
            // cbLTHDT
            // 
            this.cbLTHDT.FormattingEnabled = true;
            this.cbLTHDT.Location = new System.Drawing.Point(326, 80);
            this.cbLTHDT.Name = "cbLTHDT";
            this.cbLTHDT.Size = new System.Drawing.Size(88, 21);
            this.cbLTHDT.TabIndex = 5;
            this.cbLTHDT.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPDate_DrawItem);
            this.cbLTHDT.SelectionChangeCommitted += new System.EventHandler(this.cbIPDate_SelectionChangeCommitted);
            this.cbLTHDT.Click += new System.EventHandler(this.cbIPDate_Click);
            this.cbLTHDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPDate_KeyPress);
            // 
            // cbCSDL
            // 
            this.cbCSDL.FormattingEnabled = true;
            this.cbCSDL.Location = new System.Drawing.Point(222, 80);
            this.cbCSDL.Name = "cbCSDL";
            this.cbCSDL.Size = new System.Drawing.Size(88, 21);
            this.cbCSDL.TabIndex = 4;
            this.cbCSDL.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPSex_DrawItem);
            this.cbCSDL.SelectionChangeCommitted += new System.EventHandler(this.cbIPSex_SelectionChangeCommitted);
            this.cbCSDL.Click += new System.EventHandler(this.cbIPSex_Click);
            this.cbCSDL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPSex_KeyPress);
            // 
            // cbCSLT
            // 
            this.cbCSLT.FormattingEnabled = true;
            this.cbCSLT.Location = new System.Drawing.Point(116, 80);
            this.cbCSLT.Name = "cbCSLT";
            this.cbCSLT.Size = new System.Drawing.Size(88, 21);
            this.cbCSLT.TabIndex = 3;
            this.cbCSLT.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPName_DrawItem);
            this.cbCSLT.SelectionChangeCommitted += new System.EventHandler(this.cbIPName_SelectionChangeCommitted);
            this.cbCSLT.Click += new System.EventHandler(this.cbIPName_Click);
            this.cbCSLT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPName_KeyPress);
            // 
            // cbCode
            // 
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(11, 80);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(88, 21);
            this.cbCode.TabIndex = 2;
            this.cbCode.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPCode_DrawItem);
            this.cbCode.SelectionChangeCommitted += new System.EventHandler(this.cbIPCode_SelectionChangeCommitted);
            this.cbCode.Click += new System.EventHandler(this.cbIPCode_Click);
            this.cbCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPCode_KeyPress);
            // 
            // btChooseFile
            // 
            this.btChooseFile.AutoSize = true;
            this.btChooseFile.Location = new System.Drawing.Point(11, 10);
            this.btChooseFile.Name = "btChooseFile";
            this.btChooseFile.Size = new System.Drawing.Size(117, 23);
            this.btChooseFile.TabIndex = 0;
            this.btChooseFile.Text = "Chooe and Read File";
            this.btChooseFile.UseVisualStyleBackColor = true;
            this.btChooseFile.Click += new System.EventHandler(this.btIPChooseFile_Click);
            // 
            // erCode
            // 
            this.erCode.ContainerControl = this;
            // 
            // erName
            // 
            this.erName.ContainerControl = this;
            // 
            // erGender
            // 
            this.erGender.ContainerControl = this;
            // 
            // erBirthday
            // 
            this.erBirthday.ContainerControl = this;
            // 
            // erEmail
            // 
            this.erEmail.ContainerControl = this;
            // 
            // erPhone
            // 
            this.erPhone.ContainerControl = this;
            // 
            // erClass
            // 
            this.erClass.ContainerControl = this;
            // 
            // cbLTWE
            // 
            this.cbLTWE.FormattingEnabled = true;
            this.cbLTWE.Location = new System.Drawing.Point(743, 80);
            this.cbLTWE.Name = "cbLTWE";
            this.cbLTWE.Size = new System.Drawing.Size(88, 21);
            this.cbLTWE.TabIndex = 18;
            this.cbLTWE.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbLTWE_DrawItem);
            this.cbLTWE.SelectionChangeCommitted += new System.EventHandler(this.cbLTWE_SelectionChangeCommitted);
            this.cbLTWE.Click += new System.EventHandler(this.cbLTWE_Click);
            this.cbLTWE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLTWE_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "QTM";
            // 
            // fInputDataOutside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 518);
            this.Controls.Add(this.panel1);
            this.Name = "fInputDataOutside";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sinh viên từ excel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btChooseFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMMT;
        private System.Windows.Forms.ComboBox cbNTKW;
        private System.Windows.Forms.ComboBox cbLTHDT;
        private System.Windows.Forms.ComboBox cbCSDL;
        private System.Windows.Forms.ComboBox cbCSLT;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbQTM;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.ErrorProvider erCode;
        private System.Windows.Forms.ErrorProvider erName;
        private System.Windows.Forms.ErrorProvider erGender;
        private System.Windows.Forms.ErrorProvider erBirthday;
        private System.Windows.Forms.ErrorProvider erEmail;
        private System.Windows.Forms.ErrorProvider erPhone;
        private System.Windows.Forms.ErrorProvider erClass;
        private System.Windows.Forms.ComboBox cbLTWE;
        private System.Windows.Forms.Label label8;
    }
}
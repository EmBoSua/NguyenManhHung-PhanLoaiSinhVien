
namespace PhanLoaiSinhVien4
{
    partial class f_TR_MainClass
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
            this.dgvListStudent = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btExport = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbMainClass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListStudent);
            this.groupBox2.Location = new System.Drawing.Point(201, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 450);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AllowUserToAddRows = false;
            this.dgvListStudent.AllowUserToDeleteRows = false;
            this.dgvListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListStudent.Location = new System.Drawing.Point(3, 16);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.ReadOnly = true;
            this.dgvListStudent.RowHeadersVisible = false;
            this.dgvListStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListStudent.Size = new System.Drawing.Size(593, 431);
            this.dgvListStudent.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btExport);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 450);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều khiển";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(9, 415);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 13;
            this.btExport.Text = "Xuất excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(111, 371);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 12;
            this.btSearch.Text = "Tìm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbPhone);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(6, 224);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(183, 46);
            this.panel6.TabIndex = 11;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(3, 21);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(177, 20);
            this.tbPhone.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbEmail);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 46);
            this.panel5.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(3, 21);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(177, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 46);
            this.panel2.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(177, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sinh viên";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbCode);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(6, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(183, 46);
            this.panel8.TabIndex = 7;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(3, 21);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(177, 20);
            this.tbCode.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã sinh viên";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbMainClass);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(6, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(183, 46);
            this.panel7.TabIndex = 1;
            // 
            // cbMainClass
            // 
            this.cbMainClass.FormattingEnabled = true;
            this.cbMainClass.Location = new System.Drawing.Point(3, 21);
            this.cbMainClass.Name = "cbMainClass";
            this.cbMainClass.Size = new System.Drawing.Size(177, 21);
            this.cbMainClass.TabIndex = 1;
            this.cbMainClass.SelectionChangeCommitted += new System.EventHandler(this.cbMainClass_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã lớp hành chính";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(9, 371);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Hủy nhập";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // f_TR_MainClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "f_TR_MainClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp hành chính";
            this.Load += new System.EventHandler(this.f_TR_MainClass_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbMainClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCancel;
    }
}
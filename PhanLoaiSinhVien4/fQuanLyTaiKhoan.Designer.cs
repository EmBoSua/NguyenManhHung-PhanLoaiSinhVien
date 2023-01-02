
namespace PhanLoaiSinhVien4
{
    partial class fQuanLyTaiKhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancelText = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.rdoOK = new System.Windows.Forms.RadioButton();
            this.rdoNotOk = new System.Windows.Forms.RadioButton();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btCancelText);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.rdoOK);
            this.groupBox1.Controls.Add(this.rdoNotOk);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều khiển";
            // 
            // btCancelText
            // 
            this.btCancelText.Location = new System.Drawing.Point(59, 221);
            this.btCancelText.Name = "btCancelText";
            this.btCancelText.Size = new System.Drawing.Size(75, 23);
            this.btCancelText.TabIndex = 7;
            this.btCancelText.Text = "Hủy";
            this.btCancelText.UseVisualStyleBackColor = true;
            this.btCancelText.Click += new System.EventHandler(this.btCancelText_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(59, 177);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Cập nhập";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // rdoOK
            // 
            this.rdoOK.AutoSize = true;
            this.rdoOK.Checked = true;
            this.rdoOK.Location = new System.Drawing.Point(7, 137);
            this.rdoOK.Name = "rdoOK";
            this.rdoOK.Size = new System.Drawing.Size(50, 17);
            this.rdoOK.TabIndex = 5;
            this.rdoOK.TabStop = true;
            this.rdoOK.Text = "Khóa";
            this.rdoOK.UseVisualStyleBackColor = true;
            // 
            // rdoNotOk
            // 
            this.rdoNotOk.AutoSize = true;
            this.rdoNotOk.Location = new System.Drawing.Point(7, 113);
            this.rdoNotOk.Name = "rdoNotOk";
            this.rdoNotOk.Size = new System.Drawing.Size(40, 17);
            this.rdoNotOk.TabIndex = 4;
            this.rdoNotOk.Text = "Mở";
            this.rdoNotOk.UseVisualStyleBackColor = true;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(9, 77);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(187, 20);
            this.tbPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // tbCode
            // 
            this.tbCode.Enabled = false;
            this.tbCode.Location = new System.Drawing.Point(7, 37);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(187, 20);
            this.tbCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvAccount);
            this.groupBox2.Location = new System.Drawing.Point(209, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 446);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(3, 16);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(583, 427);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // fQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fQuanLyTaiKhoan";
            this.Text = "fQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.fQuanLyTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btCancelText;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.RadioButton rdoOK;
        private System.Windows.Forms.RadioButton rdoNotOk;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label1;
    }
}
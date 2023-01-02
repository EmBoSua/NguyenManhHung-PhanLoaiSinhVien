
namespace PhanLoaiSinhVien4
{
    partial class fChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordOld = new System.Windows.Forms.TextBox();
            this.tbPasswordNew1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPasswordNew2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btChangePassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPasswordNew2 = new System.Windows.Forms.PictureBox();
            this.pbPasswordNew1 = new System.Windows.Forms.PictureBox();
            this.pbPasswordOld = new System.Windows.Forms.PictureBox();
            this.tbErr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordNew2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordNew1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordOld)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu cũ:";
            // 
            // tbPasswordOld
            // 
            this.tbPasswordOld.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbPasswordOld.Location = new System.Drawing.Point(107, 7);
            this.tbPasswordOld.Name = "tbPasswordOld";
            this.tbPasswordOld.Size = new System.Drawing.Size(309, 20);
            this.tbPasswordOld.TabIndex = 1;
            this.tbPasswordOld.UseSystemPasswordChar = true;
            // 
            // tbPasswordNew1
            // 
            this.tbPasswordNew1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbPasswordNew1.Location = new System.Drawing.Point(107, 39);
            this.tbPasswordNew1.Name = "tbPasswordNew1";
            this.tbPasswordNew1.Size = new System.Drawing.Size(309, 20);
            this.tbPasswordNew1.TabIndex = 3;
            this.tbPasswordNew1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // tbPasswordNew2
            // 
            this.tbPasswordNew2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbPasswordNew2.Location = new System.Drawing.Point(107, 71);
            this.tbPasswordNew2.Name = "tbPasswordNew2";
            this.tbPasswordNew2.Size = new System.Drawing.Size(309, 20);
            this.tbPasswordNew2.TabIndex = 5;
            this.tbPasswordNew2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // btChangePassword
            // 
            this.btChangePassword.Location = new System.Drawing.Point(107, 127);
            this.btChangePassword.Name = "btChangePassword";
            this.btChangePassword.Size = new System.Drawing.Size(89, 23);
            this.btChangePassword.TabIndex = 6;
            this.btChangePassword.Text = "Đổi mật khẩu";
            this.btChangePassword.UseVisualStyleBackColor = true;
            this.btChangePassword.Click += new System.EventHandler(this.btChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPasswordNew2);
            this.panel1.Controls.Add(this.pbPasswordNew1);
            this.panel1.Controls.Add(this.pbPasswordOld);
            this.panel1.Controls.Add(this.tbErr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btChangePassword);
            this.panel1.Controls.Add(this.tbPasswordOld);
            this.panel1.Controls.Add(this.tbPasswordNew2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbPasswordNew1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 162);
            this.panel1.TabIndex = 7;
            // 
            // pbPasswordNew2
            // 
            this.pbPasswordNew2.Image = ((System.Drawing.Image)(resources.GetObject("pbPasswordNew2.Image")));
            this.pbPasswordNew2.Location = new System.Drawing.Point(420, 69);
            this.pbPasswordNew2.Name = "pbPasswordNew2";
            this.pbPasswordNew2.Size = new System.Drawing.Size(25, 22);
            this.pbPasswordNew2.TabIndex = 10;
            this.pbPasswordNew2.TabStop = false;
            this.pbPasswordNew2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPasswordNew2_MouseDown);
            this.pbPasswordNew2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPasswordNew2_MouseUp);
            // 
            // pbPasswordNew1
            // 
            this.pbPasswordNew1.Image = ((System.Drawing.Image)(resources.GetObject("pbPasswordNew1.Image")));
            this.pbPasswordNew1.Location = new System.Drawing.Point(420, 37);
            this.pbPasswordNew1.Name = "pbPasswordNew1";
            this.pbPasswordNew1.Size = new System.Drawing.Size(25, 22);
            this.pbPasswordNew1.TabIndex = 9;
            this.pbPasswordNew1.TabStop = false;
            this.pbPasswordNew1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPasswordNew1_MouseDown);
            this.pbPasswordNew1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPasswordNew1_MouseUp);
            // 
            // pbPasswordOld
            // 
            this.pbPasswordOld.Image = ((System.Drawing.Image)(resources.GetObject("pbPasswordOld.Image")));
            this.pbPasswordOld.Location = new System.Drawing.Point(420, 5);
            this.pbPasswordOld.Name = "pbPasswordOld";
            this.pbPasswordOld.Size = new System.Drawing.Size(25, 22);
            this.pbPasswordOld.TabIndex = 8;
            this.pbPasswordOld.TabStop = false;
            this.pbPasswordOld.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPasswordOld_MouseDown);
            this.pbPasswordOld.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPasswordOld_MouseUp);
            // 
            // tbErr
            // 
            this.tbErr.AutoSize = true;
            this.tbErr.ForeColor = System.Drawing.Color.Red;
            this.tbErr.Location = new System.Drawing.Point(104, 95);
            this.tbErr.Name = "tbErr";
            this.tbErr.Size = new System.Drawing.Size(29, 13);
            this.tbErr.TabIndex = 7;
            this.tbErr.Text = "Error";
            this.tbErr.Visible = false;
            // 
            // fChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 165);
            this.Controls.Add(this.panel1);
            this.Name = "fChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordNew2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordNew1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordOld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswordOld;
        private System.Windows.Forms.TextBox tbPasswordNew1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPasswordNew2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btChangePassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tbErr;
        private System.Windows.Forms.PictureBox pbPasswordNew2;
        private System.Windows.Forms.PictureBox pbPasswordNew1;
        private System.Windows.Forms.PictureBox pbPasswordOld;
    }
}
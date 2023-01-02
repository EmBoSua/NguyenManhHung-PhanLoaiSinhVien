
namespace PhanLoaiSinhVien4
{
    partial class fStudentRights
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bảnĐiểmMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gợiÝChuyênNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảnĐiểmMônHọcToolStripMenuItem,
            this.gợiÝChuyênNgànhToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bảnĐiểmMônHọcToolStripMenuItem
            // 
            this.bảnĐiểmMônHọcToolStripMenuItem.Name = "bảnĐiểmMônHọcToolStripMenuItem";
            this.bảnĐiểmMônHọcToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.bảnĐiểmMônHọcToolStripMenuItem.Text = "Bảng điểm môn học";
            this.bảnĐiểmMônHọcToolStripMenuItem.Click += new System.EventHandler(this.bảnĐiểmMônHọcToolStripMenuItem_Click);
            // 
            // gợiÝChuyênNgànhToolStripMenuItem
            // 
            this.gợiÝChuyênNgànhToolStripMenuItem.Name = "gợiÝChuyênNgànhToolStripMenuItem";
            this.gợiÝChuyênNgànhToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.gợiÝChuyênNgànhToolStripMenuItem.Text = "Gợi ý chuyên ngành";
            this.gợiÝChuyênNgànhToolStripMenuItem.Click += new System.EventHandler(this.gợiÝChuyênNgànhToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // fStudentRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fStudentRights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quyền Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fStudentRights_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fStudentRights_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bảnĐiểmMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gợiÝChuyênNgànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}
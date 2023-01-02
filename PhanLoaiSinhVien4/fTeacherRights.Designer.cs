
namespace PhanLoaiSinhVien4
{
    partial class fTeacherRights
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
            this.dfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpTínChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoĐiểmLớpTínChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfToolStripMenuItem,
            this.quảnLýLớpTínChỉToolStripMenuItem,
            this.báoCáoĐiểmLớpTínChỉToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dfToolStripMenuItem
            // 
            this.dfToolStripMenuItem.Name = "dfToolStripMenuItem";
            this.dfToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.dfToolStripMenuItem.Text = "Quản lý lớp hành chính";
            this.dfToolStripMenuItem.Click += new System.EventHandler(this.dfToolStripMenuItem_Click);
            // 
            // quảnLýLớpTínChỉToolStripMenuItem
            // 
            this.quảnLýLớpTínChỉToolStripMenuItem.Name = "quảnLýLớpTínChỉToolStripMenuItem";
            this.quảnLýLớpTínChỉToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.quảnLýLớpTínChỉToolStripMenuItem.Text = "Quản lý lớp tín chỉ";
            this.quảnLýLớpTínChỉToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpTínChỉToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // báoCáoĐiểmLớpTínChỉToolStripMenuItem
            // 
            this.báoCáoĐiểmLớpTínChỉToolStripMenuItem.Name = "báoCáoĐiểmLớpTínChỉToolStripMenuItem";
            this.báoCáoĐiểmLớpTínChỉToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.báoCáoĐiểmLớpTínChỉToolStripMenuItem.Text = "Báo cáo điểm lớp tín chỉ";
            this.báoCáoĐiểmLớpTínChỉToolStripMenuItem.Click += new System.EventHandler(this.báoCáoĐiểmLớpTínChỉToolStripMenuItem_Click);
            // 
            // fTeacherRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "fTeacherRights";
            this.Text = "Quyền của giảng viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTeacherRights_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fTeacherRights_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpTínChỉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoĐiểmLớpTínChỉToolStripMenuItem;
    }
}
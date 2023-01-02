
namespace PhanLoaiSinhVien4
{
    partial class fPointFilter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mntDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btOK = new System.Windows.Forms.Button();
            this.AndOr = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mntDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AndOr,
            this.Subject,
            this.Operator,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // mntDelete
            // 
            this.mntDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.mntDelete.Name = "mntDelete";
            this.mntDelete.Size = new System.Drawing.Size(114, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(497, 12);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // AndOr
            // 
            this.AndOr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "AND";
            this.AndOr.DefaultCellStyle = dataGridViewCellStyle1;
            this.AndOr.FillWeight = 49.89509F;
            this.AndOr.HeaderText = "Điều kiện";
            this.AndOr.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.AndOr.Name = "AndOr";
            this.AndOr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AndOr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Subject.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subject.FillWeight = 49.89509F;
            this.Subject.HeaderText = "Môn";
            this.Subject.Items.AddRange(new object[] {
            "CSLT",
            "CSDL",
            "LTHDT",
            "NTKW",
            "MMT",
            "QTM",
            "LTWE"});
            this.Subject.Name = "Subject";
            this.Subject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Operator
            // 
            this.Operator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Operator.DefaultCellStyle = dataGridViewCellStyle3;
            this.Operator.FillWeight = 49.89509F;
            this.Operator.HeaderText = "Dấu";
            this.Operator.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            ">=",
            "<="});
            this.Operator.Name = "Operator";
            this.Operator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Operator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            this.Value.DefaultCellStyle = dataGridViewCellStyle4;
            this.Value.FillWeight = 50F;
            this.Value.HeaderText = "Giá trị";
            this.Value.MaxInputLength = 4;
            this.Value.Name = "Value";
            // 
            // fPointFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fPointFilter";
            this.Text = "Lọc điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mntDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip mntDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DataGridViewComboBoxColumn AndOr;
        private System.Windows.Forms.DataGridViewComboBoxColumn Subject;
        private System.Windows.Forms.DataGridViewComboBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}
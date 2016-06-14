namespace DirWatcher
{
    partial class DB_Builder_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Open = new System.Windows.Forms.TextBox();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OFDlg_STDF = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Lbl_Open = new System.Windows.Forms.Label();
            this.Ckb_ProjNm_Ptr = new System.Windows.Forms.CheckBox();
            this.Ckb_ProjNm_Ftr = new System.Windows.Forms.CheckBox();
            this.Ckb_ProjNm_Tsr = new System.Windows.Forms.CheckBox();
            this.Gpb_ProjNms = new System.Windows.Forms.GroupBox();
            this.DGV_TblCols_Setting = new System.Windows.Forms.DataGridView();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Test_Proj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbl_Col_Set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Btn_Parse = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_statusbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Gpb_ProjNms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TblCols_Setting)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Open
            // 
            this.Txt_Open.Location = new System.Drawing.Point(72, 3);
            this.Txt_Open.Name = "Txt_Open";
            this.Txt_Open.Size = new System.Drawing.Size(405, 21);
            this.Txt_Open.TabIndex = 0;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(483, 3);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(44, 23);
            this.Btn_Open.TabIndex = 1;
            this.Btn_Open.Text = "打开";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OFDlg_STDF
            // 
            this.OFDlg_STDF.Filter = "STDF文件|*.STDF|所有文件|*.*";
            // 
            // Lbl_Open
            // 
            this.Lbl_Open.AutoSize = true;
            this.Lbl_Open.Location = new System.Drawing.Point(6, 8);
            this.Lbl_Open.Name = "Lbl_Open";
            this.Lbl_Open.Size = new System.Drawing.Size(65, 12);
            this.Lbl_Open.TabIndex = 4;
            this.Lbl_Open.Text = "解析文件：";
            // 
            // Ckb_ProjNm_Ptr
            // 
            this.Ckb_ProjNm_Ptr.AutoSize = true;
            this.Ckb_ProjNm_Ptr.Checked = true;
            this.Ckb_ProjNm_Ptr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckb_ProjNm_Ptr.Location = new System.Drawing.Point(54, 18);
            this.Ckb_ProjNm_Ptr.Name = "Ckb_ProjNm_Ptr";
            this.Ckb_ProjNm_Ptr.Size = new System.Drawing.Size(42, 16);
            this.Ckb_ProjNm_Ptr.TabIndex = 5;
            this.Ckb_ProjNm_Ptr.Text = "Ptr";
            this.Ckb_ProjNm_Ptr.UseVisualStyleBackColor = true;
            // 
            // Ckb_ProjNm_Ftr
            // 
            this.Ckb_ProjNm_Ftr.AutoSize = true;
            this.Ckb_ProjNm_Ftr.Location = new System.Drawing.Point(6, 18);
            this.Ckb_ProjNm_Ftr.Name = "Ckb_ProjNm_Ftr";
            this.Ckb_ProjNm_Ftr.Size = new System.Drawing.Size(42, 16);
            this.Ckb_ProjNm_Ftr.TabIndex = 5;
            this.Ckb_ProjNm_Ftr.Text = "Ftr";
            this.Ckb_ProjNm_Ftr.UseVisualStyleBackColor = true;
            // 
            // Ckb_ProjNm_Tsr
            // 
            this.Ckb_ProjNm_Tsr.AutoSize = true;
            this.Ckb_ProjNm_Tsr.Location = new System.Drawing.Point(100, 18);
            this.Ckb_ProjNm_Tsr.Name = "Ckb_ProjNm_Tsr";
            this.Ckb_ProjNm_Tsr.Size = new System.Drawing.Size(42, 16);
            this.Ckb_ProjNm_Tsr.TabIndex = 5;
            this.Ckb_ProjNm_Tsr.Text = "Tsr";
            this.Ckb_ProjNm_Tsr.UseVisualStyleBackColor = true;
            // 
            // Gpb_ProjNms
            // 
            this.Gpb_ProjNms.Controls.Add(this.Ckb_ProjNm_Ptr);
            this.Gpb_ProjNms.Controls.Add(this.Ckb_ProjNm_Tsr);
            this.Gpb_ProjNms.Controls.Add(this.Ckb_ProjNm_Ftr);
            this.Gpb_ProjNms.Location = new System.Drawing.Point(8, 30);
            this.Gpb_ProjNms.Name = "Gpb_ProjNms";
            this.Gpb_ProjNms.Size = new System.Drawing.Size(469, 40);
            this.Gpb_ProjNms.TabIndex = 6;
            this.Gpb_ProjNms.TabStop = false;
            this.Gpb_ProjNms.Text = "解析项目";
            // 
            // DGV_TblCols_Setting
            // 
            this.DGV_TblCols_Setting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TblCols_Setting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sel,
            this.Test_Proj,
            this.Pin,
            this.Tbl_Col_Set,
            this.Unit});
            this.DGV_TblCols_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_TblCols_Setting.Location = new System.Drawing.Point(0, 0);
            this.DGV_TblCols_Setting.Name = "DGV_TblCols_Setting";
            this.DGV_TblCols_Setting.RowTemplate.Height = 23;
            this.DGV_TblCols_Setting.Size = new System.Drawing.Size(602, 204);
            this.DGV_TblCols_Setting.TabIndex = 8;
            // 
            // sel
            // 
            this.sel.FalseValue = "";
            this.sel.HeaderText = "选择";
            this.sel.IndeterminateValue = "";
            this.sel.Name = "sel";
            this.sel.TrueValue = "";
            this.sel.Width = 40;
            // 
            // Test_Proj
            // 
            this.Test_Proj.HeaderText = "测试项目";
            this.Test_Proj.Name = "Test_Proj";
            this.Test_Proj.ReadOnly = true;
            // 
            // Pin
            // 
            this.Pin.HeaderText = "Pin";
            this.Pin.Name = "Pin";
            this.Pin.ReadOnly = true;
            // 
            // Tbl_Col_Set
            // 
            this.Tbl_Col_Set.HeaderText = "列名设置";
            this.Tbl_Col_Set.Name = "Tbl_Col_Set";
            this.Tbl_Col_Set.Width = 140;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "计量单位";
            this.Unit.Items.AddRange(new object[] {
            "A",
            "V"});
            this.Unit.Name = "Unit";
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Unit.Width = 80;
            // 
            // Btn_Parse
            // 
            this.Btn_Parse.Location = new System.Drawing.Point(483, 47);
            this.Btn_Parse.Name = "Btn_Parse";
            this.Btn_Parse.Size = new System.Drawing.Size(44, 23);
            this.Btn_Parse.TabIndex = 1;
            this.Btn_Parse.Text = "分析";
            this.Btn_Parse.UseVisualStyleBackColor = true;
            this.Btn_Parse.Click += new System.EventHandler(this.Btn_Parse_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_statusbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 44);
            this.panel1.TabIndex = 10;
            // 
            // lbl_statusbar
            // 
            this.lbl_statusbar.Name = "lbl_statusbar";
            this.lbl_statusbar.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Txt_Open);
            this.panel2.Controls.Add(this.Btn_Open);
            this.panel2.Controls.Add(this.Btn_Parse);
            this.panel2.Controls.Add(this.Lbl_Open);
            this.panel2.Controls.Add(this.Gpb_ProjNms);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 74);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGV_TblCols_Setting);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 204);
            this.panel3.TabIndex = 12;
            // 
            // DB_Builder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 344);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "DB_Builder_Form";
            this.Text = "Form1";
            this.Gpb_ProjNms.ResumeLayout(false);
            this.Gpb_ProjNms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TblCols_Setting)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Open;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog OFDlg_STDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label Lbl_Open;
        private System.Windows.Forms.CheckBox Ckb_ProjNm_Ptr;
        private System.Windows.Forms.CheckBox Ckb_ProjNm_Ftr;
        private System.Windows.Forms.CheckBox Ckb_ProjNm_Tsr;
        private System.Windows.Forms.GroupBox Gpb_ProjNms;
        private System.Windows.Forms.DataGridView DGV_TblCols_Setting;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Proj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tbl_Col_Set;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unit;
        private System.Windows.Forms.Button Btn_Parse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_statusbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}


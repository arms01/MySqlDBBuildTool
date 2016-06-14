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
            this.FormStatusBar = new System.Windows.Forms.StatusStrip();
            this.statusbarlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.Gpb_ProjNms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TblCols_Setting)).BeginInit();
            this.FormStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Open
            // 
            this.Txt_Open.Location = new System.Drawing.Point(70, 12);
            this.Txt_Open.Name = "Txt_Open";
            this.Txt_Open.Size = new System.Drawing.Size(405, 21);
            this.Txt_Open.TabIndex = 0;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(481, 12);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(44, 23);
            this.Btn_Open.TabIndex = 1;
            this.Btn_Open.Text = "打开";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 278);
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
            this.Lbl_Open.Location = new System.Drawing.Point(4, 17);
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
            this.Gpb_ProjNms.Location = new System.Drawing.Point(12, 41);
            this.Gpb_ProjNms.Name = "Gpb_ProjNms";
            this.Gpb_ProjNms.Size = new System.Drawing.Size(463, 40);
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
            this.DGV_TblCols_Setting.Location = new System.Drawing.Point(12, 87);
            this.DGV_TblCols_Setting.Name = "DGV_TblCols_Setting";
            this.DGV_TblCols_Setting.RowTemplate.Height = 23;
            this.DGV_TblCols_Setting.Size = new System.Drawing.Size(513, 185);
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
            this.Btn_Parse.Location = new System.Drawing.Point(481, 58);
            this.Btn_Parse.Name = "Btn_Parse";
            this.Btn_Parse.Size = new System.Drawing.Size(44, 23);
            this.Btn_Parse.TabIndex = 1;
            this.Btn_Parse.Text = "分析";
            this.Btn_Parse.UseVisualStyleBackColor = true;
            this.Btn_Parse.Click += new System.EventHandler(this.Btn_Parse_Click);
            // 
            // FormStatusBar
            // 
            this.FormStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar,
            this.statusbarlbl});
            this.FormStatusBar.Location = new System.Drawing.Point(0, 311);
            this.FormStatusBar.Name = "FormStatusBar";
            this.FormStatusBar.Size = new System.Drawing.Size(530, 22);
            this.FormStatusBar.TabIndex = 9;
            this.FormStatusBar.Text = "statusStrip1";
            // 
            // statusbarlbl
            // 
            this.statusbarlbl.Name = "statusbarlbl";
            this.statusbarlbl.Size = new System.Drawing.Size(131, 17);
            this.statusbarlbl.Text = "toolStripStatusLabel1";
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
            // 
            // DB_Builder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 333);
            this.Controls.Add(this.FormStatusBar);
            this.Controls.Add(this.DGV_TblCols_Setting);
            this.Controls.Add(this.Gpb_ProjNms);
            this.Controls.Add(this.Lbl_Open);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Parse);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.Txt_Open);
            this.Name = "DB_Builder_Form";
            this.Text = "Form1";
            this.Gpb_ProjNms.ResumeLayout(false);
            this.Gpb_ProjNms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TblCols_Setting)).EndInit();
            this.FormStatusBar.ResumeLayout(false);
            this.FormStatusBar.PerformLayout();
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
        private System.Windows.Forms.StatusStrip FormStatusBar;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripStatusLabel statusbarlbl;
    }
}


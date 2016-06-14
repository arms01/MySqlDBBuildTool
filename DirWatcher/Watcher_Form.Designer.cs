namespace DirWatcher
{
    partial class Watcher_Form
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
            this.Lbl_Open = new System.Windows.Forms.Label();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.Txt_WorkPath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.FBDlg_WorkPath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Lbl_Open
            // 
            this.Lbl_Open.AutoSize = true;
            this.Lbl_Open.Location = new System.Drawing.Point(1, 15);
            this.Lbl_Open.Name = "Lbl_Open";
            this.Lbl_Open.Size = new System.Drawing.Size(65, 12);
            this.Lbl_Open.TabIndex = 7;
            this.Lbl_Open.Text = "工作目录：";
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(274, 10);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(45, 23);
            this.Btn_Open.TabIndex = 6;
            this.Btn_Open.Text = "打开";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Txt_WorkPath
            // 
            this.Txt_WorkPath.Location = new System.Drawing.Point(72, 12);
            this.Txt_WorkPath.Name = "Txt_WorkPath";
            this.Txt_WorkPath.Size = new System.Drawing.Size(196, 21);
            this.Txt_WorkPath.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(154, 39);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 8;
            this.Btn_Start.Text = "开始监控";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // FBDlg_WorkPath
            // 
            this.FBDlg_WorkPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Watcher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 66);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Lbl_Open);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.Txt_WorkPath);
            this.Name = "Watcher_Form";
            this.Text = "Watcher_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Open;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.TextBox Txt_WorkPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.FolderBrowserDialog FBDlg_WorkPath;
    }
}
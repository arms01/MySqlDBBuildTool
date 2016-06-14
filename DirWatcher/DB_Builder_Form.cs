using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Windows.Forms;
using System.Diagnostics;

namespace DirWatcher
{
    public partial class DB_Builder_Form : Form
    {
        public DB_Builder_Form()
        {
            InitializeComponent();
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            if (OFDlg_STDF.ShowDialog() == DialogResult.OK)
            {
                Txt_Open.Text = OFDlg_STDF.FileName;
            }
        }

        private void Btn_Parse_Click(object sender, EventArgs e)
        {
            ScriptRuntime pyRumTime = Python.CreateRuntime();
            ScriptEngine rbEng = pyRumTime.GetEngine("python");
            var lstPath = rbEng.GetSearchPaths();
            string strVar = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            if (strVar != null)
            {
                foreach (var v in strVar.Split(';'))
                {
                    if (v.ToLower().IndexOf("python") != -1)
                        lstPath.Add(v);
                }
            }
            lstPath.Add("D:\\Dev\\Python\\Lib");
            lstPath.Add("D:\\Dev\\Python\\Lib\\site-packages");
            rbEng.SetSearchPaths(lstPath);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            dynamic obj = pyRumTime.UseFile("ParseStdfForDBSchema.py");
            IronPython.Runtime.PythonDictionary dict = obj.process_file(Txt_Open.Text);
            sw.Stop();
            statusbarlbl.Text = sw.Elapsed.ToString();
            if (dict != null)
            {
                int i = DGV_TblCols_Setting.Rows.Count - 1;
                DGV_TblCols_Setting.Rows.Add(dict.Count);
                foreach (IronPython.Runtime.List r in dict.Values)
                {
                    DGV_TblCols_Setting.Rows[i].Cells["sel"].Value = true;
                    DGV_TblCols_Setting.Rows[i].Cells["Test_Proj"].Value = r[1];
                    DGV_TblCols_Setting.Rows[i].Cells["Pin"].Value = r[2];
                    DGV_TblCols_Setting.Rows[i].Cells["Tbl_Col_Set"].Value = r[1] + "_" + r[2] + "(" + r[3] + ")";
                    DGV_TblCols_Setting.Rows[i].Cells["Unit"].Value = r[3];
                    i++;
                }
            }
            

        }
    }
}

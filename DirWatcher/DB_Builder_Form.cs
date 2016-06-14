using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Windows.Forms;

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
            //dynamic obj = pyRumTime.UseFile("ParseStdfForDBSchema.py");
            ScriptScope scope = pyRumTime.UseFile("ParseStdfForDBSchema.py");
            var watching = scope.GetVariable<Func<object, object>>("do_process");
            IronPython.Runtime.PythonDictionary data = obj.process_file(Txt_Open.Text);
            if (data != null)
            {
                foreach (var r in data)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.SetValues(r.Value);
                    DGV_TblCols_Setting.Rows.Add(dr);
                }
            }
            

        }
    }
}

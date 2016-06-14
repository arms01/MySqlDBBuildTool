using System;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace DirWatcher
{    
    public partial class Watcher_Form : Form
    {
        private ScriptRuntime pyRumTime;
        private ScriptEngine rbEng;
        public Watcher_Form()
        {
            InitializeComponent();

            pyRumTime = Python.CreateRuntime();
            rbEng = pyRumTime.GetEngine("python");
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
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            if (FBDlg_WorkPath.ShowDialog() == DialogResult.OK)
            {
                Txt_WorkPath.Text = FBDlg_WorkPath.SelectedPath;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            //ScriptSource source = rbEng.CreateScriptSourceFromFile("MyWatchDog.py");
            ScriptScope scope = pyRumTime.UseFile("MyWatchDog.py");

            //source.Execute(scope);
            var watching = scope.GetVariable<Func<object, object>>("do_process");
            watching(Txt_WorkPath.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pyRumTime.Shutdown();
        }
    }
}

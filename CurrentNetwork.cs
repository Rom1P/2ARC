using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ARC
{
    public partial class CurrentNetwork : Form
    {
        Process processScriptPython = new Process();
        string scriptPath = "..\\..\\pythonScripts\\analyseCurrentNetwork.py";

        public CurrentNetwork()
        {
            InitializeComponent();

        }

        private void CurrentNetwork_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonIconTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CurrentNetwork_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                iconTray.Icon = new Icon(this.Icon, 100, 100); ;
                iconTray.ShowBalloonTip(1000);
                this.Hide();
            }
        }

        private void OnClickIconTray(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GetPythonPath();

            string absolutePathPython = File.ReadAllText("..\\..\\pythonScripts\\localPathPython.txt");
            string CompletePathPython;

            if (checkBoxDevMode.Checked)
            {
                CompletePathPython = absolutePathPython + "\\python.exe";
            }

            else
            {
                CompletePathPython = absolutePathPython + "\\pythonw.exe";
            }



            processScriptPython.StartInfo = new ProcessStartInfo(CompletePathPython, scriptPath);


            processScriptPython.StartInfo = new ProcessStartInfo(CompletePathPython, scriptPath);
            processScriptPython.StartInfo.Verb = "runas";
            processScriptPython.StartInfo.CreateNoWindow = true;
            processScriptPython.Start();

            timerReload.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            processScriptPython.Kill();
            timerReload.Stop();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            LauncherWindow launcherWindowObject = new LauncherWindow();
            launcherWindowObject.Show();
            this.Close();
        }

        private void CurrentNetwork_Closing(object sender, FormClosingEventArgs e)
        {
            try
            {
                processScriptPython.Kill();
            }

            catch
            {

            }

            try
            {
                timerReload.Stop();
            }

            catch
            {
                
            }
        }

        private void LoadDroppedPackets()
        {
            string BlockedPackets = File.ReadAllText("..\\..\\pythonScripts\\ListBlocked.txt");
            string[] ArrayBlockedPackets = BlockedPackets.Split('\n');

            listBoxOutput.Items.Clear();

            foreach (string tempPacket in ArrayBlockedPackets)
            {
                listBoxOutput.Items.Add(tempPacket);
            }
        }
        
        private void GetPythonPath()
        {
            try
            {
                Process cmdCheckPythonPath = new Process();
                cmdCheckPythonPath.StartInfo.FileName = "cmd.exe";
                cmdCheckPythonPath.StartInfo.CreateNoWindow = true;
                cmdCheckPythonPath.StartInfo.RedirectStandardInput = true;
                cmdCheckPythonPath.StartInfo.RedirectStandardOutput = true;
                cmdCheckPythonPath.StartInfo.UseShellExecute = false;

                cmdCheckPythonPath.Start();

                cmdCheckPythonPath.StandardInput.WriteLine("py ..\\..\\pythonScripts\\getPyDir.py");
                cmdCheckPythonPath.StandardInput.Flush();
                cmdCheckPythonPath.StandardInput.Close();


                cmdCheckPythonPath.WaitForExit();

            }

            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("It seems we can't find python on your pc \n You need to install python to use our firewall", "Python is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void timerReload_Tick(object sender, EventArgs e)
        {
            LoadDroppedPackets();
        }
    }
}

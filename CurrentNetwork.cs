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
        public CurrentNetwork()
        {
            InitializeComponent();

            string scriptPath = "..\\..\\pythonScripts\\analyseCurrentNetwork.py";


            processScriptPython.StartInfo = new ProcessStartInfo(@"C:\Users\Romain\AppData\Local\Programs\Python\Python36-32\python.exe", scriptPath);
            processScriptPython.StartInfo.Verb = "runas";
            processScriptPython.StartInfo.CreateNoWindow = true;
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

        private void stopButton_Click(object sender, EventArgs e)
        {
            processScriptPython.Kill();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            processScriptPython.Start();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            LauncherWindow launcherWindowObject = new LauncherWindow();
            launcherWindowObject.Show();
            this.Close();
        }
    }
}

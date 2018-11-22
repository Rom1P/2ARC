using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;

namespace _2ARC
{
    public partial class ReadOutput : Form
    {
        private string path;
        private string pythonPath;

        public ReadOutput()
        {
            InitializeComponent();
        }

        private void ReadOutput_Load(object sender, EventArgs e)
        {
            OpenFile.Filter = "Capture Files|*.cap;*.pcap";
        }



        //Manage OpenFileDialog
        private void openFileButton_Click(object sender, EventArgs e)
        {

            DialogResult result = OpenFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = OpenFile.FileName;
                //Stock path in save file, easier to send this information to python script
                File.WriteAllText("..\\..\\pythonScripts\\filePath.txt", path);
                LoadFile();
            }
        }

        //Launch new process to execute pythonScript to read captures files
        private void LoadFile()
        {
            Process processScriptPython = new Process();


            string scriptPath = "..\\..\\pythonScripts\\readFile.py";
            GetPythonPath();

            string absolutePathPython = File.ReadAllText("..\\..\\pythonScripts\\localPathPython.txt");

            string CompletePathPython = absolutePathPython + "\\pythonw.exe";


            processScriptPython.StartInfo = new ProcessStartInfo(CompletePathPython, scriptPath);
            processScriptPython.StartInfo.CreateNoWindow = true;
            processScriptPython.StartInfo.UseShellExecute = false;

            processScriptPython.Start();

            //Use to wait until all file has been read and wrote into readFileConverted.txt
            processScriptPython.WaitForExit();


            textBoxOutput.Text = "";

            //Load output file and display it
            string[] ArrayReadFile = File.ReadAllLines("..\\..\\pythonScripts\\readFileConverted.txt");
            foreach (string tempPacket in ArrayReadFile)
            {
                textBoxOutput.Text += tempPacket;
                textBoxOutput.Text += Environment.NewLine;
            }

        }

        //Reload File and apply rules
        private void ApplyRulesButton_Click(object sender, EventArgs e)
        {
            Process processScriptPython = new Process();

            string scriptPath = "..\\..\\pythonScripts\\readFile.py";
            GetPythonPath();

            string absolutePathPython = File.ReadAllText("..\\..\\pythonScripts\\localPathPython.txt");

            string CompletePathPython = absolutePathPython + "\\pythonw.exe";


            processScriptPython.StartInfo = new ProcessStartInfo(CompletePathPython, scriptPath);
            processScriptPython.StartInfo.CreateNoWindow = true;
            processScriptPython.Start();

            processScriptPython.WaitForExit();

            textBoxOutput.Text = "";


            //Get converted file and rules
            string[] ArrayReadFile = File.ReadAllLines("..\\..\\pythonScripts\\readFileConverted.txt");
            string[] portArray = File.ReadAllLines("..\\..\\pythonScripts\\ListPort.txt");
            string[] ipArray = File.ReadAllLines("..\\..\\pythonScripts\\ListIP.txt");


            //Split data in file converted to get port and ip of source and destination
            foreach (string tempPacket in ArrayReadFile)
            {
                string[] tempPackedSplit = tempPacket.Split(',');


                textBoxOutput.Text += tempPacket;

                string portStart = tempPackedSplit[2].ToString();
                portStart = portStart.Substring(1, portStart.Length - 1);


                string portArrival = tempPackedSplit[4].ToString();
                portArrival = portArrival.Substring(1, portStart.Length - 1);


                string ipStart = tempPackedSplit[0].ToString();
                ipStart = ipStart.Substring(1, portStart.Length - 1);


                string ipArrival = tempPackedSplit[0].ToString();
                ipArrival = ipArrival.Substring(1, portStart.Length - 1);

                //If one of this 4 data up is in current packet, it will be displayed with Dropped after his information
                if (Array.IndexOf(portArray, portStart) > -1 || Array.IndexOf(portArray, portArrival) > -1 || Array.IndexOf(ipArray, ipStart) > -1 || Array.IndexOf(ipArray, ipArrival) > -1)
                {
                    textBoxOutput.Text += " Dropped";
                }

                textBoxOutput.Text += Environment.NewLine;

            }
        }


        //Check python path by using cmd command, we can't use this cmd to launch python script with admin rights and invisble console so that's why we need to get the path
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

        //Redirect To Menu
        private void GoMenu_Click(object sender, EventArgs e)
        {
            LauncherWindow Launcher = new LauncherWindow();
            Launcher.Show();
            this.Close();
        }
    }
}

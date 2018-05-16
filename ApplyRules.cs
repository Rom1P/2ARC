using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ARC
{
    public partial class ApplyRules : Form
    {

        private List<string> IPAddressList;
        private List<string> PortList;


        public ApplyRules()
        {
            InitializeComponent();
            IPAddressList = new List<string>();
            PortList = new List<string>();
        }

        private void buttonIconTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ApplyRules_Load(object sender, EventArgs e)
        {
            try
            {
                string[] IPAddressArray = File.ReadAllLines("..\\..\\pythonScripts\\ListIP.txt");
                foreach (string IPTemp in IPAddressArray)
                {
                    listBoxIP.Items.Add(IPTemp);
                    IPAddressList.Add(IPTemp);
                }
            }

            catch
            {

            }

            try
            {
                string[] PortArray = File.ReadAllLines("..\\..\\pythonScripts\\ListPort.txt");
                foreach (string PortTemp in PortArray)
                {
                    listBoxPort.Items.Add(PortTemp);
                    PortList.Add(PortTemp);
                }
            }

            catch
            {

            }


        }

        private void ApplyRules_Resize(object sender, EventArgs e)
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

        private void AddNewIpButton_Click(object sender, EventArgs e)
        {
            string IPAddressString = IPtextBox.Text;

            if (IPAddressString != "")
            {
                IPtextBox.Text = "";

                if (IPAddressList.Contains(IPAddressString))
                {
                    MessageBox.Show("This IP is already on the list of blocked addresses", "IP already exist", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                else
                {
                    IPAddressList.Add(IPAddressString);
                    listBoxIP.Items.Add(IPAddressString);

                    string[] arrayToWrite = IPAddressList.ToArray();

                    File.WriteAllLines("..\\..\\pythonScripts\\ListIP.txt", arrayToWrite);

                }
            }
        }

        private void blockPortButton_Click(object sender, EventArgs e)
        {
            string PortString = textBoxPort.Text;

            if (PortString != "")
            {
                try
                {
                    int Port = Int32.Parse(PortString);
                    textBoxPort.Text = "";

                    if (PortList.Contains(PortString))
                    {
                        MessageBox.Show("This Port is already on the list of blocked addresses", "Port already exist", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                    else
                    {
                        PortList.Add(PortString);
                        listBoxPort.Items.Add(PortString);

                        string[] arrayToWrite = PortList.ToArray();

                        File.WriteAllLines("..\\..\\pythonScripts\\ListPort.txt", arrayToWrite);
                    }
                }

                catch
                {

                }

            }
        }

        private void resetIPButton_Click(object sender, EventArgs e)
        {
            IPAddressList = new List<string>();

            string[] arrayToWrite = IPAddressList.ToArray();

            File.WriteAllLines("..\\..\\pythonScripts\\ListIP.txt", arrayToWrite);

            listBoxIP.Items.Clear();
        }

        private void resetPortButton_Click(object sender, EventArgs e)
        {
            PortList = new List<string>();

            string[] arrayToWrite = PortList.ToArray();

            File.WriteAllLines("..\\..\\pythonScripts\\ListPort.txt", arrayToWrite);

            listBoxPort.Items.Clear();
        }

        private void deleteSelectedIP_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddressList.RemoveAt(listBoxIP.SelectedIndex);

                string[] arrayToWrite = IPAddressList.ToArray();

                File.WriteAllLines("..\\..\\pythonScripts\\ListIP.txt", arrayToWrite);

                listBoxIP.Items.Remove(listBoxIP.SelectedItem);
            }

            catch(Exception efkje)
            {
                Console.WriteLine(efkje);
            }
        }

        private void RemovePortButton_Click(object sender, EventArgs e)
        {
            try
            {
                PortList.RemoveAt(listBoxPort.SelectedIndex);

                string[] arrayToWrite = PortList.ToArray();

                File.WriteAllLines("..\\..\\pythonScripts\\ListPort.txt", arrayToWrite);

                listBoxPort.Items.Remove(listBoxPort.SelectedItem);
            }
            catch
            {
                Console.WriteLine("flezk,fezlk");
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            LauncherWindow launcherWindowObject = new LauncherWindow();
            launcherWindowObject.Show();
            this.Close();
        }

        private void NetworkButton_Click(object sender, EventArgs e)
        {
            CurrentNetwork currentNetworkWindow = new CurrentNetwork();
            currentNetworkWindow.Show();
            this.Close();
        }
    }
}

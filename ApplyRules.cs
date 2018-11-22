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
        //Two List that contains rules
        private List<string> IPAddressList;
        private List<string> PortList;


        public ApplyRules()
        {
            InitializeComponent();
            IPAddressList = new List<string>();
            PortList = new List<string>();
        }
        
        //Load files and display content in ListBox and save into lists
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
        
        

        //Add Data to ListBox, List and write it into file
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


        //Add Data to ListBox, List and write it into file
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

        //Clear content of ListBox,List and write List in file
        private void resetIPButton_Click(object sender, EventArgs e)
        {
            IPAddressList = new List<string>();

            string[] arrayToWrite = IPAddressList.ToArray();

            File.WriteAllLines("..\\..\\pythonScripts\\ListIP.txt", arrayToWrite);

            listBoxIP.Items.Clear();
        }

        //Clear content of ListBox,List and write List in file
        private void resetPortButton_Click(object sender, EventArgs e)
        {
            PortList = new List<string>();

            string[] arrayToWrite = PortList.ToArray();

            File.WriteAllLines("..\\..\\pythonScripts\\ListPort.txt", arrayToWrite);

            listBoxPort.Items.Clear();
        }


        //With Selected Index attribute of ListBox, delete one element from ListBox, List and write list in file
        private void deleteSelectedIP_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddressList.RemoveAt(listBoxIP.SelectedIndex);

                string[] arrayToWrite = IPAddressList.ToArray();

                File.WriteAllLines("..\\..\\pythonScripts\\ListIP.txt", arrayToWrite);

                listBoxIP.Items.Remove(listBoxIP.SelectedItem);
            }

            catch(Exception exceptionListIP)
            {
                Console.WriteLine(exceptionListIP);
            }
        }


        //With Selected Index attribute of ListBox, delete one element from ListBox, List and write list in file
        private void RemovePortButton_Click(object sender, EventArgs e)
        {
            try
            {
                PortList.RemoveAt(listBoxPort.SelectedIndex);

                string[] arrayToWrite = PortList.ToArray();

                File.WriteAllLines("..\\..\\pythonScripts\\ListPort.txt", arrayToWrite);

                listBoxPort.Items.Remove(listBoxPort.SelectedItem);
            }
            catch (Exception exceptionListPort)
            {
                Console.WriteLine(exceptionListPort);
            }
        }


        //Redirect to Other windows
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

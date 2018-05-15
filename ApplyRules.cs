using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ARC
{
    public partial class ApplyRules : Form
    {

        private List<string> IPAddressList;
        private List<int> PortList;
        private List<string> MacAdressList;


        public ApplyRules()
        {
            InitializeComponent();
            IPAddressList = new List<string>();
            MacAdressList = new List<string>();
            PortList = new List<int>();
        }

        private void buttonIconTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                    /*Block IP*/
                }
            }



        }
    }
}

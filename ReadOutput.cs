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
using PacketDotNet;
using SharpPcap;
using SharpPcap.LibPcap;

namespace _2ARC
{
    public partial class ReadOutput : Form
    {
        private string path;
        public ReadOutput()
        {
            InitializeComponent();
        }

        private void ReadOutput_Load(object sender, EventArgs e)
        {
            
        }

        private void GoMenu_Click(object sender, EventArgs e)
        {
            LauncherWindow Launcher = new LauncherWindow();
            Launcher.Show();
            this.Close();
        }

        private void ApplyRulesButton_Click(object sender, EventArgs e)
        {

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = OpenFile.FileName;
                LoadFile();
            }
        }

        private void LoadFile()
        {
            ICaptureDevice deviceReader;
            deviceReader = new CaptureFileReaderDevice("D:\\2ARCRessources\\9p.cap");

            deviceReader.Open();

            deviceReader.OnPacketArrival += new PacketArrivalEventHandler(PacketArrivalDisplayInfos);

            deviceReader.Capture();

            deviceReader.Close();


        }

        private void PacketArrivalDisplayInfos(object sender, CaptureEventArgs e)
        {
            if (e.Packet.LinkLayerType == LinkLayers.Ethernet)
            {
                var packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
                var ethernetPacket = (EthernetPacket)packet;

                Console.WriteLine(
                                  e.Packet.Timeval.Date.ToString(),
                                  e.Packet.Timeval.Date.Millisecond,
                                  ethernetPacket.SourceHwAddress,
                                  ethernetPacket.DestinationHwAddress);
            }
        }
    }
}

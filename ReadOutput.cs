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
    public partial class ReadOutput : Form
    {
        private string path;
        public ReadOutput()
        {
            InitializeComponent();
        }

        private void ReadOutput_Load(object sender, EventArgs e)
        {
            DialogResult result = OpenFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = OpenFile.FileName;
                string fileRead = File.ReadAllText(path);
                Console.WriteLine(fileRead);
            }
        }

        private void GoMenu_Click(object sender, EventArgs e)
        {
            LauncherWindow Launcher = new LauncherWindow();
            Launcher.Show();
            this.Close();
        }
    }
}

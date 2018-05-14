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
    public partial class LauncherWindow : Form
    {
        public LauncherWindow()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            ReadOutput ReadOutputWindow = new ReadOutput();
            ReadOutputWindow.Show();
            this.Hide();
        }

        private void CurrentNetworkButton_Click(object sender, EventArgs e)
        {
            CurrentNetwork currentNetworkWindow = new CurrentNetwork();
            currentNetworkWindow.Show();
            this.Hide();
        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
            ApplyRules ApplyRulesWindow = new ApplyRules();
            ApplyRulesWindow.Show();
            this.Hide();
        }
    }
}

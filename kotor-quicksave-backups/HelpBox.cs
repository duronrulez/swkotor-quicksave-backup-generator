using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kotor_quicksave_backups
{
    partial class HelpBox : Form
    {
        public HelpBox()
        {
            InitializeComponent();
        }


        private void HelpBox_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/duronrulez/swkotor-quicksave-backup-generator", UseShellExecute = true });
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Diagnostics;
using Modex360.Server;
using Modex360.Functions;

namespace Modex360.Forms
{
    public partial class About : Office2007RibbonForm
    {
        public About()
        {
            InitializeComponent();
            MdiParent = Main.mainForm;
            Tag = true;
            panelVersion.Text += Config.clientVersion;
            iconRiggy.Location = new Point(35, 6);
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tag = false;
        }

        private void cmdVisitUs_Click(object sender, EventArgs e)
        {
            cmdVisitUs.Enabled = false;
            Process.Start("https://www.patreon.com/unknownv2");
            cmdVisitUs.Enabled = true;
        }

        int x = new int();
        private void pbLogo_Click(object sender, EventArgs e)
        {
            switch (x++)
            {
                case 3:
                    UI.messageBox("WtF iS YoU DOiN? STOP H4X0rZINgz PLZ!!!", "H4x0Rz", MessageBoxIcon.Exclamation);
                    break;
                case 8:
                    UI.messageBox("SOrЯY H0r1zoN d3v5", "LOLz", MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
        }

        private void iconRiggy_Click(object sender, EventArgs e)
        {
            Process.Start("https://modex.riggy.dev");
        }
    }
}
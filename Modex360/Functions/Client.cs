using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;
using Modex360.Server;
using DevComponents.DotNetBar;
using Modex360.Properties;
using Modex360.Forms;
using System.Diagnostics;

namespace Modex360.Functions
{
    internal static class Client
    {
        internal static bool doUpdate(XPathNavigator nav)
        {
            Program.updateBatch = Global.base64Decode(nav.Value);
            nav.MoveToFirstAttribute();
            Program.updateVersion = nav.Value;
            nav.MoveToNextAttribute();
            Program.updateURL = nav.Value;
            nav.MoveToParent();
            if (Program.doneLoading)
            {
                if (UI.messageBox("An update is available for Modex360!\nThe program will have limited functionality until you install this update.\n\nWould you like to update now?", "Modex360 v" + Program.updateVersion, MessageBoxIcon.Information, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(Program.updateURL);
                    Application.Exit();
                }
            }
            else
                Program.killLoadingLogo();
            return true;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Modex360.Functions;
using Modex360.Properties;
using System.Diagnostics;

namespace Modex360.Forms
{
    internal partial class Main : Office2007RibbonForm
    {
        internal static volatile Main mainForm;
        internal Main()
        {
            InitializeComponent();
            mainForm = this;
            loadFormStyle();
            cmdBackups.Checked = Settings.Default.Backup;
            cmdSafeMode.Checked = Settings.Default.SafeMode;
            cmdDock.Checked = Settings.Default.Docked;
            cmdStatus.Text = "Riggy.dev";
            tabRealtimeEditors.Select();
            FormConfig.populateForms();
            FormConfig.populateTabs();
            TaskbarManager.setWindowHandle(Handle);
            FatxHandle.initializeHandle();
            Program.killLoadingLogo();
            Program.doneLoading = true;
            if (FatxHandle.openOnOpen)
                FatxPanelExpanded = true;
            nextClipboardViewer = (IntPtr)ClipboardHelper.SetClipboardViewer(Handle.ToInt32());
            Win32.ForceForegroundWindow(this.Handle);
        }

        private IntPtr nextClipboardViewer;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x030D:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        ClipboardHelper.SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                case 0x308:
                    string currentClip = null;
                    IDataObject clipData = Clipboard.GetDataObject();
                    if (clipData.GetDataPresent(DataFormats.Rtf))
                    {
                        RichTextBox tempTextBox = new RichTextBox();
                        tempTextBox.Rtf = (string)clipData.GetData(DataFormats.Rtf);
                        currentClip = tempTextBox.Text;
                    }
                    else if (clipData.GetDataPresent(DataFormats.Text))
                        currentClip = (string)clipData.GetData(DataFormats.Text);
                    if (currentClip != null)
                        ClipboardHelper.parseClipboardText(currentClip);
                    ClipboardHelper.SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        ~Main()
        {
            ClipboardHelper.ChangeClipboardChain(this.Handle, nextClipboardViewer);
        }

        internal static void doFlashColors()
        {
            Color original = StyleManager.ColorTint;
            foreach (Color color in new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet })
            {
                StyleManager.ColorTint = color;
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            StyleManager.ColorTint = original;
        }

        internal static void doFlash()
        {
            for (byte x = 0; x < 9; x++)
            {
                mainForm.Opacity = 0;
                Application.DoEvents();
                System.Threading.Thread.Sleep(150);
                mainForm.Opacity = 100;
            }
        }

        internal void cmdStatus_Click(object sender, EventArgs e)
        {
            if (cmdStatus.Text == "Riggy.dev")
            {
                Process.Start("https://modex.riggy.dev/");
            } else if (cmdStatus.Text == "WeMod.com") {
                Process.Start("https://www.wemod.com/");
            }
        }

        private void cmdQuickFix_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a STFS Package to Rehash and Resign";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
                fixFiles(ofd.FileNames);
        }

        internal static void fixFiles(string[] fileNames)
        {
            if (fileNames.Length > 0)
            {
                int amountFixed = new int();
                foreach (string fileName in fileNames)
                    if (fixFile(fileName))
                        amountFixed++;
                    else if (Program.doneLoading)
                        UI.messageBox("Not a valid CON STFS package!\n" + fileName, "Invalid", MessageBoxIcon.Error);
                if (!Program.doneLoading)
                    Program.killLoadingLogo();
                if (amountFixed > 0)
                    UI.messageBox("Rehashed and resigned " + amountFixed.ToString() + " file" + ((amountFixed == 1) ? String.Empty : "s") + "!", "Saved", MessageBoxIcon.Information);
            }
        }

        private static bool fixFile(string path)
        {
            XContent.XContentPackage Package = new XContent.XContentPackage();
            if (!Package.LoadPackage(path, false))
                return false;
            if (Package.Header.Metadata.VolumeType == XContent.XContentVolumeType.STFS_Volume
                && Package.Header.SignatureType == XContent.XContentSignatureType.CONSOLE_SIGNED)
            {
                Package.StfsContentPackage.Rehash();
                Package.Flush();
                Package.Save();
                Package.CloseIO(true);
                return true;
            }
            Package.CloseIO(true);
            return false;
        }

        private void loadFormStyle()
        {
            switch (Settings.Default.StyleType)
            {
                case 0:
                    styleMain.ManagerStyle = eStyle.Office2010Black;
                    styleMain.ManagerColorTint = Color.Black;
                    break;
                case 1:
                    styleMain.ManagerStyle = eStyle.Office2010Silver;
                    styleMain.ManagerColorTint = Color.Black;
                    break;
                case 2:
                    styleMain.ManagerStyle = eStyle.Office2010Blue;
                    styleMain.ManagerColorTint = Color.Black;
                    break;
            }
        }

        private void cmdRotateTint_Click(object sender, EventArgs e)
        {
            byte curTint = Settings.Default.StyleType;
            curTint++;
            if (curTint == 3)
                curTint = 0;
            Settings.Default.StyleType = curTint;
            Settings.Default.Save();
            loadFormStyle();
        }

        private void panelStatus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
                panelStatus.Style.BackColor1.Color = Color.Gold;
            }
        }

        private void panelStatus_DragLeave(object sender, EventArgs e)
        {
            panelStatus.Style.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
        }

        private void panelStatus_DragDrop(object sender, DragEventArgs e)
        {
            panelStatus_DragLeave(null, null);
            string[] dataFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (dataFiles.Length > 0 && dataFiles[0].Contains(FatxHandle.dragTempFileFilter.Substring(0, 14)))
                UI.messageBox("Use the gear icon to open this file in the package manager.", "Device Explorer", MessageBoxIcon.Warning, MessageBoxButtons.OK);
            else
                fixFiles((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            int failed = 0;
            foreach (string File in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (File.Contains(FatxHandle.dragTempFileFilter.Substring(0, 14)))
                {
                    if (cmdFatxGear.Enabled)
                        FormConfig.formOpenClick(cmdFatxGear, null);
                }
                else
                {
                    XContent.XContentPackage Package = new XContent.XContentPackage();
                    if (Package.LoadPackage(File))
                        FormHandle.initializeNewPackageManager(Package);
                    else
                    {
                        Package.CloseIO(true);
                        failed++;
                    }
                }
            }
            if (failed > 1)
                UI.messageBox("Failed to open " + failed.ToString() + " file" + (failed > 1 ? "s" : String.Empty) + "!", "Package Error", MessageBoxIcon.Error);
        }

        private void cmdSafeMode_Click(object sender, EventArgs e)
        {
            if (!cmdSafeMode.Checked && UI.messageBox("Other modding tools may not save your files correctly.<br></br><br></br>"
                + "If this happens, one of Modex360's editors may fail to mod your package and an error will pop up.<br></br><br></br>"
                + "When Safe Mode is enabled, Modex360 will rebuild your packages to prevent these errors from occuring.<br></br>"
                + "The only drawback is that it may take an extra few seconds to open your files into the editors.<br></br><br></br>"
                + "<b>ONLY USE SAFE MODE IF YOU ARE HAVING ISSUES WITH YOUR PACKAGES!</b><br></br><br></br>"
                + "Please note that this does NOT apply to files loaded from a Xbox 360 hard drive, memory card, or flash drive.<br></br><br></br>"
                + "Enable Safe Mode?", "Enable Safe Mode?", MessageBoxIcon.Information, MessageBoxButtons.YesNoCancel, MessageBoxDefaultButton.Button3)
                == DialogResult.Yes)
                cmdSafeMode.Checked = true;
            else
                cmdSafeMode.Checked = false;
        }

        private void cmdSafeMode_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.doneLoading)
            {
                Settings.Default.SafeMode = cmdSafeMode.Checked;
                Settings.Default.Save();
            }
        }

        private void cmdBackups_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.doneLoading)
            {
                Settings.Default.Backup = cmdBackups.Checked;
                Settings.Default.Save();
            }
        }

        private void cmdBackups_Click(object sender, EventArgs e)
        {
            if (!cmdBackups.Checked && UI.messageBox("Enabling backups will create a copy of your files before saving. This ensures that you will\n"
                + "have no loss of data if an error occurs while writing.\n\n"
                + "The backed up filename will be the same as the original, but with \".bak\" at the end.\n\n"
                + "Please note that this does NOT apply to files loaded from a Xbox 360 hard drive, memory card, or flash drive.\n\n"
                + "Enable Backups?", "Enable Backups?", MessageBoxIcon.Information, MessageBoxButtons.YesNoCancel, MessageBoxDefaultButton.Button3)
                == DialogResult.Yes)
                cmdBackups.Checked = true;
            else
                cmdBackups.Checked = false;
        }

        internal void expandContract(bool expand)
        {
            int size = expand ? 25 : -25;
            exFatx.Size = new Size(exFatx.Size.Width + size, exFatx.Size.Height);
            rbFatx.Size = new Size(rbFatx.Size.Width + size, rbFatx.Size.Height);
            progressFatx.Size = new Size(progressFatx.Size.Width + size, progressFatx.Size.Height);
            cmdFatxGear.Size = new Size(cmdFatxGear.Size.Width + size, cmdFatxGear.Size.Height);
            cmdFatxContract.Enabled = exFatx.Size.Width != 375;
            cmdFatxExpand.Enabled = exFatx.Size.Width != 575;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.shuttingDown = true;
            FatxHandle.unloadHandle();
            if (DeviceWindow.Handle != null)
                DeviceWindow.Handle.Close();
        }

        private void cmdFatxDevicesLoaded_Click(object sender, EventArgs e)
        {
            if (Environment.OSVersion.Version.Major > 5)
                UI.messageBox("If you do not see all of your connected devices, be sure you are running Modex360 as an Administrator!",
                    "User Account Control", MessageBoxIcon.Information);
        }

        private void cmdDock_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.doneLoading)
            {
                if (cmdDock.Checked)
                {
                    if (DeviceWindow.Handle != null)
                        DeviceWindow.Handle.Close();
                    exFatx.Expanded = true;
                }
                else
                    new DeviceWindow(this).Show();
                Settings.Default.Docked = cmdDock.Checked;
                Settings.Default.Save();
            }
            exFatx.ExpandButtonVisible = cmdDock.Checked;
        }

        internal bool FatxPanelExpanded
        {
            set
            {
                if (cmdDock.Checked)
                    exFatx.Expanded = value;
                else
                    DeviceWindow.Open(this);
            }
        }

        internal static bool fatxExpanded = false;
        private void exFatx_ExpandedChanging(object sender, ExpandedChangeEventArgs e)
        {
            if (e.NewExpandedValue)
            {
                if (cmdDock.Checked)
                    fatxExpanded = true;
                else
                {
                    DeviceWindow.Open(this);
                    e.Cancel = true;
                }
            }
        }

        private void cmdFatxExpand_Click(object sender, EventArgs e)
        {
            expandContract(true);
        }

        private void cmdFatxContract_Click(object sender, EventArgs e)
        {
            expandContract(false);
        }
    }
}

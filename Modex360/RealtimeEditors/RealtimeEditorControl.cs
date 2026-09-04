/// Realtime Editors made by Riggy \\\

using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using JRPC_Client;
using Modex360.Functions;
using XDevkit;

namespace Modex360.RealtimeEditors
{
    public partial class RealtimeEditorControl : Office2007RibbonForm, IEditorControl, IDisposable
    {
        private int _configIndex;
        protected internal string TitleID;
        protected IXboxConsole xbox;
        protected virtual uint? CommandBufferAddress => null;
        protected virtual uint ExpectedVerificationValue => 0;
        protected virtual string GameName => null;
        protected virtual string RequiredTitleUpdate => null;
        protected virtual void OnHook(IXboxConsole xbox, uint? commandBufferAddress) { }
        protected virtual void EnableForm() { }
        protected virtual void DisableForm() { }

        internal FormHandle.FormConfig Meta
        {
            get { return FormHandle.Forms[_configIndex]; }
        }

        public RealtimeEditorControl()
        {
            InitializeComponent();
        }

        public void initiateForm(int x)
        {
            _configIndex = x;
            Meta.KillLastForm(this);
            if (Meta.Meta.UseMDI)
                MdiParent = Modex360.Forms.Main.mainForm;
            Initialize();
            Show();
        }

        public virtual void Initialize() { }

        private void cmdHook_Click(object sender, EventArgs e)
        {
            if (cmdHook.Text == "Hooked")
                return;
            cmdHook.Text = "Hooking...";
            cmdHook.ColorTable = eButtonColor.Orange;
            try
            {
                if (xbox.Connect(out xbox))
                {
                    string runningTitleId = xbox.XamGetCurrentTitleId().ToString("X8");
                    bool addressOk = CommandBufferAddress == null || xbox.ReadUInt32(CommandBufferAddress.Value) == ExpectedVerificationValue;
                    if (runningTitleId == TitleID && addressOk)
                    {
                        OnHook(xbox, CommandBufferAddress);
                        xbox.XNotify("Modex hook loaded");
                        cmdHook.ColorTable = eButtonColor.Blue;
                        cmdHook.Text = "Hooked";
                        EnableForm();
                    }
                    else
                    {
                        string requiredMessage = RequiredTitleUpdate != null
                            ? $"Make sure you have {GameName} running with Title Update {RequiredTitleUpdate}"
                            : $"Make sure you have {GameName} running";
                        cmdHook.Text = "Hook";
                        cmdHook.ColorTable = eButtonColor.BlueWithBackground;
                        UI.messageBox(requiredMessage, "Hook failed", MessageBoxIcon.Error);
                        DisableForm();
                    }
                }
                else
                {
                    cmdHook.Text = "Hook";
                    cmdHook.ColorTable = eButtonColor.BlueWithBackground;
                    UI.messageBox("Hook failed.\nUnable to connect to Xbox 360", "Error", MessageBoxIcon.Error);
                    DisableForm();
                }
            }
            catch
            {
                UI.messageBox("Unable to connect to Xbox 360 \nMake sure you have the XDK installed.", "Error", MessageBoxIcon.Error);
                cmdHook.Text = "Hook";
                cmdHook.ColorTable = eButtonColor.BlueWithBackground;
                DisableForm();
            }
        }

        protected void SendCommand(string command, string notifyMessage = null)
        {
            try
            {
                xbox.CallVoid(CommandBufferAddress.Value, 0, command, 0);
                if (notifyMessage != null)
                    SoftNotify(notifyMessage);
            }
            catch (Exception)
            {
                ConnectionFailed();
            }
        }

        protected void SoftNotify(string message)
        {
            try { xbox.CallVoid(CommandBufferAddress.Value, 0, "say " + message, 0); }
            catch (Exception) { ConnectionFailed(); }
        }

        protected void ConnectionFailed()
        {
            UI.messageBox("Connection lost", "Error", MessageBoxIcon.Error);
            DisableForm();
        }

        protected void WriteToggle(bool isOn, uint address, uint onValue, uint offValue, string onMessage, string offMessage)
        {
            try
            {
                xbox.WriteInt32(address, unchecked((int)(isOn ? onValue : offValue)));
                xbox.XNotify(isOn ? onMessage : offMessage);
            }
            catch (Exception) { ConnectionFailed(); }
        }
    }
}
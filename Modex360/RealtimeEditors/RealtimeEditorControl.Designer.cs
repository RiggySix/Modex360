namespace Modex360.RealtimeEditors
{
    partial class RealtimeEditorControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealtimeEditorControl));
            this.rbRealtimeEditor = new DevComponents.DotNetBar.RibbonControl();
            this.panelMain = new DevComponents.DotNetBar.RibbonPanel();
            this.cmdHook = new DevComponents.DotNetBar.Office2007StartButton();
            this.tabMain = new DevComponents.DotNetBar.RibbonTabItem();
            this.rbRealtimeEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbRealtimeEditor
            // 
            this.rbRealtimeEditor.AutoExpand = false;
            // 
            // 
            // 
            this.rbRealtimeEditor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbRealtimeEditor.CanCustomize = false;
            this.rbRealtimeEditor.CaptionVisible = true;
            this.rbRealtimeEditor.Controls.Add(this.panelMain);
            this.rbRealtimeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbRealtimeEditor.EnableQatPlacement = false;
            this.rbRealtimeEditor.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cmdHook,
            this.tabMain});
            this.rbRealtimeEditor.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.rbRealtimeEditor.Location = new System.Drawing.Point(5, 1);
            this.rbRealtimeEditor.Margin = new System.Windows.Forms.Padding(0);
            this.rbRealtimeEditor.Name = "rbRealtimeEditor";
            this.rbRealtimeEditor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.rbRealtimeEditor.Size = new System.Drawing.Size(383, 222);
            this.rbRealtimeEditor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbRealtimeEditor.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.rbRealtimeEditor.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.rbRealtimeEditor.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.rbRealtimeEditor.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.rbRealtimeEditor.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.rbRealtimeEditor.SystemText.QatDialogAddButton = "&Add >>";
            this.rbRealtimeEditor.SystemText.QatDialogCancelButton = "Cancel";
            this.rbRealtimeEditor.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.rbRealtimeEditor.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.rbRealtimeEditor.SystemText.QatDialogOkButton = "OK";
            this.rbRealtimeEditor.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.rbRealtimeEditor.SystemText.QatDialogRemoveButton = "&Remove";
            this.rbRealtimeEditor.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.rbRealtimeEditor.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.rbRealtimeEditor.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.rbRealtimeEditor.TabGroupHeight = 14;
            this.rbRealtimeEditor.TabIndex = 0;
            this.rbRealtimeEditor.Text = "ribbonControl1";
            // 
            // panelMain
            // 
            this.panelMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 53);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelMain.Size = new System.Drawing.Size(383, 166);
            // 
            // 
            // 
            this.panelMain.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelMain.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelMain.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelMain.TabIndex = 1;
            // 
            // cmdHook
            // 
            this.cmdHook.CanCustomize = false;
            this.cmdHook.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground;
            this.cmdHook.FixedSize = new System.Drawing.Size(60, 23);
            this.cmdHook.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.cmdHook.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.cmdHook.ImagePaddingHorizontal = 0;
            this.cmdHook.ImagePaddingVertical = 0;
            this.cmdHook.Name = "cmdHook";
            this.cmdHook.ShowSubItems = false;
            this.cmdHook.Text = "Hook";
            this.cmdHook.Click += new System.EventHandler(this.cmdHook_Click);
            // 
            // tabMain
            // 
            this.tabMain.Checked = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.Panel = this.panelMain;
            this.tabMain.Text = "Realtime Editor";
            // 
            // RealtimeEditorControl
            // 
            this.BottomLeftCornerSize = 0;
            this.BottomRightCornerSize = 0;
            this.ClientSize = new System.Drawing.Size(393, 225);
            this.Controls.Add(this.rbRealtimeEditor);
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RealtimeEditorControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.rbRealtimeEditor.ResumeLayout(false);
            this.rbRealtimeEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected DevComponents.DotNetBar.RibbonPanel panelMain;
        protected DevComponents.DotNetBar.RibbonTabItem tabMain;
        public DevComponents.DotNetBar.Office2007StartButton cmdHook;
        public DevComponents.DotNetBar.RibbonControl rbRealtimeEditor;
    }
}
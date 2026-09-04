namespace Modex360.Forms
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonMain = new DevComponents.DotNetBar.RibbonControl();
            this.panelRealtimeEditors = new DevComponents.DotNetBar.RibbonPanel();
            this.panelTools = new DevComponents.DotNetBar.RibbonPanel();
            this.panelGameMods = new DevComponents.DotNetBar.RibbonPanel();
            this.panelProfileMods = new DevComponents.DotNetBar.RibbonPanel();
            this.panelMisc = new DevComponents.DotNetBar.RibbonPanel();
            this.cmdStatus = new DevComponents.DotNetBar.Office2007StartButton();
            this.tabRealtimeEditors = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabGameMods = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabProfileMods = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabTools = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabMisc = new DevComponents.DotNetBar.RibbonTabItem();
            this.cmdQuickFix = new DevComponents.DotNetBar.ButtonItem();
            this.panelStatus = new DevComponents.DotNetBar.PanelEx();
            this.cmdDock = new DevComponents.DotNetBar.ButtonX();
            this.cmdBackups = new DevComponents.DotNetBar.ButtonX();
            this.cmdSafeMode = new DevComponents.DotNetBar.ButtonX();
            this.cmdRotateTint = new DevComponents.DotNetBar.ButtonX();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.exFatx = new DevComponents.DotNetBar.ExpandablePanel();
            this.panelFatx = new DevComponents.DotNetBar.PanelEx();
            this.rbFatx = new DevComponents.DotNetBar.RibbonControl();
            this.rpFatxDrives = new DevComponents.DotNetBar.RibbonPanel();
            this.cmdFatxGear = new DevComponents.DotNetBar.ButtonX();
            this.cmdFatxMod = new DevComponents.DotNetBar.ButtonX();
            this.galFatx = new DevComponents.DotNetBar.GalleryContainer();
            this.cmdFatxExtract = new DevComponents.DotNetBar.ButtonX();
            this.cmdFatxInject = new DevComponents.DotNetBar.ButtonX();
            this.cmdFatxDevicesLoaded = new DevComponents.DotNetBar.Office2007StartButton();
            this.tabFatxDrive = new DevComponents.DotNetBar.RibbonTabItem();
            this.progressFatx = new System.Windows.Forms.ProgressBar();
            this.cmdFatxExpand = new DevComponents.DotNetBar.ButtonX();
            this.listFatx = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.menuFatx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdFatxToolExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFatxToolInject = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFatxToolDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFatxCopyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFatxNoDevicesFound = new System.Windows.Forms.ToolStripMenuItem();
            this.fatxMenuLine = new System.Windows.Forms.ToolStripSeparator();
            this.cmdFatxToolRenameDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFatxToolClearTitleCache = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFatxToolCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.cmdFatxContract = new DevComponents.DotNetBar.ButtonX();
            this.styleMain = new DevComponents.DotNetBar.StyleManager(this.components);
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.galleryContainer2 = new DevComponents.DotNetBar.GalleryContainer();
            this.colTreeInfo = new DevComponents.AdvTree.ColumnHeader();
            this.colTreeEntry = new DevComponents.AdvTree.ColumnHeader();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ribbonMain.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.exFatx.SuspendLayout();
            this.panelFatx.SuspendLayout();
            this.rbFatx.SuspendLayout();
            this.rpFatxDrives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFatx)).BeginInit();
            this.menuFatx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonMain
            // 
            this.ribbonMain.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.ribbonMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonMain.CanCustomize = false;
            this.ribbonMain.CaptionVisible = true;
            this.ribbonMain.Controls.Add(this.panelRealtimeEditors);
            this.ribbonMain.Controls.Add(this.panelTools);
            this.ribbonMain.Controls.Add(this.panelGameMods);
            this.ribbonMain.Controls.Add(this.panelProfileMods);
            this.ribbonMain.Controls.Add(this.panelMisc);
            this.ribbonMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonMain.EnableQatPlacement = false;
            this.ribbonMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ribbonMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cmdStatus,
            this.tabRealtimeEditors,
            this.tabGameMods,
            this.tabProfileMods,
            this.tabTools,
            this.tabMisc,
            this.cmdQuickFix});
            this.ribbonMain.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonMain.Location = new System.Drawing.Point(5, 1);
            this.ribbonMain.Name = "ribbonMain";
            this.ribbonMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonMain.Size = new System.Drawing.Size(980, 128);
            this.ribbonMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonMain.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonMain.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonMain.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonMain.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonMain.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonMain.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonMain.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonMain.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonMain.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonMain.SystemText.QatDialogOkButton = "OK";
            this.ribbonMain.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonMain.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonMain.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonMain.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonMain.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonMain.TabGroupHeight = 14;
            this.ribbonMain.TabIndex = 0;
            this.ribbonMain.Text = "Modex360";
            this.ribbonMain.SelectedRibbonTabChanged += new System.EventHandler(this.ribbonMain_SelectedRibbonTabChanged);
            // 
            // panelRealtimeEditors
            // 
            this.panelRealtimeEditors.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelRealtimeEditors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRealtimeEditors.Location = new System.Drawing.Point(0, 53);
            this.panelRealtimeEditors.Name = "panelRealtimeEditors";
            this.panelRealtimeEditors.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelRealtimeEditors.Size = new System.Drawing.Size(980, 72);
            // 
            // 
            // 
            this.panelRealtimeEditors.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelRealtimeEditors.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelRealtimeEditors.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelRealtimeEditors.TabIndex = 6;
            // 
            // panelTools
            // 
            this.panelTools.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTools.Location = new System.Drawing.Point(0, 53);
            this.panelTools.Name = "panelTools";
            this.panelTools.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelTools.Size = new System.Drawing.Size(980, 72);
            // 
            // 
            // 
            this.panelTools.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelTools.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelTools.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelTools.TabIndex = 4;
            this.panelTools.Visible = false;
            // 
            // panelGameMods
            // 
            this.panelGameMods.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelGameMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameMods.Location = new System.Drawing.Point(0, 53);
            this.panelGameMods.Name = "panelGameMods";
            this.panelGameMods.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelGameMods.Size = new System.Drawing.Size(980, 72);
            // 
            // 
            // 
            this.panelGameMods.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelGameMods.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelGameMods.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelGameMods.TabIndex = 2;
            this.panelGameMods.Visible = false;
            // 
            // panelProfileMods
            // 
            this.panelProfileMods.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelProfileMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfileMods.Location = new System.Drawing.Point(0, 53);
            this.panelProfileMods.Name = "panelProfileMods";
            this.panelProfileMods.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelProfileMods.Size = new System.Drawing.Size(980, 72);
            // 
            // 
            // 
            this.panelProfileMods.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelProfileMods.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelProfileMods.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelProfileMods.TabIndex = 3;
            this.panelProfileMods.Visible = false;
            // 
            // panelMisc
            // 
            this.panelMisc.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMisc.Location = new System.Drawing.Point(0, 53);
            this.panelMisc.Name = "panelMisc";
            this.panelMisc.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelMisc.Size = new System.Drawing.Size(980, 72);
            // 
            // 
            // 
            this.panelMisc.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelMisc.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelMisc.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelMisc.TabIndex = 5;
            this.panelMisc.Visible = false;
            // 
            // cmdStatus
            // 
            this.cmdStatus.CanCustomize = false;
            this.cmdStatus.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground;
            this.cmdStatus.FixedSize = new System.Drawing.Size(75, 23);
            this.cmdStatus.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.cmdStatus.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.cmdStatus.ImagePaddingHorizontal = 0;
            this.cmdStatus.ImagePaddingVertical = 0;
            this.cmdStatus.Name = "cmdStatus";
            this.cmdStatus.ShowSubItems = false;
            this.cmdStatus.Text = "Riggy.dev";
            this.cmdStatus.Click += new System.EventHandler(this.cmdStatus_Click);
            // 
            // tabRealtimeEditors
            // 
            this.tabRealtimeEditors.Checked = true;
            this.tabRealtimeEditors.Name = "tabRealtimeEditors";
            this.tabRealtimeEditors.Panel = this.panelRealtimeEditors;
            this.tabRealtimeEditors.Text = "Realtime Editors";
            // 
            // tabGameMods
            // 
            this.tabGameMods.Name = "tabGameMods";
            this.tabGameMods.Panel = this.panelGameMods;
            this.tabGameMods.Text = "Save Editors";
            // 
            // tabProfileMods
            // 
            this.tabProfileMods.Name = "tabProfileMods";
            this.tabProfileMods.Panel = this.panelProfileMods;
            this.tabProfileMods.Text = "Profile Mods";
            // 
            // tabTools
            // 
            this.tabTools.Name = "tabTools";
            this.tabTools.Panel = this.panelTools;
            this.tabTools.Text = "Tools";
            // 
            // tabMisc
            // 
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Panel = this.panelMisc;
            this.tabMisc.Text = "Miscellaneous";
            // 
            // cmdQuickFix
            // 
            this.cmdQuickFix.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.cmdQuickFix.Image = global::Modex360.Properties.Resources.Refresh;
            this.cmdQuickFix.Name = "cmdQuickFix";
            this.cmdQuickFix.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdQuickFix.Text = "Quick Fix ";
            this.cmdQuickFix.Click += new System.EventHandler(this.cmdQuickFix_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.AllowDrop = true;
            this.panelStatus.CanvasColor = System.Drawing.Color.Transparent;
            this.panelStatus.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelStatus.Controls.Add(this.cmdDock);
            this.panelStatus.Controls.Add(this.cmdBackups);
            this.panelStatus.Controls.Add(this.cmdSafeMode);
            this.panelStatus.Controls.Add(this.cmdRotateTint);
            this.panelStatus.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStatus.Location = new System.Drawing.Point(5, 637);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(980, 24);
            this.panelStatus.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelStatus.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelStatus.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panelStatus.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelStatus.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panelStatus.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this.panelStatus.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelStatus.Style.GradientAngle = 90;
            this.panelStatus.TabIndex = 3;
            this.panelStatus.Text = "Drag and Drop a File Here to Rehash and Resign                                   " +
    "                                      ";
            this.panelStatus.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelStatus_DragDrop);
            this.panelStatus.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelStatus_DragEnter);
            this.panelStatus.DragLeave += new System.EventHandler(this.panelStatus_DragLeave);
            // 
            // cmdDock
            // 
            this.cmdDock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdDock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDock.AutoCheckOnClick = true;
            this.cmdDock.Checked = true;
            this.cmdDock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdDock.FocusCuesEnabled = false;
            this.cmdDock.Location = new System.Drawing.Point(746, 0);
            this.cmdDock.Name = "cmdDock";
            this.cmdDock.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdDock.Size = new System.Drawing.Size(69, 25);
            this.cmdDock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdDock.TabIndex = 10;
            this.cmdDock.Text = "Docked";
            this.cmdDock.CheckedChanged += new System.EventHandler(this.cmdDock_CheckedChanged);
            // 
            // cmdBackups
            // 
            this.cmdBackups.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBackups.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdBackups.FocusCuesEnabled = false;
            this.cmdBackups.Location = new System.Drawing.Point(814, 0);
            this.cmdBackups.Name = "cmdBackups";
            this.cmdBackups.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdBackups.Size = new System.Drawing.Size(69, 25);
            this.cmdBackups.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdBackups.TabIndex = 9;
            this.cmdBackups.Text = "Backups";
            this.cmdBackups.CheckedChanged += new System.EventHandler(this.cmdBackups_CheckedChanged);
            this.cmdBackups.Click += new System.EventHandler(this.cmdBackups_Click);
            // 
            // cmdSafeMode
            // 
            this.cmdSafeMode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdSafeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSafeMode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdSafeMode.FocusCuesEnabled = false;
            this.cmdSafeMode.Location = new System.Drawing.Point(882, 0);
            this.cmdSafeMode.Name = "cmdSafeMode";
            this.cmdSafeMode.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdSafeMode.Size = new System.Drawing.Size(69, 25);
            this.cmdSafeMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdSafeMode.TabIndex = 8;
            this.cmdSafeMode.Text = "Safe Mode";
            this.cmdSafeMode.CheckedChanged += new System.EventHandler(this.cmdSafeMode_CheckedChanged);
            this.cmdSafeMode.Click += new System.EventHandler(this.cmdSafeMode_Click);
            // 
            // cmdRotateTint
            // 
            this.cmdRotateTint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdRotateTint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRotateTint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdRotateTint.FocusCuesEnabled = false;
            this.cmdRotateTint.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRotateTint.Image = global::Modex360.Properties.Resources.WarpZone;
            this.cmdRotateTint.Location = new System.Drawing.Point(950, 0);
            this.cmdRotateTint.Name = "cmdRotateTint";
            this.cmdRotateTint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdRotateTint.Size = new System.Drawing.Size(31, 25);
            this.cmdRotateTint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdRotateTint.TabIndex = 1;
            this.cmdRotateTint.TabStop = false;
            this.cmdRotateTint.Click += new System.EventHandler(this.cmdRotateTint_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Text = "Load Drive";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Text = "Entry";
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.office2007StartButton1.ImagePaddingHorizontal = 0;
            this.office2007StartButton1.ImagePaddingVertical = 0;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.Text = "Refresh";
            // 
            // exFatx
            // 
            this.exFatx.CanvasColor = System.Drawing.SystemColors.Control;
            this.exFatx.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.exFatx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.exFatx.Controls.Add(this.panelFatx);
            this.exFatx.DisabledBackColor = System.Drawing.Color.Empty;
            this.exFatx.Dock = System.Windows.Forms.DockStyle.Right;
            this.exFatx.Expanded = false;
            this.exFatx.ExpandedBounds = new System.Drawing.Rectangle(610, 129, 375, 508);
            this.exFatx.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exFatx.Location = new System.Drawing.Point(955, 129);
            this.exFatx.Name = "exFatx";
            this.exFatx.Size = new System.Drawing.Size(30, 508);
            this.exFatx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.exFatx.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.exFatx.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.exFatx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.exFatx.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.exFatx.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.exFatx.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.exFatx.Style.GradientAngle = 90;
            this.exFatx.Style.UseMnemonic = false;
            this.exFatx.TabIndex = 6;
            this.exFatx.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.exFatx.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.exFatx.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.exFatx.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.Raised;
            this.exFatx.TitleStyle.BorderColor.Color = System.Drawing.Color.Black;
            this.exFatx.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.exFatx.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.exFatx.TitleStyle.GradientAngle = 90;
            this.exFatx.TitleText = "Device Explorer";
            this.exFatx.ExpandedChanging += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.exFatx_ExpandedChanging);
            // 
            // panelFatx
            // 
            this.panelFatx.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFatx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelFatx.Controls.Add(this.rbFatx);
            this.panelFatx.Controls.Add(this.progressFatx);
            this.panelFatx.Controls.Add(this.cmdFatxExpand);
            this.panelFatx.Controls.Add(this.listFatx);
            this.panelFatx.Controls.Add(this.cmdFatxContract);
            this.panelFatx.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelFatx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFatx.Location = new System.Drawing.Point(0, 26);
            this.panelFatx.Name = "panelFatx";
            this.panelFatx.Size = new System.Drawing.Size(30, 482);
            this.panelFatx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFatx.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.panelFatx.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.panelFatx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFatx.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFatx.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFatx.Style.GradientAngle = 90;
            this.panelFatx.TabIndex = 16;
            // 
            // rbFatx
            // 
            this.rbFatx.AutoExpand = false;
            // 
            // 
            // 
            this.rbFatx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbFatx.CanCustomize = false;
            this.rbFatx.Controls.Add(this.rpFatxDrives);
            this.rbFatx.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cmdFatxDevicesLoaded,
            this.tabFatxDrive});
            this.rbFatx.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.rbFatx.Location = new System.Drawing.Point(1, 0);
            this.rbFatx.Name = "rbFatx";
            this.rbFatx.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.rbFatx.Size = new System.Drawing.Size(375, 76);
            this.rbFatx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbFatx.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.rbFatx.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.rbFatx.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.rbFatx.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.rbFatx.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.rbFatx.SystemText.QatDialogAddButton = "&Add >>";
            this.rbFatx.SystemText.QatDialogCancelButton = "Cancel";
            this.rbFatx.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.rbFatx.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.rbFatx.SystemText.QatDialogOkButton = "OK";
            this.rbFatx.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.rbFatx.SystemText.QatDialogRemoveButton = "&Remove";
            this.rbFatx.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.rbFatx.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.rbFatx.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.rbFatx.TabGroupHeight = 14;
            this.rbFatx.TabIndex = 1;
            // 
            // rpFatxDrives
            // 
            this.rpFatxDrives.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rpFatxDrives.Controls.Add(this.cmdFatxGear);
            this.rpFatxDrives.Controls.Add(this.cmdFatxMod);
            this.rpFatxDrives.Controls.Add(this.cmdFatxExtract);
            this.rpFatxDrives.Controls.Add(this.cmdFatxInject);
            this.rpFatxDrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpFatxDrives.Location = new System.Drawing.Point(0, 25);
            this.rpFatxDrives.Name = "rpFatxDrives";
            this.rpFatxDrives.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rpFatxDrives.Size = new System.Drawing.Size(375, 48);
            // 
            // 
            // 
            this.rpFatxDrives.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpFatxDrives.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rpFatxDrives.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rpFatxDrives.TabIndex = 1;
            // 
            // cmdFatxGear
            // 
            this.cmdFatxGear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdFatxGear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFatxGear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdFatxGear.Enabled = false;
            this.cmdFatxGear.FocusCuesEnabled = false;
            this.cmdFatxGear.Image = global::Modex360.Properties.Resources.Gear;
            this.cmdFatxGear.ImageTextSpacing = 3;
            this.cmdFatxGear.Location = new System.Drawing.Point(329, 0);
            this.cmdFatxGear.Name = "cmdFatxGear";
            this.cmdFatxGear.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdFatxGear.Size = new System.Drawing.Size(45, 51);
            this.cmdFatxGear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdFatxGear.TabIndex = 0;
            this.cmdFatxGear.Tooltip = "Open in Package Manager";
            // 
            // cmdFatxMod
            // 
            this.cmdFatxMod.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdFatxMod.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdFatxMod.Enabled = false;
            this.cmdFatxMod.FocusCuesEnabled = false;
            this.cmdFatxMod.Image = global::Modex360.Properties.Resources.QuestionMarkWide;
            this.cmdFatxMod.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.cmdFatxMod.ImageTextSpacing = 2;
            this.cmdFatxMod.Location = new System.Drawing.Point(166, 0);
            this.cmdFatxMod.Name = "cmdFatxMod";
            this.cmdFatxMod.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdFatxMod.ShowSubItems = false;
            this.cmdFatxMod.Size = new System.Drawing.Size(164, 51);
            this.cmdFatxMod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdFatxMod.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.galFatx});
            this.cmdFatxMod.TabIndex = 1;
            this.cmdFatxMod.Text = " Mod";
            this.cmdFatxMod.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.cmdFatxMod.Tooltip = "Mod this Package";
            // 
            // galFatx
            // 
            // 
            // 
            // 
            this.galFatx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galFatx.DefaultSize = new System.Drawing.Size(144, 405);
            this.galFatx.GlobalItem = false;
            this.galFatx.MinimumSize = new System.Drawing.Size(58, 58);
            this.galFatx.Name = "galFatx";
            this.galFatx.StretchGallery = true;
            // 
            // 
            // 
            this.galFatx.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.galFatx.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // cmdFatxExtract
            // 
            this.cmdFatxExtract.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdFatxExtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFatxExtract.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdFatxExtract.Enabled = false;
            this.cmdFatxExtract.FocusCuesEnabled = false;
            this.cmdFatxExtract.Location = new System.Drawing.Point(-1, 0);
            this.cmdFatxExtract.Name = "cmdFatxExtract";
            this.cmdFatxExtract.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdFatxExtract.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxExtract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdFatxExtract.TabIndex = 2;
            this.cmdFatxExtract.Text = "Extract Selected File";
            // 
            // cmdFatxInject
            // 
            this.cmdFatxInject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdFatxInject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdFatxInject.Enabled = false;
            this.cmdFatxInject.FocusCuesEnabled = false;
            this.cmdFatxInject.Location = new System.Drawing.Point(-1, 25);
            this.cmdFatxInject.Name = "cmdFatxInject";
            this.cmdFatxInject.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdFatxInject.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxInject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdFatxInject.TabIndex = 3;
            this.cmdFatxInject.Text = "Inject New File";
            // 
            // cmdFatxDevicesLoaded
            // 
            this.cmdFatxDevicesLoaded.CanCustomize = false;
            this.cmdFatxDevicesLoaded.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground;
            this.cmdFatxDevicesLoaded.FixedSize = new System.Drawing.Size(105, 23);
            this.cmdFatxDevicesLoaded.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.cmdFatxDevicesLoaded.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.cmdFatxDevicesLoaded.ImagePaddingHorizontal = 0;
            this.cmdFatxDevicesLoaded.ImagePaddingVertical = 0;
            this.cmdFatxDevicesLoaded.Name = "cmdFatxDevicesLoaded";
            this.cmdFatxDevicesLoaded.ShowSubItems = false;
            this.cmdFatxDevicesLoaded.Text = "0 Devices Loaded";
            // 
            // tabFatxDrive
            // 
            this.tabFatxDrive.Checked = true;
            this.tabFatxDrive.Name = "tabFatxDrive";
            this.tabFatxDrive.Panel = this.rpFatxDrives;
            this.tabFatxDrive.Text = "Connect a Device";
            // 
            // progressFatx
            // 
            this.progressFatx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressFatx.Location = new System.Drawing.Point(1, 459);
            this.progressFatx.Name = "progressFatx";
            this.progressFatx.Size = new System.Drawing.Size(228, 23);
            this.progressFatx.TabIndex = 6;
            // 
            // cmdFatxExpand
            // 
            this.cmdFatxExpand.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdFatxExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFatxExpand.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdFatxExpand.FocusCuesEnabled = false;
            this.cmdFatxExpand.Image = global::Modex360.Properties.Resources.Plus;
            this.cmdFatxExpand.Location = new System.Drawing.Point(-43, 458);
            this.cmdFatxExpand.Name = "cmdFatxExpand";
            this.cmdFatxExpand.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdFatxExpand.Size = new System.Drawing.Size(74, 25);
            this.cmdFatxExpand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdFatxExpand.TabIndex = 4;
            this.cmdFatxExpand.Text = "Expand";
            this.cmdFatxExpand.Click += new System.EventHandler(this.cmdFatxExpand_Click);
            // 
            // listFatx
            // 
            this.listFatx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFatx.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.listFatx.BackgroundStyle.Class = "TreeBorderKey";
            this.listFatx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listFatx.CellEdit = true;
            this.listFatx.Columns.Add(this.columnHeader1);
            this.listFatx.Columns.Add(this.columnHeader2);
            this.listFatx.ContextMenuStrip = this.menuFatx;
            this.listFatx.DragDropEnabled = false;
            this.listFatx.DragDropNodeCopyEnabled = false;
            this.listFatx.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle;
            this.listFatx.ExpandWidth = 14;
            this.listFatx.GridColumnLines = false;
            this.listFatx.GridRowLines = true;
            this.listFatx.HotTracking = true;
            this.listFatx.Location = new System.Drawing.Point(0, 74);
            this.listFatx.MultiNodeDragDropAllowed = false;
            this.listFatx.Name = "listFatx";
            this.listFatx.NodesConnector = this.nodeConnector1;
            this.listFatx.NodeStyle = this.elementStyle2;
            this.listFatx.PathSeparator = ";";
            this.listFatx.Size = new System.Drawing.Size(31, 385);
            this.listFatx.Styles.Add(this.elementStyle2);
            this.listFatx.TabIndex = 3;
            // 
            // columnHeader1
            // 
            this.columnHeader1.MinimumWidth = 60;
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Entry";
            this.columnHeader1.Width.AutoSize = true;
            this.columnHeader1.Width.AutoSizeMinHeader = true;
            // 
            // columnHeader2
            // 
            this.columnHeader2.MinimumWidth = 60;
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Info";
            this.columnHeader2.Width.AutoSize = true;
            this.columnHeader2.Width.AutoSizeMinHeader = true;
            // 
            // menuFatx
            // 
            this.menuFatx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFatx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdFatxToolExtract,
            this.cmdFatxToolInject,
            this.cmdFatxToolDelete,
            this.cmdFatxCopyFile,
            this.fatxMenuLine,
            this.cmdFatxToolRenameDevice,
            this.cmdFatxToolClearTitleCache,
            this.cmdFatxToolCollapseAll});
            this.menuFatx.Name = "menuFatx";
            this.menuFatx.Size = new System.Drawing.Size(169, 192);
            // 
            // cmdFatxToolExtract
            // 
            this.cmdFatxToolExtract.Enabled = false;
            this.cmdFatxToolExtract.Image = global::Modex360.Properties.Resources.UpArrowSilver;
            this.cmdFatxToolExtract.Name = "cmdFatxToolExtract";
            this.cmdFatxToolExtract.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxToolExtract.Text = "Extract File...";
            // 
            // cmdFatxToolInject
            // 
            this.cmdFatxToolInject.Enabled = false;
            this.cmdFatxToolInject.Image = global::Modex360.Properties.Resources.DownArrow;
            this.cmdFatxToolInject.Name = "cmdFatxToolInject";
            this.cmdFatxToolInject.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxToolInject.Text = "Inject File...";
            // 
            // cmdFatxToolDelete
            // 
            this.cmdFatxToolDelete.Enabled = false;
            this.cmdFatxToolDelete.Image = global::Modex360.Properties.Resources.Delete;
            this.cmdFatxToolDelete.Name = "cmdFatxToolDelete";
            this.cmdFatxToolDelete.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxToolDelete.Text = "Delete";
            // 
            // cmdFatxCopyFile
            // 
            this.cmdFatxCopyFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdFatxNoDevicesFound});
            this.cmdFatxCopyFile.Enabled = false;
            this.cmdFatxCopyFile.Image = global::Modex360.Properties.Resources.RightArrow;
            this.cmdFatxCopyFile.Name = "cmdFatxCopyFile";
            this.cmdFatxCopyFile.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxCopyFile.Text = "Copy to Device";
            // 
            // cmdFatxNoDevicesFound
            // 
            this.cmdFatxNoDevicesFound.Enabled = false;
            this.cmdFatxNoDevicesFound.Image = global::Modex360.Properties.Resources.Info;
            this.cmdFatxNoDevicesFound.Name = "cmdFatxNoDevicesFound";
            this.cmdFatxNoDevicesFound.Size = new System.Drawing.Size(170, 22);
            this.cmdFatxNoDevicesFound.Text = "No Devices Found";
            // 
            // fatxMenuLine
            // 
            this.fatxMenuLine.Name = "fatxMenuLine";
            this.fatxMenuLine.Size = new System.Drawing.Size(165, 6);
            this.fatxMenuLine.Visible = false;
            // 
            // cmdFatxToolRenameDevice
            // 
            this.cmdFatxToolRenameDevice.Image = global::Modex360.Properties.Resources.Pencil;
            this.cmdFatxToolRenameDevice.Name = "cmdFatxToolRenameDevice";
            this.cmdFatxToolRenameDevice.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxToolRenameDevice.Text = "Rename Device...";
            this.cmdFatxToolRenameDevice.Visible = false;
            // 
            // cmdFatxToolClearTitleCache
            // 
            this.cmdFatxToolClearTitleCache.Image = global::Modex360.Properties.Resources.Partition;
            this.cmdFatxToolClearTitleCache.Name = "cmdFatxToolClearTitleCache";
            this.cmdFatxToolClearTitleCache.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxToolClearTitleCache.Text = "Clear Title Cache";
            this.cmdFatxToolClearTitleCache.Visible = false;
            // 
            // cmdFatxToolCollapseAll
            // 
            this.cmdFatxToolCollapseAll.Image = global::Modex360.Properties.Resources.Minus;
            this.cmdFatxToolCollapseAll.Name = "cmdFatxToolCollapseAll";
            this.cmdFatxToolCollapseAll.Size = new System.Drawing.Size(168, 26);
            this.cmdFatxToolCollapseAll.Text = "Collapse All";
            this.cmdFatxToolCollapseAll.Visible = false;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlDark;
            // 
            // elementStyle2
            // 
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // cmdFatxContract
            // 
            this.cmdFatxContract.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cmdFatxContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFatxContract.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cmdFatxContract.Enabled = false;
            this.cmdFatxContract.FocusCuesEnabled = false;
            this.cmdFatxContract.Image = global::Modex360.Properties.Resources.Minus;
            this.cmdFatxContract.Location = new System.Drawing.Point(-116, 458);
            this.cmdFatxContract.Name = "cmdFatxContract";
            this.cmdFatxContract.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.cmdFatxContract.Size = new System.Drawing.Size(74, 25);
            this.cmdFatxContract.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmdFatxContract.TabIndex = 5;
            this.cmdFatxContract.Text = "Contract";
            this.cmdFatxContract.Click += new System.EventHandler(this.cmdFatxContract_Click);
            // 
            // styleMain
            // 
            this.styleMain.ManagerColorTint = System.Drawing.Color.Black;
            this.styleMain.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleMain.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(150, 200);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            // 
            // 
            // 
            this.galleryContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.galleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // galleryContainer2
            // 
            // 
            // 
            // 
            this.galleryContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer2.EnableGalleryPopup = false;
            this.galleryContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer2.MinimumSize = new System.Drawing.Size(150, 200);
            this.galleryContainer2.MultiLine = false;
            this.galleryContainer2.Name = "galleryContainer2";
            this.galleryContainer2.PopupUsesStandardScrollbars = false;
            // 
            // 
            // 
            this.galleryContainer2.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.galleryContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // colTreeInfo
            // 
            this.colTreeInfo.MinimumWidth = 60;
            this.colTreeInfo.Name = "colTreeInfo";
            this.colTreeInfo.Text = "Info";
            this.colTreeInfo.Width.AutoSize = true;
            this.colTreeInfo.Width.AutoSizeMinHeader = true;
            // 
            // colTreeEntry
            // 
            this.colTreeEntry.MinimumWidth = 60;
            this.colTreeEntry.Name = "colTreeEntry";
            this.colTreeEntry.Text = "Entry";
            this.colTreeEntry.Width.AutoSize = true;
            this.colTreeEntry.Width.AutoSizeMinHeader = true;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Modex360.Properties.Resources.Tile;
            this.ClientSize = new System.Drawing.Size(990, 663);
            this.Controls.Add(this.exFatx);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.ribbonMain);
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(625, 400);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modex 360";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.ribbonMain.ResumeLayout(false);
            this.ribbonMain.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.exFatx.ResumeLayout(false);
            this.panelFatx.ResumeLayout(false);
            this.rbFatx.ResumeLayout(false);
            this.rbFatx.PerformLayout();
            this.rpFatxDrives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listFatx)).EndInit();
            this.menuFatx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.RibbonTabItem tabProfileMods;
        private DevComponents.DotNetBar.RibbonTabItem tabTools;
        private DevComponents.DotNetBar.RibbonTabItem tabMisc;
        private DevComponents.DotNetBar.ButtonItem cmdQuickFix;
        public DevComponents.DotNetBar.RibbonTabItem tabGameMods;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.ButtonX cmdRotateTint;
        private DevComponents.DotNetBar.StyleManager styleMain;
        private System.Windows.Forms.ContextMenuStrip menuFatx;
        internal DevComponents.DotNetBar.ButtonX cmdSafeMode;
        internal DevComponents.DotNetBar.ButtonX cmdBackups;
        internal DevComponents.DotNetBar.RibbonControl ribbonMain;
        internal DevComponents.DotNetBar.Office2007StartButton cmdStatus;
        internal DevComponents.DotNetBar.PanelEx panelStatus;
        internal DevComponents.DotNetBar.ExpandablePanel exFatx;
        internal System.Windows.Forms.ToolStripMenuItem cmdFatxToolExtract;
        internal System.Windows.Forms.ToolStripMenuItem cmdFatxToolInject;
        internal System.Windows.Forms.ToolStripMenuItem cmdFatxToolDelete;
        internal System.Windows.Forms.ToolStripMenuItem cmdFatxCopyFile;
        internal System.Windows.Forms.ToolStripMenuItem cmdFatxNoDevicesFound;
        internal DevComponents.DotNetBar.RibbonPanel panelGameMods;
        internal DevComponents.DotNetBar.RibbonPanel panelMisc;
        internal DevComponents.DotNetBar.RibbonPanel panelTools;
        internal DevComponents.DotNetBar.RibbonPanel panelProfileMods;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer2;
        internal System.Windows.Forms.ToolStripSeparator fatxMenuLine;
        internal System.Windows.Forms.ToolStripMenuItem cmdFatxToolClearTitleCache;
        internal System.Windows.Forms.ToolStripMenuItem cmdFatxToolRenameDevice;
        internal System.Windows.Forms.ToolStripMenuItem cmdFatxToolCollapseAll;
        internal DevComponents.DotNetBar.ButtonX cmdDock;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        internal DevComponents.AdvTree.ColumnHeader colTreeInfo;
        internal DevComponents.AdvTree.ColumnHeader colTreeEntry;
        internal DevComponents.DotNetBar.PanelEx panelFatx;
        internal DevComponents.DotNetBar.RibbonControl rbFatx;
        public DevComponents.DotNetBar.RibbonPanel rpFatxDrives;
        internal DevComponents.DotNetBar.ButtonX cmdFatxGear;
        internal DevComponents.DotNetBar.ButtonX cmdFatxMod;
        internal DevComponents.DotNetBar.GalleryContainer galFatx;
        internal DevComponents.DotNetBar.ButtonX cmdFatxExtract;
        internal DevComponents.DotNetBar.ButtonX cmdFatxInject;
        internal DevComponents.DotNetBar.Office2007StartButton cmdFatxDevicesLoaded;
        internal DevComponents.DotNetBar.RibbonTabItem tabFatxDrive;
        internal System.Windows.Forms.ProgressBar progressFatx;
        internal DevComponents.DotNetBar.ButtonX cmdFatxExpand;
        internal DevComponents.AdvTree.AdvTree listFatx;
        internal DevComponents.AdvTree.ColumnHeader columnHeader1;
        internal DevComponents.AdvTree.ColumnHeader columnHeader2;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        internal DevComponents.DotNetBar.ButtonX cmdFatxContract;
        private DevComponents.DotNetBar.RibbonTabItem tabRealtimeEditors;
        internal DevComponents.DotNetBar.RibbonPanel panelRealtimeEditors;
    }
}


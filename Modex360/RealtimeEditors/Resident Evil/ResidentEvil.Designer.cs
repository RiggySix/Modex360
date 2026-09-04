
namespace Modex360.RealtimeEditors.Resident_Evil
{
    partial class ResidentEvil
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
            this.tabInventory = new DevComponents.DotNetBar.RibbonTabItem();
            this.panelInventory = new DevComponents.DotNetBar.RibbonPanel();
            this.int_Slot8quantity = new DevComponents.Editors.IntegerInput();
            this.btn_Slot8addQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot8remove = new DevComponents.DotNetBar.ButtonX();
            this.int_Slot7quantity = new DevComponents.Editors.IntegerInput();
            this.btn_Slot7addQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot7remove = new DevComponents.DotNetBar.ButtonX();
            this.int_Slot6quantity = new DevComponents.Editors.IntegerInput();
            this.btn_Slot6addQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot6remove = new DevComponents.DotNetBar.ButtonX();
            this.int_Slot5quantity = new DevComponents.Editors.IntegerInput();
            this.btn_Slot5addQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot5remove = new DevComponents.DotNetBar.ButtonX();
            this.int_Slot4quantity = new DevComponents.Editors.IntegerInput();
            this.btn_Slot4addQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot4remove = new DevComponents.DotNetBar.ButtonX();
            this.int_Slot3quantity = new DevComponents.Editors.IntegerInput();
            this.btn_Slot3addQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot3remove = new DevComponents.DotNetBar.ButtonX();
            this.int_Slot2quantity = new DevComponents.Editors.IntegerInput();
            this.btn_Slot2addQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot2remove = new DevComponents.DotNetBar.ButtonX();
            this.int_Slot1quantity = new DevComponents.Editors.IntegerInput();
            this.btn_Slot1addQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot1remove = new DevComponents.DotNetBar.ButtonX();
            this.list_Items = new DevComponents.DotNetBar.ListBoxAdv();
            this.btn_Slot8 = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot1 = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot7 = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot2 = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot6 = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot3 = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot5 = new DevComponents.DotNetBar.ButtonX();
            this.btn_Slot4 = new DevComponents.DotNetBar.ButtonX();
            this.txt_SearchItem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_NoSaves = new DevComponents.DotNetBar.ButtonX();
            this.btn_InfInkR = new DevComponents.DotNetBar.ButtonX();
            this.btn_Godmode = new DevComponents.DotNetBar.ButtonX();
            this.btn_InfAmmo = new DevComponents.DotNetBar.ButtonX();
            this.panelMain.SuspendLayout();
            this.rbRealtimeEditor.SuspendLayout();
            this.panelInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot8quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot7quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot6quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot5quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot4quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot3quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot2quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot1quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btn_NoSaves);
            this.panelMain.Controls.Add(this.btn_InfInkR);
            this.panelMain.Controls.Add(this.btn_Godmode);
            this.panelMain.Controls.Add(this.btn_InfAmmo);
            this.panelMain.Enabled = false;
            this.panelMain.Location = new System.Drawing.Point(0, 53);
            this.panelMain.Size = new System.Drawing.Size(417, 80);
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
            this.panelMain.Visible = true;
            // 
            // tabMain
            // 
            this.tabMain.Text = "Player";
            // 
            // rbRealtimeEditor
            // 
            // 
            // 
            // 
            this.rbRealtimeEditor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbRealtimeEditor.Controls.Add(this.panelInventory);
            this.rbRealtimeEditor.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabInventory});
            this.rbRealtimeEditor.Size = new System.Drawing.Size(417, 136);
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
            this.rbRealtimeEditor.SelectedRibbonTabChanged += new System.EventHandler(this.rbRealtimeEditor_SelectedRibbonTabChanged);
            this.rbRealtimeEditor.Controls.SetChildIndex(this.panelInventory, 0);
            this.rbRealtimeEditor.Controls.SetChildIndex(this.panelMain, 0);
            // 
            // tabInventory
            // 
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Panel = this.panelInventory;
            this.tabInventory.Text = "Inventory";
            // 
            // panelInventory
            // 
            this.panelInventory.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelInventory.Controls.Add(this.int_Slot8quantity);
            this.panelInventory.Controls.Add(this.btn_Slot8addQuantity);
            this.panelInventory.Controls.Add(this.btn_Slot8remove);
            this.panelInventory.Controls.Add(this.int_Slot7quantity);
            this.panelInventory.Controls.Add(this.btn_Slot7addQuantity);
            this.panelInventory.Controls.Add(this.btn_Slot7remove);
            this.panelInventory.Controls.Add(this.int_Slot6quantity);
            this.panelInventory.Controls.Add(this.btn_Slot6addQuantity);
            this.panelInventory.Controls.Add(this.btn_Slot6remove);
            this.panelInventory.Controls.Add(this.int_Slot5quantity);
            this.panelInventory.Controls.Add(this.btn_Slot5addQuantity);
            this.panelInventory.Controls.Add(this.btn_Slot5remove);
            this.panelInventory.Controls.Add(this.int_Slot4quantity);
            this.panelInventory.Controls.Add(this.btn_Slot4addQuantity);
            this.panelInventory.Controls.Add(this.btn_Slot4remove);
            this.panelInventory.Controls.Add(this.int_Slot3quantity);
            this.panelInventory.Controls.Add(this.btn_Slot3addQuantity);
            this.panelInventory.Controls.Add(this.btn_Slot3remove);
            this.panelInventory.Controls.Add(this.int_Slot2quantity);
            this.panelInventory.Controls.Add(this.btn_Slot2addQuantity);
            this.panelInventory.Controls.Add(this.btn_Slot2remove);
            this.panelInventory.Controls.Add(this.int_Slot1quantity);
            this.panelInventory.Controls.Add(this.btn_Slot1addQuantity);
            this.panelInventory.Controls.Add(this.btn_Slot1remove);
            this.panelInventory.Controls.Add(this.list_Items);
            this.panelInventory.Controls.Add(this.btn_Slot8);
            this.panelInventory.Controls.Add(this.btn_Slot1);
            this.panelInventory.Controls.Add(this.btn_Slot7);
            this.panelInventory.Controls.Add(this.btn_Slot2);
            this.panelInventory.Controls.Add(this.btn_Slot6);
            this.panelInventory.Controls.Add(this.btn_Slot3);
            this.panelInventory.Controls.Add(this.btn_Slot5);
            this.panelInventory.Controls.Add(this.btn_Slot4);
            this.panelInventory.Controls.Add(this.txt_SearchItem);
            this.panelInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInventory.Enabled = false;
            this.panelInventory.Location = new System.Drawing.Point(0, 53);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelInventory.Size = new System.Drawing.Size(417, 80);
            // 
            // 
            // 
            this.panelInventory.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelInventory.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelInventory.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelInventory.TabIndex = 2;
            this.panelInventory.Visible = false;
            // 
            // int_Slot8quantity
            // 
            // 
            // 
            // 
            this.int_Slot8quantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Slot8quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Slot8quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Slot8quantity.Location = new System.Drawing.Point(314, 293);
            this.int_Slot8quantity.MaxValue = 100;
            this.int_Slot8quantity.MinValue = 0;
            this.int_Slot8quantity.Name = "int_Slot8quantity";
            this.int_Slot8quantity.Size = new System.Drawing.Size(64, 20);
            this.int_Slot8quantity.TabIndex = 70;
            this.int_Slot8quantity.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.int_Slot8quantity.WatermarkText = "Quantity";
            // 
            // btn_Slot8addQuantity
            // 
            this.btn_Slot8addQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot8addQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot8addQuantity.Image = global::Modex360.Properties.Resources.RightArrow;
            this.btn_Slot8addQuantity.Location = new System.Drawing.Point(377, 293);
            this.btn_Slot8addQuantity.Name = "btn_Slot8addQuantity";
            this.btn_Slot8addQuantity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot8addQuantity.Size = new System.Drawing.Size(29, 20);
            this.btn_Slot8addQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot8addQuantity.TabIndex = 69;
            this.btn_Slot8addQuantity.Click += new System.EventHandler(this.btn_Slot8addQuantity_Click);
            // 
            // btn_Slot8remove
            // 
            this.btn_Slot8remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot8remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot8remove.Image = global::Modex360.Properties.Resources.Delete;
            this.btn_Slot8remove.Location = new System.Drawing.Point(377, 241);
            this.btn_Slot8remove.Name = "btn_Slot8remove";
            this.btn_Slot8remove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot8remove.Size = new System.Drawing.Size(29, 53);
            this.btn_Slot8remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot8remove.TabIndex = 68;
            this.btn_Slot8remove.Click += new System.EventHandler(this.btn_Slot8remove_Click);
            // 
            // int_Slot7quantity
            // 
            // 
            // 
            // 
            this.int_Slot7quantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Slot7quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Slot7quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Slot7quantity.Location = new System.Drawing.Point(216, 293);
            this.int_Slot7quantity.MaxValue = 100;
            this.int_Slot7quantity.MinValue = 0;
            this.int_Slot7quantity.Name = "int_Slot7quantity";
            this.int_Slot7quantity.Size = new System.Drawing.Size(64, 20);
            this.int_Slot7quantity.TabIndex = 67;
            this.int_Slot7quantity.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.int_Slot7quantity.WatermarkText = "Quantity";
            // 
            // btn_Slot7addQuantity
            // 
            this.btn_Slot7addQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot7addQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot7addQuantity.Image = global::Modex360.Properties.Resources.RightArrow;
            this.btn_Slot7addQuantity.Location = new System.Drawing.Point(279, 293);
            this.btn_Slot7addQuantity.Name = "btn_Slot7addQuantity";
            this.btn_Slot7addQuantity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot7addQuantity.Size = new System.Drawing.Size(29, 20);
            this.btn_Slot7addQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot7addQuantity.TabIndex = 66;
            this.btn_Slot7addQuantity.Click += new System.EventHandler(this.btn_Slot7addQuantity_Click);
            // 
            // btn_Slot7remove
            // 
            this.btn_Slot7remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot7remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot7remove.Image = global::Modex360.Properties.Resources.Delete;
            this.btn_Slot7remove.Location = new System.Drawing.Point(279, 241);
            this.btn_Slot7remove.Name = "btn_Slot7remove";
            this.btn_Slot7remove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot7remove.Size = new System.Drawing.Size(29, 53);
            this.btn_Slot7remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot7remove.TabIndex = 65;
            this.btn_Slot7remove.Click += new System.EventHandler(this.btn_Slot7remove_Click);
            // 
            // int_Slot6quantity
            // 
            // 
            // 
            // 
            this.int_Slot6quantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Slot6quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Slot6quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Slot6quantity.Location = new System.Drawing.Point(314, 216);
            this.int_Slot6quantity.MaxValue = 100;
            this.int_Slot6quantity.MinValue = 0;
            this.int_Slot6quantity.Name = "int_Slot6quantity";
            this.int_Slot6quantity.Size = new System.Drawing.Size(64, 20);
            this.int_Slot6quantity.TabIndex = 64;
            this.int_Slot6quantity.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.int_Slot6quantity.WatermarkText = "Quantity";
            // 
            // btn_Slot6addQuantity
            // 
            this.btn_Slot6addQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot6addQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot6addQuantity.Image = global::Modex360.Properties.Resources.RightArrow;
            this.btn_Slot6addQuantity.Location = new System.Drawing.Point(377, 216);
            this.btn_Slot6addQuantity.Name = "btn_Slot6addQuantity";
            this.btn_Slot6addQuantity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot6addQuantity.Size = new System.Drawing.Size(29, 20);
            this.btn_Slot6addQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot6addQuantity.TabIndex = 63;
            this.btn_Slot6addQuantity.Click += new System.EventHandler(this.btn_Slot6addQuantity_Click);
            // 
            // btn_Slot6remove
            // 
            this.btn_Slot6remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot6remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot6remove.Image = global::Modex360.Properties.Resources.Delete;
            this.btn_Slot6remove.Location = new System.Drawing.Point(377, 164);
            this.btn_Slot6remove.Name = "btn_Slot6remove";
            this.btn_Slot6remove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot6remove.Size = new System.Drawing.Size(29, 53);
            this.btn_Slot6remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot6remove.TabIndex = 62;
            this.btn_Slot6remove.Click += new System.EventHandler(this.btn_Slot6remove_Click);
            // 
            // int_Slot5quantity
            // 
            // 
            // 
            // 
            this.int_Slot5quantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Slot5quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Slot5quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Slot5quantity.Location = new System.Drawing.Point(216, 216);
            this.int_Slot5quantity.MaxValue = 100;
            this.int_Slot5quantity.MinValue = 0;
            this.int_Slot5quantity.Name = "int_Slot5quantity";
            this.int_Slot5quantity.Size = new System.Drawing.Size(64, 20);
            this.int_Slot5quantity.TabIndex = 61;
            this.int_Slot5quantity.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.int_Slot5quantity.WatermarkText = "Quantity";
            // 
            // btn_Slot5addQuantity
            // 
            this.btn_Slot5addQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot5addQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot5addQuantity.Image = global::Modex360.Properties.Resources.RightArrow;
            this.btn_Slot5addQuantity.Location = new System.Drawing.Point(279, 216);
            this.btn_Slot5addQuantity.Name = "btn_Slot5addQuantity";
            this.btn_Slot5addQuantity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot5addQuantity.Size = new System.Drawing.Size(29, 20);
            this.btn_Slot5addQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot5addQuantity.TabIndex = 60;
            this.btn_Slot5addQuantity.Click += new System.EventHandler(this.btn_Slot5addQuantity_Click);
            // 
            // btn_Slot5remove
            // 
            this.btn_Slot5remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot5remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot5remove.Image = global::Modex360.Properties.Resources.Delete;
            this.btn_Slot5remove.Location = new System.Drawing.Point(279, 164);
            this.btn_Slot5remove.Name = "btn_Slot5remove";
            this.btn_Slot5remove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot5remove.Size = new System.Drawing.Size(29, 53);
            this.btn_Slot5remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot5remove.TabIndex = 59;
            this.btn_Slot5remove.Click += new System.EventHandler(this.btn_Slot5remove_Click);
            // 
            // int_Slot4quantity
            // 
            // 
            // 
            // 
            this.int_Slot4quantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Slot4quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Slot4quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Slot4quantity.Location = new System.Drawing.Point(314, 139);
            this.int_Slot4quantity.MaxValue = 100;
            this.int_Slot4quantity.MinValue = 0;
            this.int_Slot4quantity.Name = "int_Slot4quantity";
            this.int_Slot4quantity.Size = new System.Drawing.Size(64, 20);
            this.int_Slot4quantity.TabIndex = 58;
            this.int_Slot4quantity.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.int_Slot4quantity.WatermarkText = "Quantity";
            // 
            // btn_Slot4addQuantity
            // 
            this.btn_Slot4addQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot4addQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot4addQuantity.Image = global::Modex360.Properties.Resources.RightArrow;
            this.btn_Slot4addQuantity.Location = new System.Drawing.Point(377, 139);
            this.btn_Slot4addQuantity.Name = "btn_Slot4addQuantity";
            this.btn_Slot4addQuantity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot4addQuantity.Size = new System.Drawing.Size(29, 20);
            this.btn_Slot4addQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot4addQuantity.TabIndex = 57;
            this.btn_Slot4addQuantity.Click += new System.EventHandler(this.btn_Slot4addQuantity_Click);
            // 
            // btn_Slot4remove
            // 
            this.btn_Slot4remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot4remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot4remove.Image = global::Modex360.Properties.Resources.Delete;
            this.btn_Slot4remove.Location = new System.Drawing.Point(377, 87);
            this.btn_Slot4remove.Name = "btn_Slot4remove";
            this.btn_Slot4remove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot4remove.Size = new System.Drawing.Size(29, 53);
            this.btn_Slot4remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot4remove.TabIndex = 56;
            this.btn_Slot4remove.Click += new System.EventHandler(this.btn_Slot4remove_Click);
            // 
            // int_Slot3quantity
            // 
            // 
            // 
            // 
            this.int_Slot3quantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Slot3quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Slot3quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Slot3quantity.Location = new System.Drawing.Point(216, 139);
            this.int_Slot3quantity.MaxValue = 100;
            this.int_Slot3quantity.MinValue = 0;
            this.int_Slot3quantity.Name = "int_Slot3quantity";
            this.int_Slot3quantity.Size = new System.Drawing.Size(64, 20);
            this.int_Slot3quantity.TabIndex = 55;
            this.int_Slot3quantity.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.int_Slot3quantity.WatermarkText = "Quantity";
            // 
            // btn_Slot3addQuantity
            // 
            this.btn_Slot3addQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot3addQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot3addQuantity.Image = global::Modex360.Properties.Resources.RightArrow;
            this.btn_Slot3addQuantity.Location = new System.Drawing.Point(279, 139);
            this.btn_Slot3addQuantity.Name = "btn_Slot3addQuantity";
            this.btn_Slot3addQuantity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot3addQuantity.Size = new System.Drawing.Size(29, 20);
            this.btn_Slot3addQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot3addQuantity.TabIndex = 54;
            this.btn_Slot3addQuantity.Click += new System.EventHandler(this.btn_Slot3addQuantity_Click);
            // 
            // btn_Slot3remove
            // 
            this.btn_Slot3remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot3remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot3remove.Image = global::Modex360.Properties.Resources.Delete;
            this.btn_Slot3remove.Location = new System.Drawing.Point(279, 87);
            this.btn_Slot3remove.Name = "btn_Slot3remove";
            this.btn_Slot3remove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot3remove.Size = new System.Drawing.Size(29, 53);
            this.btn_Slot3remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot3remove.TabIndex = 53;
            this.btn_Slot3remove.Click += new System.EventHandler(this.btn_Slot3remove_Click);
            // 
            // int_Slot2quantity
            // 
            // 
            // 
            // 
            this.int_Slot2quantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Slot2quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Slot2quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Slot2quantity.Location = new System.Drawing.Point(314, 62);
            this.int_Slot2quantity.MaxValue = 100;
            this.int_Slot2quantity.MinValue = 0;
            this.int_Slot2quantity.Name = "int_Slot2quantity";
            this.int_Slot2quantity.Size = new System.Drawing.Size(64, 20);
            this.int_Slot2quantity.TabIndex = 52;
            this.int_Slot2quantity.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.int_Slot2quantity.WatermarkText = "Quantity";
            // 
            // btn_Slot2addQuantity
            // 
            this.btn_Slot2addQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot2addQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot2addQuantity.Image = global::Modex360.Properties.Resources.RightArrow;
            this.btn_Slot2addQuantity.Location = new System.Drawing.Point(377, 62);
            this.btn_Slot2addQuantity.Name = "btn_Slot2addQuantity";
            this.btn_Slot2addQuantity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot2addQuantity.Size = new System.Drawing.Size(29, 20);
            this.btn_Slot2addQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot2addQuantity.TabIndex = 51;
            this.btn_Slot2addQuantity.Click += new System.EventHandler(this.btn_Slot2addQuantity_Click);
            // 
            // btn_Slot2remove
            // 
            this.btn_Slot2remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot2remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot2remove.Image = global::Modex360.Properties.Resources.Delete;
            this.btn_Slot2remove.Location = new System.Drawing.Point(377, 10);
            this.btn_Slot2remove.Name = "btn_Slot2remove";
            this.btn_Slot2remove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot2remove.Size = new System.Drawing.Size(29, 53);
            this.btn_Slot2remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot2remove.TabIndex = 50;
            this.btn_Slot2remove.Click += new System.EventHandler(this.btn_Slot2remove_Click);
            // 
            // int_Slot1quantity
            // 
            // 
            // 
            // 
            this.int_Slot1quantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Slot1quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Slot1quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Slot1quantity.Location = new System.Drawing.Point(216, 62);
            this.int_Slot1quantity.MaxValue = 100;
            this.int_Slot1quantity.MinValue = 0;
            this.int_Slot1quantity.Name = "int_Slot1quantity";
            this.int_Slot1quantity.Size = new System.Drawing.Size(64, 20);
            this.int_Slot1quantity.TabIndex = 49;
            this.int_Slot1quantity.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.int_Slot1quantity.WatermarkText = "Quantity";
            // 
            // btn_Slot1addQuantity
            // 
            this.btn_Slot1addQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot1addQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot1addQuantity.Image = global::Modex360.Properties.Resources.RightArrow;
            this.btn_Slot1addQuantity.Location = new System.Drawing.Point(279, 62);
            this.btn_Slot1addQuantity.Name = "btn_Slot1addQuantity";
            this.btn_Slot1addQuantity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot1addQuantity.Size = new System.Drawing.Size(29, 20);
            this.btn_Slot1addQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot1addQuantity.TabIndex = 48;
            this.btn_Slot1addQuantity.Click += new System.EventHandler(this.btn_Slot1addQuantity_Click);
            // 
            // btn_Slot1remove
            // 
            this.btn_Slot1remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot1remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot1remove.Image = global::Modex360.Properties.Resources.Delete;
            this.btn_Slot1remove.Location = new System.Drawing.Point(279, 10);
            this.btn_Slot1remove.Name = "btn_Slot1remove";
            this.btn_Slot1remove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot1remove.Size = new System.Drawing.Size(29, 53);
            this.btn_Slot1remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot1remove.TabIndex = 47;
            this.btn_Slot1remove.Click += new System.EventHandler(this.btn_Slot1remove_Click);
            // 
            // list_Items
            // 
            this.list_Items.AutoScroll = true;
            // 
            // 
            // 
            this.list_Items.BackgroundStyle.Class = "ListBoxAdv";
            this.list_Items.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.list_Items.CheckStateMember = null;
            this.list_Items.ContainerControlProcessDialogKey = true;
            this.list_Items.DragDropSupport = true;
            this.list_Items.Location = new System.Drawing.Point(10, 10);
            this.list_Items.Name = "list_Items";
            this.list_Items.Size = new System.Drawing.Size(200, 284);
            this.list_Items.TabIndex = 46;
            // 
            // btn_Slot8
            // 
            this.btn_Slot8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot8.Image = global::Modex360.Properties.Resources.Plus;
            this.btn_Slot8.Location = new System.Drawing.Point(314, 241);
            this.btn_Slot8.Name = "btn_Slot8";
            this.btn_Slot8.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot8.Size = new System.Drawing.Size(64, 53);
            this.btn_Slot8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot8.TabIndex = 45;
            this.btn_Slot8.Text = "Slot 8";
            this.btn_Slot8.Click += new System.EventHandler(this.btn_Slot8_Click);
            // 
            // btn_Slot1
            // 
            this.btn_Slot1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot1.Image = global::Modex360.Properties.Resources.Plus;
            this.btn_Slot1.Location = new System.Drawing.Point(216, 10);
            this.btn_Slot1.Name = "btn_Slot1";
            this.btn_Slot1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot1.Size = new System.Drawing.Size(64, 53);
            this.btn_Slot1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot1.TabIndex = 38;
            this.btn_Slot1.Text = "Slot 1";
            this.btn_Slot1.Click += new System.EventHandler(this.btn_Slot1_Click);
            // 
            // btn_Slot7
            // 
            this.btn_Slot7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot7.Image = global::Modex360.Properties.Resources.Plus;
            this.btn_Slot7.Location = new System.Drawing.Point(216, 241);
            this.btn_Slot7.Name = "btn_Slot7";
            this.btn_Slot7.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot7.Size = new System.Drawing.Size(64, 53);
            this.btn_Slot7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot7.TabIndex = 44;
            this.btn_Slot7.Text = "Slot 7";
            this.btn_Slot7.Click += new System.EventHandler(this.btn_Slot7_Click);
            // 
            // btn_Slot2
            // 
            this.btn_Slot2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot2.Image = global::Modex360.Properties.Resources.Plus;
            this.btn_Slot2.Location = new System.Drawing.Point(314, 10);
            this.btn_Slot2.Name = "btn_Slot2";
            this.btn_Slot2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot2.Size = new System.Drawing.Size(64, 53);
            this.btn_Slot2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot2.TabIndex = 39;
            this.btn_Slot2.Text = "Slot 2";
            this.btn_Slot2.Click += new System.EventHandler(this.btn_Slot2_Click);
            // 
            // btn_Slot6
            // 
            this.btn_Slot6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot6.Image = global::Modex360.Properties.Resources.Plus;
            this.btn_Slot6.Location = new System.Drawing.Point(314, 164);
            this.btn_Slot6.Name = "btn_Slot6";
            this.btn_Slot6.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot6.Size = new System.Drawing.Size(64, 53);
            this.btn_Slot6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot6.TabIndex = 43;
            this.btn_Slot6.Text = "Slot 6";
            this.btn_Slot6.Click += new System.EventHandler(this.btn_Slot6_Click);
            // 
            // btn_Slot3
            // 
            this.btn_Slot3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot3.Image = global::Modex360.Properties.Resources.Plus;
            this.btn_Slot3.Location = new System.Drawing.Point(216, 87);
            this.btn_Slot3.Name = "btn_Slot3";
            this.btn_Slot3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot3.Size = new System.Drawing.Size(64, 53);
            this.btn_Slot3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot3.TabIndex = 40;
            this.btn_Slot3.Text = "Slot 3";
            this.btn_Slot3.Click += new System.EventHandler(this.btn_Slot3_Click);
            // 
            // btn_Slot5
            // 
            this.btn_Slot5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot5.Image = global::Modex360.Properties.Resources.Plus;
            this.btn_Slot5.Location = new System.Drawing.Point(216, 164);
            this.btn_Slot5.Name = "btn_Slot5";
            this.btn_Slot5.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot5.Size = new System.Drawing.Size(64, 53);
            this.btn_Slot5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot5.TabIndex = 42;
            this.btn_Slot5.Text = "Slot 5";
            this.btn_Slot5.Click += new System.EventHandler(this.btn_Slot5_Click);
            // 
            // btn_Slot4
            // 
            this.btn_Slot4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Slot4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Slot4.Image = global::Modex360.Properties.Resources.Plus;
            this.btn_Slot4.Location = new System.Drawing.Point(314, 87);
            this.btn_Slot4.Name = "btn_Slot4";
            this.btn_Slot4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Slot4.Size = new System.Drawing.Size(64, 53);
            this.btn_Slot4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Slot4.TabIndex = 41;
            this.btn_Slot4.Text = "Slot 4";
            this.btn_Slot4.Click += new System.EventHandler(this.btn_Slot4_Click);
            // 
            // txt_SearchItem
            // 
            // 
            // 
            // 
            this.txt_SearchItem.Border.Class = "TextBoxBorder";
            this.txt_SearchItem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchItem.Location = new System.Drawing.Point(10, 293);
            this.txt_SearchItem.Name = "txt_SearchItem";
            this.txt_SearchItem.PreventEnterBeep = true;
            this.txt_SearchItem.Size = new System.Drawing.Size(200, 20);
            this.txt_SearchItem.TabIndex = 71;
            this.txt_SearchItem.WatermarkText = "Search item";
            this.txt_SearchItem.TextChanged += new System.EventHandler(this.txt_SearchItem_TextChanged);
            // 
            // btn_NoSaves
            // 
            this.btn_NoSaves.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_NoSaves.AutoCheckOnClick = true;
            this.btn_NoSaves.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_NoSaves.Location = new System.Drawing.Point(304, 14);
            this.btn_NoSaves.Name = "btn_NoSaves";
            this.btn_NoSaves.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_NoSaves.Size = new System.Drawing.Size(87, 52);
            this.btn_NoSaves.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_NoSaves.TabIndex = 8;
            this.btn_NoSaves.Text = "Always                00 Saves";
            this.btn_NoSaves.CheckedChanged += new System.EventHandler(this.btn_NoSaves_CheckedChanged);
            // 
            // btn_InfInkR
            // 
            this.btn_InfInkR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_InfInkR.AutoCheckOnClick = true;
            this.btn_InfInkR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_InfInkR.Location = new System.Drawing.Point(211, 14);
            this.btn_InfInkR.Name = "btn_InfInkR";
            this.btn_InfInkR.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_InfInkR.Size = new System.Drawing.Size(87, 52);
            this.btn_InfInkR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_InfInkR.TabIndex = 7;
            this.btn_InfInkR.Text = "Infinite Ink Ribbons";
            this.btn_InfInkR.CheckedChanged += new System.EventHandler(this.btn_InfInkR_CheckedChanged);
            // 
            // btn_Godmode
            // 
            this.btn_Godmode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Godmode.AutoCheckOnClick = true;
            this.btn_Godmode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Godmode.Location = new System.Drawing.Point(25, 14);
            this.btn_Godmode.Name = "btn_Godmode";
            this.btn_Godmode.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_Godmode.Size = new System.Drawing.Size(87, 52);
            this.btn_Godmode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Godmode.TabIndex = 5;
            this.btn_Godmode.Text = "Infinite Health";
            this.btn_Godmode.CheckedChanged += new System.EventHandler(this.btn_Godmode_CheckedChanged);
            // 
            // btn_InfAmmo
            // 
            this.btn_InfAmmo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_InfAmmo.AutoCheckOnClick = true;
            this.btn_InfAmmo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_InfAmmo.Location = new System.Drawing.Point(118, 14);
            this.btn_InfAmmo.Name = "btn_InfAmmo";
            this.btn_InfAmmo.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_InfAmmo.Size = new System.Drawing.Size(87, 52);
            this.btn_InfAmmo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_InfAmmo.TabIndex = 6;
            this.btn_InfAmmo.Text = "Infinite Ammo";
            this.btn_InfAmmo.CheckedChanged += new System.EventHandler(this.btn_InfAmmo_CheckedChanged);
            // 
            // ResidentEvil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 139);
            this.MaximumSize = new System.Drawing.Size(427, 139);
            this.MinimumSize = new System.Drawing.Size(427, 139);
            this.Name = "ResidentEvil";
            this.Text = "Resident Evil";
            this.Load += new System.EventHandler(this.ResidentEvil_Load);
            this.panelMain.ResumeLayout(false);
            this.rbRealtimeEditor.ResumeLayout(false);
            this.rbRealtimeEditor.PerformLayout();
            this.panelInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot8quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot7quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot6quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot5quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot4quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot3quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot2quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_Slot1quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonPanel panelInventory;
        private DevComponents.DotNetBar.RibbonTabItem tabInventory;
        private DevComponents.DotNetBar.ButtonX btn_NoSaves;
        private DevComponents.DotNetBar.ButtonX btn_InfInkR;
        private DevComponents.DotNetBar.ButtonX btn_Godmode;
        private DevComponents.DotNetBar.ButtonX btn_InfAmmo;
        private DevComponents.Editors.IntegerInput int_Slot8quantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot8addQuantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot8remove;
        private DevComponents.Editors.IntegerInput int_Slot7quantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot7addQuantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot7remove;
        private DevComponents.Editors.IntegerInput int_Slot6quantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot6addQuantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot6remove;
        private DevComponents.Editors.IntegerInput int_Slot5quantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot5addQuantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot5remove;
        private DevComponents.Editors.IntegerInput int_Slot4quantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot4addQuantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot4remove;
        private DevComponents.Editors.IntegerInput int_Slot3quantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot3addQuantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot3remove;
        private DevComponents.Editors.IntegerInput int_Slot2quantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot2addQuantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot2remove;
        private DevComponents.Editors.IntegerInput int_Slot1quantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot1addQuantity;
        private DevComponents.DotNetBar.ButtonX btn_Slot1remove;
        private DevComponents.DotNetBar.ListBoxAdv list_Items;
        private DevComponents.DotNetBar.ButtonX btn_Slot8;
        private DevComponents.DotNetBar.ButtonX btn_Slot1;
        private DevComponents.DotNetBar.ButtonX btn_Slot7;
        private DevComponents.DotNetBar.ButtonX btn_Slot2;
        private DevComponents.DotNetBar.ButtonX btn_Slot6;
        private DevComponents.DotNetBar.ButtonX btn_Slot3;
        private DevComponents.DotNetBar.ButtonX btn_Slot5;
        private DevComponents.DotNetBar.ButtonX btn_Slot4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchItem;
    }
}
/// Realtime Editors made by Riggy \\\

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using JRPC_Client;
using XDevkit;

namespace Modex360.RealtimeEditors.Resident_Evil
{
    public partial class ResidentEvil : RealtimeEditorControl
    {
        protected override string GameName => this.Text;

        protected override void EnableForm()
        {
            panelMain.Enabled = true;
            panelInventory.Enabled = true;
        }

        protected override void DisableForm()
        {
            panelMain.Enabled = false;
            panelInventory.Enabled = false;
        }
        public ResidentEvil()
        {
            InitializeComponent();
            TitleID = FormID.ResidentEvil;
        }

        private void ItemSlot(int inventoryCase, bool addRemove)
        {
            int inventorySlot = 0x0;
            switch (inventoryCase)
            {
                case 1:
                    inventorySlot = 0x483A0DCC;
                    break;
                case 2:
                    inventorySlot = 0x483A0DD4;
                    break;
                case 3:
                    inventorySlot = 0x483A0DDC;
                    break;
                case 4:
                    inventorySlot = 0x483A0DE4;
                    break;
                case 5:
                    inventorySlot = 0x483A0DEC;
                    break;
                case 6:
                    inventorySlot = 0x483A0DF4;
                    break;
                case 7:
                    inventorySlot = 0x483A0DFC;
                    break;
                case 8:
                    inventorySlot = 0x483A0E04;
                    break;
            }
            switch (addRemove)
            {
                case true:
                    var selectedItem = list_Items.SelectedItem as DevComponents.DotNetBar.ListBoxItem;
                    if (selectedItem == null || !selectedItem.Enabled)
                    {
                        MessageBox.Show("Select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        string tag = selectedItem.Tag.ToString();
                        uint value = Convert.ToUInt32(tag.Replace("0x", ""), 16);
                        try
                        {
                            xbox.WriteInt32(Convert.ToUInt32(inventorySlot), unchecked((int)value));
                            xbox.XNotify(selectedItem.Text + " Added to Slot " + inventoryCase);
                        }
                        catch (Exception) { ConnectionFailed(); }
                    }
                    break;
                case false:
                    try
                    {
                        xbox.WriteInt32(Convert.ToUInt32(inventorySlot), unchecked((int)00));
                        xbox.XNotify("Item removed from Slot " + inventoryCase);
                    }
                    catch (Exception) { ConnectionFailed(); }
                    break;
            }
        }
        private void ItemSlotQuantity(int inventoryCase, int quantity)
        {
            int inventorySlot = 0x0;
            switch (inventoryCase)
            {
                case 1:
                    inventorySlot = 0x483A0DD0;
                    break;
                case 2:
                    inventorySlot = 0x483A0DD8;
                    break;
                case 3:
                    inventorySlot = 0x483A0DE0;
                    break;
                case 4:
                    inventorySlot = 0x483A0DE8;
                    break;
                case 5:
                    inventorySlot = 0x483A0DF0;
                    break;
                case 6:
                    inventorySlot = 0x483A0DF8;
                    break;
                case 7:
                    inventorySlot = 0x483A0E00;
                    break;
                case 8:
                    inventorySlot = 0x483A0E08;
                    break;
            }

            try
            {
                xbox.WriteInt32(Convert.ToUInt32(inventorySlot), unchecked((int)quantity));
                xbox.XNotify(quantity + " Quantity set to Slot " + inventoryCase);
            }
            catch (Exception) { ConnectionFailed(); }
        }

        private List<ListBoxItem> allItems = new List<ListBoxItem>();
        private void AddItem(string text, string tag)
        {
            var item = new ListBoxItem
            {
                Text = text,
                Tag = tag
            };

            allItems.Add(item);
            list_Items.Items.Add(item);
        }
        private void AddHeader(string text)
        {
            var item = new ListBoxItem
            {
                Text = text,
                Tag = "0x00000000",
                TextAlignment = eButtonTextAlignment.Center,
                Enabled = false
            };

            allItems.Add(item);
            list_Items.Items.Add(item);
        }

        private void ResidentEvil_Load(object sender, EventArgs e)
        {
            AddHeader("Weapons");
            AddItem("Survival Knife (Jill's)", "0x00000001");
            AddItem("Survival Knife(Chris's)", "0x00000002");
            AddItem("Handgun", "0x00000003");
            AddItem("Shotgun", "0x00000006");
            AddItem("Grenade Launcher (Explosive)", "0x00000007");
            AddItem("Grenade Launcher (Acid)", "0x00000008");
            AddItem("Grenade Launcher (Incendiary)", "0x00000009");
            AddItem("Rocket Launcher", "0x0000000A");
            AddItem("Magnum Revolver", "0x0000000B");
            AddItem("Flamethrower", "0x0000000C");
            AddItem("Assault Shotgun", "0x0000000D");
            AddItem("Samurai Edge (Infinite Ammo)", "0x00000005");
            AddItem("Rocket Launcher (Infinite Ammo)", "0x0000000E");
            AddItem("Barry's 44 Magnum", "0x0000000F");

            AddHeader("Ammo");
            AddItem("Handgun Magazine", "0x00000011");
            AddItem("Shotgun Shells", "0x00000012");
            AddItem("Grenade Shells (Explosive)", "0x00000010");
            AddItem("Grenade Shells (Acid)", "0x00000013");
            AddItem("Grenade Shells (Incendiary)", "0x00000014");
            AddItem("Magnum Rounds", "0x00000019");

            AddHeader("Self-defence Items");
            AddItem("Self-defence Gun", "0x00000004");
            AddItem("Dagger", "0x00000070");
            AddItem("Flash Grenade", "0x00000071");
            AddItem("Stun Gun", "0x00000072");
            AddItem("Battery Pack", "0x00000079");

            AddHeader("Health");
            AddItem("First Aid Spray", "0x00000021");
            AddItem("First Aid Box (First Aid Spray)", "0x00000065");
            AddItem("First Aid Box (Green Herb)", "0x00000068");
            AddItem("First Aid Box (Blue Herb)", "0x00000069");
            AddItem("Green Herb", "0x00000022");
            AddItem("Red Herb", "0x00000023");
            AddItem("Blue Herb", "0x00000024");
            AddItem("Mixed Herb (G+G)", "0x00000025");
            AddItem("Mixed Herb (G+G+G)", "0x00000026");
            AddItem("Mixed Herb (G+R)", "0x00000027");
            AddItem("Mixed Herb (G+B+R)", "0x00000028");
            AddItem("Mixed Herb (G+B)", "0x00000029");
            AddItem("Mixed Herb (G+G+B)", "0x0000002A");

            AddHeader("Items");
            AddItem("Ink Ribbons", "0x00000044");
            AddItem("Golden Arrow", "0x00000015");
            AddItem("Book of Curses", "0x00000016");
            AddItem("Coin", "0x00000017");
            AddItem("Collar", "0x00000018");
            AddItem("Broach", "0x0000001A");
            AddItem("Fuel Canteen", "0x0000001B");
            AddItem("Arrowhead", "0x0000001C");
            AddItem("Imitation of a key", "0x0000001D");
            AddItem("Gallery Key", "0x0000001E");
            AddItem("Fuel Supply Capsule (Full)", "0x0000001F");
            AddItem("Fuel Supply Capsule (Empty)", "0x0000006F");
            AddItem("Lockpick", "0x0000002B");
            AddItem("Old Key", "0x0000002C");
            AddItem("Sword Key", "0x0000002D");
            AddItem("Armor Key", "0x0000002E");
            AddItem("Shield Key", "0x0000002F");
            AddItem("Helmet Key", "0x00000030");
            AddItem("Key for Room 001", "0x00000031");
            AddItem("Key for Room 003", "0x00000032");
            AddItem("Medal of Eagle", "0x00000033");
            AddItem("Medal of Wolf", "0x00000034");
            AddItem("Key for the Power Area", "0x00000036");
            AddItem("Master Key (Laboratory)", "0x00000037");
            AddItem("Star Crest", "0x00000038");
            AddItem("Wind Crest", "0x00000039");
            AddItem("Sun Crest", "0x0000003A");
            AddItem("Moon Crest", "0x0000003B");
            AddItem("Crank (Square)", "0x0000003C");
            AddItem("Crank (Hexagonal)", "0x0000003D");
            AddItem("Closet Key", "0x0000003E");
            AddItem("Emblem Key", "0x0000003F");
            AddItem("Stone Ring", "0x00000040");
            AddItem("Metal Object", "0x00000041");
            AddItem("Stone & Metal Object", "0x00000035");
            AddItem("Battery", "0x00000043");
            AddItem("Emblem", "0x00000045");
            AddItem("Gold Emblem", "0x00000046");
            AddItem("Sheet Music", "0x00000047");
            AddItem("Musical Score (Missing Mid-pages)", "0x00000020");
            AddItem("Musical Score (Mid-pages)", "0x00000081");
            AddItem("Red Gemstone", "0x00000048");
            AddItem("Blue Gemstone", "0x00000049");
            AddItem("Yellow Gemstone", "0x0000004A");
            AddItem("Broken Shotgun", "0x0000004B");
            AddItem("Herbicide", "0x0000004C");
            AddItem("Lighter", "0x0000004D");
            AddItem("Transceiver", "0x0000004F");
            AddItem("Empty Bottle", "0x00000050");
            AddItem("Water", "0x00000051");
            AddItem("UMB No. 3", "0x00000052");
            AddItem("NP-004", "0x00000053");
            AddItem("Yellow-6", "0x00000054");
            AddItem("UMB No. 7", "0x00000055");
            AddItem("UMB No. 10", "0x00000056");
            AddItem("VP-017", "0x00000057");
            AddItem("V-JOLT", "0x00000058");
            AddItem("Red Book", "0x0000005A");
            AddItem("Last Book Vol. 1", "0x0000005B");
            AddItem("Last Book Vol. 2", "0x0000005C");
            AddItem("MO Disk (1)", "0x0000005D");
            AddItem("MO Disk (2)", "0x0000005E");
            AddItem("MO Disk (3)", "0x0000005F");
            AddItem("Dog Whistle", "0x00000060");
            AddItem("Fuse Unit", "0x00000061");
            AddItem("Jewelry Box (1)", "0x00000063");
            AddItem("Jewelry Box (2)", "0x00000066");
            AddItem("Jewelry Box (3)", "0x00000067");
            AddItem("Insecticide Spray", "0x00000064");
            AddItem("Signal Rockets", "0x0000006A");
            AddItem("Broken Flamethrower", "0x0000006B");
            AddItem("Wooden Mount", "0x0000006C");
            AddItem("Map (from Wooden Mount)", "0x00000082");
            AddItem("Slide Filter", "0x0000006D");
            AddItem("Control Room Key", "0x0000006E");
            AddItem("Bee Specimen", "0x00000073");
            AddItem("Lure of a bee", "0x00000074");
            AddItem("Fishhook", "0x00000075");
            AddItem("Lure of a bee (with fishhook)", "0x00000076");
            AddItem("X-Ray of CLARK", "0x00000077");
            AddItem("X-Ray of GAIL", "0x00000078");
            AddItem("Shaft", "0x0000007A");
            AddItem("Cylinder", "0x0000007B");
            AddItem("Cylinder Shaft", "0x0000007C");
            AddItem("Death Mask (no eyes, nose, mouth)", "0x0000007D");
            AddItem("Death Mask (no eyes)", "0x0000007E");
            AddItem("Death Mask (no nose)", "0x0000007F");
            AddItem("Death Mask (no mouth)", "0x00000080");
        }

        private void rbRealtimeEditor_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            if (rbRealtimeEditor.SelectedRibbonTabItem == tabInventory)
            {
                this.MinimumSize = new Size(427, 382);
                this.Refresh();
            }
            if (rbRealtimeEditor.SelectedRibbonTabItem == tabMain)
            {
                this.MaximumSize = new Size(427, 139);
                this.Refresh();
            }
        }

        private void btn_Godmode_CheckedChanged(object sender, EventArgs e) => WriteToggle(btn_Godmode.Checked, 0x822F45D0, 0x60000000, 0x907D13BC, "Infinite Health on", "Infinite Health off");
        private void btn_InfAmmo_CheckedChanged(object sender, EventArgs e) => WriteToggle(btn_InfAmmo.Checked, 0x824A1AA0, 0x60000000, 0x913F0FFC, "Infinite Ammo on", "Infinite Ammo off");
        private void btn_InfInkR_CheckedChanged(object sender, EventArgs e) => WriteToggle(btn_InfInkR.Checked, 0x82258404, 0x60000000, 0x93BE0004, "Infinite Ink Ribbons on", "Infinite Ink Ribbons off");
        private void btn_NoSaves_CheckedChanged(object sender, EventArgs e) => WriteToggle(btn_NoSaves.Checked, 0x821D0B3C, 0x60000000, 0x916A0000, "Always 00 Saves on", "Always 00 Saves off");

        private void btn_Slot1_Click(object sender, EventArgs e) => ItemSlot(1, true);
        private void btn_Slot2_Click(object sender, EventArgs e) => ItemSlot(2, true);
        private void btn_Slot3_Click(object sender, EventArgs e) => ItemSlot(3, true);
        private void btn_Slot4_Click(object sender, EventArgs e) => ItemSlot(4, true);
        private void btn_Slot5_Click(object sender, EventArgs e) => ItemSlot(5, true);
        private void btn_Slot6_Click(object sender, EventArgs e) => ItemSlot(6, true);
        private void btn_Slot7_Click(object sender, EventArgs e) => ItemSlot(7, true);
        private void btn_Slot8_Click(object sender, EventArgs e) => ItemSlot(8, true);
        private void btn_Slot1remove_Click(object sender, EventArgs e) => ItemSlot(1, false);
        private void btn_Slot2remove_Click(object sender, EventArgs e) => ItemSlot(2, false);
        private void btn_Slot3remove_Click(object sender, EventArgs e) => ItemSlot(3, false);
        private void btn_Slot4remove_Click(object sender, EventArgs e) => ItemSlot(4, false);
        private void btn_Slot5remove_Click(object sender, EventArgs e) => ItemSlot(5, false);
        private void btn_Slot6remove_Click(object sender, EventArgs e) => ItemSlot(6, false);
        private void btn_Slot7remove_Click(object sender, EventArgs e) => ItemSlot(7, false);
        private void btn_Slot8remove_Click(object sender, EventArgs e) => ItemSlot(8, false);
        private void btn_Slot1addQuantity_Click(object sender, EventArgs e) => ItemSlotQuantity(1, int_Slot1quantity.Value);
        private void btn_Slot2addQuantity_Click(object sender, EventArgs e) => ItemSlotQuantity(2, int_Slot2quantity.Value);
        private void btn_Slot3addQuantity_Click(object sender, EventArgs e) => ItemSlotQuantity(3, int_Slot3quantity.Value);
        private void btn_Slot4addQuantity_Click(object sender, EventArgs e) => ItemSlotQuantity(4, int_Slot4quantity.Value);
        private void btn_Slot5addQuantity_Click(object sender, EventArgs e) => ItemSlotQuantity(5, int_Slot5quantity.Value);
        private void btn_Slot6addQuantity_Click(object sender, EventArgs e) => ItemSlotQuantity(6, int_Slot6quantity.Value);
        private void btn_Slot7addQuantity_Click(object sender, EventArgs e) => ItemSlotQuantity(7, int_Slot7quantity.Value);
        private void btn_Slot8addQuantity_Click(object sender, EventArgs e) => ItemSlotQuantity(8, int_Slot8quantity.Value);

        private void txt_SearchItem_TextChanged(object sender, EventArgs e)
        {
            string search = txt_SearchItem.Text.Trim();
            list_Items.Items.Clear();
            foreach (var item in allItems)
                if (string.IsNullOrEmpty(search) || (item.Enabled && item.Text.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0))
                    list_Items.Items.Add(item);
        }
    }
}

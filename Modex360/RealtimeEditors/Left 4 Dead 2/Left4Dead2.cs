/// Realtime Editors made by Riggy \\\

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JRPC_Client;
using XDevkit;

namespace Modex360.RealtimeEditors.Left_4_Dead_2
{
    public partial class Left4Dead2 : RealtimeEditorControl
    {
        protected override uint? CommandBufferAddress => 0x86BCDDB0;
        protected override uint ExpectedVerificationValue => 0x7D8802A6;
        protected override string GameName => this.Text;
        protected override string RequiredTitleUpdate => "6";
        protected override void OnHook(IXboxConsole xbox, uint? commandBufferAddress)
        {
            SendCommand("sv_cheats 1");
        }

        protected override void EnableForm()
        {
            panelMain.Enabled = true;
            panelWeapons.Enabled = true;
            panelSpawns.Enabled = true;
            panelConsole.Enabled = true;
        }

        protected override void DisableForm()
        {
            panelMain.Enabled = false;
            panelWeapons.Enabled = false;
            panelSpawns.Enabled = false;
            panelConsole.Enabled = false;
        }

        Size size_Player = new Size(322, 222);
        Size size_Weapons = new Size(477, 407);
        Size size_Spawns = new Size(326, 246);
        Size size_Console = new Size(316, 127);

        public Left4Dead2()
        {
            InitializeComponent();
            TitleID = FormID.Left4Dead2;
        }

        private void rbRealtimeEditor_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            if (rbRealtimeEditor.SelectedRibbonTabItem == tabMain)
            {
                this.MaximumSize = size_Player;
                this.MinimumSize = size_Player;
                this.Size = size_Player;
                this.Refresh();
            }
            if (rbRealtimeEditor.SelectedRibbonTabItem == tabWeapons)
            {
                this.MaximumSize = size_Weapons;
                this.MinimumSize = size_Weapons;
                this.Size = size_Weapons;
                this.Refresh();
            }
            if (rbRealtimeEditor.SelectedRibbonTabItem == tabSpawns)
            {
                this.MaximumSize = size_Spawns;
                this.MinimumSize = size_Spawns;
                this.Size = size_Spawns;
                this.Refresh();
            }
            if (rbRealtimeEditor.SelectedRibbonTabItem == tabConsole)
            {
                this.MaximumSize = size_Console;
                this.MinimumSize = size_Console;
                this.Size = size_Console;
                this.Refresh();
            }
        }

        private void btn_GodMode_CheckedChanged(object sender, EventArgs e) => SendCommand(btn_GodMode.Checked ? "god 1" : "god 0", btn_GodMode.Checked ? "God Mode enabled" : "God Mode disabled");
        private void btn_InfAmmo_CheckedChanged(object sender, EventArgs e) => SendCommand(btn_InfAmmo.Checked ? "sv_infinite_ammo 1" : "sv_infinite_ammo 0", btn_InfAmmo.Checked ? "Infinite Ammo enabled" : "Infinite Ammo disabled");
        private void btn_noclip_CheckedChanged(object sender, EventArgs e) => SendCommand(btn_noclip.Checked ? "noclip 1" : "noclip 0", btn_noclip.Checked ? "No Clip enabled" : "No Clip disabled");
        private void btn_FirstPerson_Click(object sender, EventArgs e) => SendCommand("firstperson", "View set to First Person");
        private void btn_ThirdPerson_Click(object sender, EventArgs e) => SendCommand("thirdperson", "View set to Third Person");
        private void btn_ShoulderView_Click(object sender, EventArgs e) => SendCommand("thirdpersonshoulder", "View set to Shoulder");
        private void btn_WarpSpawn_Click(object sender, EventArgs e) => SendCommand("warp_to_start_area", "Teleported to Spawn");
        private void btn_WarpSaferoom_Click(object sender, EventArgs e) => SendCommand("warp_all_survivors_to_checkpoint", "Teleported to Saferoom");
        private void btn_WarpFinale_Click(object sender, EventArgs e) => SendCommand("warp_all_survivors_to_finale", "Teleported to Finale");
        private void sld_CrouchSpeed_MouseUp(object sender, MouseEventArgs e) => SendCommand("survivor_crouch_speed " + sld_CrouchSpeed.Value, "Crouch speed set to: " + sld_CrouchSpeed.Value);

        private void btn_givePShotgun_Click(object sender, EventArgs e) => SendCommand("give pumpshotgun", "Given Pump Shotgun");
        private void btn_giveCShotgun_Click(object sender, EventArgs e) => SendCommand("give shotgun_chrome", "Given Chrome Shotgun");
        private void btn_giveAShotgun_Click(object sender, EventArgs e) => SendCommand("give autoshotgun", "Given Auto Shotgun");
        private void btn_giveSPAS_Click(object sender, EventArgs e) => SendCommand("give shotgun_spas", "Given SPAS Shotgun");
        private void btn_giveSMG_Click(object sender, EventArgs e) => SendCommand("give smg", "Given SMG");
        private void btn_giveSSMG_Click(object sender, EventArgs e) => SendCommand("give smg_silenced", "Given Silenced SMG");
        private void btn_giveRifle_Click(object sender, EventArgs e) => SendCommand("give rifle", "Given Rifle");
        private void btn_giveCRifle_Click(object sender, EventArgs e) => SendCommand("give rifle_desert", "Given Combat Rifle");
        private void btn_giveAK47_Click(object sender, EventArgs e) => SendCommand("give rifle_ak47", "Given AK 47");
        private void btn_giveHRifle_Click(object sender, EventArgs e) => SendCommand("give hunting_rifle", "Given Hunting Rifle");
        private void btn_giveSniper_Click(object sender, EventArgs e) => SendCommand("give sniper_military", "Given Sniper Rifle");
        private void btn_giveGL_Click(object sender, EventArgs e) => SendCommand("give grenade_launcher", "Given Grenade Launcher");
        private void btn_giveChainsaw_Click(object sender, EventArgs e) => SendCommand("give chainsaw", "Given Chainsaw");
        private void btn_giveGuitar_Click(object sender, EventArgs e) => SendCommand("give electric_guitar", "Given Guitar");
        private void btn_givePan_Click(object sender, EventArgs e) => SendCommand("give frying_pan", "Given Frying Pan");
        private void btn_giveMagnum_Click(object sender, EventArgs e) => SendCommand("give pistol_magnum", "Given Magnum");
        private void btn_giveMachete_Click(object sender, EventArgs e) => SendCommand("give machete", "Given Machete");
        private void btn_giveKatana_Click(object sender, EventArgs e) => SendCommand("give katana", "Given Katana");
        private void btn_givePipeBomb_Click(object sender, EventArgs e) => SendCommand("give pipe_bomb", "Given Pipe Bomb");
        private void btn_giveMolotov_Click(object sender, EventArgs e) => SendCommand("give molotov", "Given Molotov");
        private void btn_giveBile_Click(object sender, EventArgs e) => SendCommand("give vomitjar", "Given vomitjar");
        private void btn_giveGas_Click(object sender, EventArgs e) => SendCommand("give gascan", "Given Gas Can");
        private void btn_givePropane_Click(object sender, EventArgs e) => SendCommand("give propanetank", "Given Propane Tank");
        private void btn_giveOxygen_Click(object sender, EventArgs e) => SendCommand("give oxygentank", "Given Oxygen Tank");
        private void btn_giveFAK_Click(object sender, EventArgs e) => SendCommand("give first_aid_kit", "Given First Aid Kit");
        private void btn_givePills_Click(object sender, EventArgs e) => SendCommand("give pain_pills", "Given Pain Pills");
        private void btn_giveAdrenaline_Click(object sender, EventArgs e) => SendCommand("give adrenaline", "Given Adrenaline");
        private void btn_giveDefib_Click(object sender, EventArgs e) => SendCommand("give defibrillator", "Given Defibrillator");
        private void btn_DropBomb_Click(object sender, EventArgs e) => SendCommand("boom", "Dropped Pipe Bomb");
        private void btn_DropFire_Click(object sender, EventArgs e) => SendCommand("fire", "Dropped Molotov");
        private void btn_giveLaserSight_Click(object sender, EventArgs e) => SendCommand("upgrade_add LASER_SIGHT", "Given Laser Sight");
        private void btn_giveIncendiaryRounds_Click(object sender, EventArgs e) => SendCommand("upgrade_add INCENDIARY_AMMO", "Given Incendiary Ammo");
        private void btn_giveExplosiveRounds_Click(object sender, EventArgs e) => SendCommand("upgrade_add explosive_ammo", "Given Explosive Ammo");

        private void btn_spwnSmoker_Click(object sender, EventArgs e) => SendCommand("z_spawn smoker", "Spawned Smoker");
        private void btn_spwnBoomer_Click(object sender, EventArgs e) => SendCommand("z_spawn boomer", "Spawned Boomer");
        private void btn_spwnHunter_Click(object sender, EventArgs e) => SendCommand("z_spawn hunter", "Spawned Hunter");
        private void btn_spwnHorde_Click(object sender, EventArgs e) => SendCommand("z_spawn mob", "Spawned Horde");
        private void btn_spwnWitch_Click(object sender, EventArgs e) => SendCommand("z_spawn witch", "Spawned Witch");
        private void btn_spwnTank_Click(object sender, EventArgs e) => SendCommand("z_spawn tank", "Spawned Tank");
        private void btn_spwnSpitter_Click(object sender, EventArgs e) => SendCommand("z_spawn spitter", "Spawned Spitter");
        private void btn_spwnJockey_Click(object sender, EventArgs e) => SendCommand("z_spawn jockey", "Spawned Jockey");
        private void btn_spwnCharger_Click(object sender, EventArgs e) => SendCommand("z_spawn Charger", "Spawned Charger");
        private void btn_dspwnEllis_Click(object sender, EventArgs e) => SendCommand("kick ellis", "Despawned Ellis");
        private void btn_dspwnCoach_Click(object sender, EventArgs e) => SendCommand("kick coach", "Despawned Coach");
        private void btn_dspwnRochelle_Click(object sender, EventArgs e) => SendCommand("kick rochelle", "Despawned Rochelle");
        private void btn_dspwnNick_Click(object sender, EventArgs e) => SendCommand("kick nick", "Despawned Nick");

        private void btn_send_Click(object sender, EventArgs e) => SendCommand(txt_cmd.Text, "Command executed: " + txt_cmd.Text);
    }
}

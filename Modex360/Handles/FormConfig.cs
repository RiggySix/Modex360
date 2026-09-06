using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Modex360.Properties;
using DevComponents.DotNetBar;
using Modex360.Server;
using Modex360.Functions;
using Modex360.PackageEditors;
using System.Xml.XPath;
using Modex360.Forms;
using Modex360.RealtimeEditors;

namespace Modex360
{
    internal static class FormConfig
    {
        // Add forms to the list. All modders and misc forms should be listed here.
        internal static List<FormMeta> formList = new List<FormMeta>();
        internal static void populateForms()
        {
            // Tools
            addForm(FormID.FATX, null, "Device Explorer", FormType.Tool, Resources.DeviceExplorer_Thumb);
            addForm(FormID.GamerPictureManager, typeof(PackageEditors.Gamer_Picture_Manager.GamerPictureManager), "Gamer Pic Pack Creator", FormType.Tool, Resources.GamerPictureManager_Thumb);
            addForm(FormID.PackageManager, typeof(PackageEditors.Package_Manager.PackageManager), "Package Manager", FormType.Tool, Resources.Manager_Thumb);
            addForm(FormID.ThemeCreator, typeof(PackageEditors.Theme_Creator.ThemeCreator), "Theme Creator", FormType.Tool, Resources.Theme_Thumb);

            // Profile Modders
            addForm(FormID.AccountEditor, typeof(PackageEditors.Account_Editor.AccountEditor), "Account Editor", FormType.Profile_Modder, Resources.Account_Thumb);
            addForm(FormID.AchievementUnlocker, typeof(PackageEditors.Achievement_Unlocker.AchievementUnlocker), "Achievement Unlocker", FormType.Profile_Modder, Resources.Unlocker_Thumb, false);
            addForm(FormID.AvatarAwardUnlocker, typeof(PackageEditors.Avatar_Award_Unlocker.AvatarAwardUnlocker), "Avatar Award Unlocker", FormType.Profile_Modder, Resources.AvatarAward_Thumb);
            addForm(FormID.AvatarColorEditor, typeof(PackageEditors.Avatar_Color_Editor.AvatarColorEditor), "Avatar Color Editor", FormType.Profile_Modder, Resources.AvatarEditor_Thumb);
            addForm(FormID.GameAdder, typeof(PackageEditors.Game_Adder.GameAdder), "Game Adder", FormType.Profile_Modder, Resources.Adder_Thumb);
            addForm(FormID.ProfileDataEditor, typeof(PackageEditors.Profile_Data_Editor.ProfileDataEditor), "Profile Data Editor", FormType.Profile_Modder, Resources.ProfileEditor_Thumb);
            addForm(FormID.BattleBlockTheater, typeof(PackageEditors.BattleBlock_Theater.BattleBlockTheater), "BattleBlock Theater", FormType.GPD_Modder, Resources.BattleBlock_Theater_Thumb);
            addForm(FormID.CastleCrashers, typeof(PackageEditors.Castle_Crashers.CastleCrashers), "Castle Crashers", FormType.GPD_Modder, Resources.CC_Thumb);
            addForm(FormID.Crysis2Profile, typeof(PackageEditors.Crysis_2.Crysis2Profile), "Crysis 2 Online", FormType.GPD_Modder, Resources.Crysis2_Thumb);
            addForm(FormID.GearsOfWar3ProfileData, typeof(PackageEditors.Gears_of_War_3.ProfileData), "Gears of War 3 Profile", FormType.GPD_Modder, Resources.GoW3_Profile_Thumb_New);
            addForm(FormID.GearsOfWarJudgmentProfileEditor, typeof(PackageEditors.Gears_of_War_Judgment.Profile.ProfileEditor), "GoW: Judgment Profile", FormType.GPD_Modder, Resources.GoWJ_Stats_Thumb_New);
            addForm(FormID.MarbleBlastUltra, typeof(PackageEditors.Marble_Blast_Ultra.MarbleBlastUltra), "Marble Blast Ultra", FormType.GPD_Modder, Resources.MarbleBlastUltra_Thumb);
            addForm(FormID.NPlus, typeof(PackageEditors.NPlus.NPlus), "N+", FormType.GPD_Modder, Resources.NPlus_Thumb);
            addForm(FormID.RedFactionGuerrilla, typeof(PackageEditors.Red_Faction_Guerrilla.RedFactionGuerrilla), "Red Faction: Guerrilla", FormType.GPD_Modder, Resources.RedFaction_Thumb);
            addForm(FormID.Swarm, typeof(PackageEditors.Swarm.Swarm), "Swarm", FormType.GPD_Modder, Resources.Swarm_Thumb);


            // Realtime Editors (by Riggy)
            addForm(FormID.Left4Dead, typeof(RealtimeEditors.Left_4_Dead.Left4Dead), "Left 4 Dead", FormType.Realtime_Editor, Resources.Left4Dead);
            addForm(FormID.Left4Dead2, typeof(RealtimeEditors.Left_4_Dead_2.Left4Dead2), "Left 4 Dead 2", FormType.Realtime_Editor, Resources.Left4Dead2);
            addForm(FormID.ResidentEvil, typeof(RealtimeEditors.Resident_Evil.ResidentEvil), "Resident Evil", FormType.Realtime_Editor, Resources.ResidentEvil);


            // Game Editors
            addForm(FormID.AlanWake, typeof(PackageEditors.Alan_Wake.AlanWake), "Alan Wake", FormType.Game_Modder, Resources.AlanWake_Thumb);
            addForm(FormID.AssassinsCreedII, typeof(PackageEditors.Assassins_Creed_II.AssassinsCreedII), "Assassin's Creed II", FormType.Game_Modder, Resources.AC2_Thumb);
            addForm(FormID.AssassinsCreedIII, typeof(PackageEditors.Assassin_s_Creed_III.ACIII), "Assassin's Creed III", FormType.Game_Modder, Resources.AC3_Thumb);
            addForm(FormID.AssassinsCreedRogue, typeof(PackageEditors.Assassin_s_Creed_Rogue.ACRogue), "Assassin's Creed Rogue", FormType.Game_Modder, Resources.ACRogue_Thumb);
            addForm(FormID.AssassinsCreedBrotherhood, typeof(PackageEditors.Assassin_s_Creed_Brotherhood.ACBrotherhood), "AC: Brotherhood", FormType.Game_Modder, Resources.ACBrotherhood_Thumb);
            addForm(FormID.ACRevelations, typeof(PackageEditors.Assassin_s_Creed_Revelations.ACRevelations), "AC: Revelations", FormType.Game_Modder, Resources.ACR_Thumb);
            addForm(FormID.AssassinsCreedIV, typeof(PackageEditors.Assassin_s_Creed_IV.ACIV), "AC IV: Black Flag", FormType.Game_Modder, Resources.AC4_Thumb);
            addForm(FormID.Bastion, typeof(PackageEditors.Bastion.Bastion), "Bastion", FormType.Game_Modder, Resources.Bastion_Thumb);
            addForm(FormID.Bayonetta, typeof(PackageEditors.Bayonetta.Bayonetta), "Bayonetta", FormType.Game_Modder, Resources.Bayonetta_Thumb);
            addForm(FormID.BionicCommando, typeof(PackageEditors.Bionic_Commando.BionicCommando), "Bionic Commando", FormType.Game_Modder, Resources.Bionic_Commando_Thumb);
            addForm(FormID.BioshockInfinite, typeof(PackageEditors.BioShock_Infinite.BioShockInfinite), "BioShock Infinite", FormType.Game_Modder, Resources.BioShock_Infinite_Thumb);
            addForm(FormID.Borderlands, typeof(PackageEditors.Borderlands.Borderlands), "Borderlands", FormType.Game_Modder, Resources.Borderlands_Thumb);
            addForm(FormID.Brink, typeof(PackageEditors.Brink.Brink), "Brink", FormType.Game_Modder, Resources.Brink_Thumb);
            addForm(FormID.BrutalLegend, typeof(PackageEditors.Brutal_Legend.BrutalLegend), "Brutal Legend", FormType.Game_Modder, Resources.BrutalLegend_Thumb);
            addForm(FormID.Bulletstorm, typeof(PackageEditors.Bulletstorm.Bulletstorm), "Bulletstorm", FormType.Game_Modder, Resources.Bulletstorm_Thumb);
            addForm(FormID.CallofDutyAdvancedWarfare, typeof(PackageEditors.Call_of_Duty_Advanced_Warfare.CoDAdvancedWarfare), "CoD: Advanced Warfare", FormType.Game_Modder, Resources.CoDAdvancedWarfare_Thumb);
            addForm(FormID.CallofDutyGhosts, typeof(PackageEditors.Call_of_Duty_Ghosts.CoDGhosts), "Call of Duty: Ghosts", FormType.Game_Modder, Resources.CoDGhostsThumb);
            addForm(FormID.Crackdown, typeof(PackageEditors.Crackdown.Crackdown), "Crackdown", FormType.Game_Modder, Resources.Crackdown_Thumb);
            addForm(FormID.Crackdown2, typeof(PackageEditors.Crackdown_2.Crackdown2), "Crackdown 2", FormType.Game_Modder, Resources.Crackdown2_Thumb);
            addForm(FormID.Crysis2Save, typeof(PackageEditors.Crysis_2.Crysis2Save), "Crysis 2", FormType.Game_Modder, Resources.Crysis2_Thumb);
            addForm(FormID.Crysis3SaveGame, typeof(PackageEditors.Crysis_3.Crysis3SaveGame), "Crysis 3", FormType.Game_Modder, Resources.Crysis3_Thumb);
            addForm(FormID.DeadRising2, typeof(PackageEditors.Dead_Rising_2.DeadRising2), "Dead Rising 2", FormType.Game_Modder, Resources.DeadRising2_Thumb);
            addForm(FormID.DeadSpace, typeof(PackageEditors.Dead_Space.DeadSpace), "Dead Space", FormType.Game_Modder, Resources.DS_Thumb);
            addForm(FormID.DeadSpace2, typeof(PackageEditors.Dead_Space_2.DeadSpace2), "Dead Space 2", FormType.Game_Modder, Resources.DS2_Thumb);
            addForm(FormID.DeadSpace3, typeof(PackageEditors.Dead_Space_3.DeadSpace3), "Dead Space 3", FormType.Game_Modder, Resources.DS3_Thumb);
            addForm(FormID.DMC3, typeof(PackageEditors.Devil_May_Cry_3.DMC3), "Devil May Cry 3", FormType.Game_Modder, Resources.DevilMayCry3_Thumb);
            addForm(FormID.DevilMayCry4, typeof(PackageEditors.Devil_May_Cry_4.DevilMayCry4), "Devil May Cry 4", FormType.Game_Modder, Resources.DevilMayCry4_Thumb);
            addForm(FormID.DevilMayCry, typeof(PackageEditors.Devil_May_Cry.DevilMayCry), "DmC: Devil May Cry", FormType.Game_Modder, Resources.DevilMayCry5_Thumb);
            addForm(FormID.Dirt2, typeof(PackageEditors.Dirt_2.Dirt2), "DiRT 2", FormType.Game_Modder, Resources.DiRT2_Thumb);
            addForm(FormID.Dirt3, typeof(PackageEditors.Dirt_3.Dirt3), "DiRT 3", FormType.Game_Modder, Resources.DiRT3_Thumb);
            addForm(FormID.DirtShowdown, typeof(PackageEditors.Dirt_Showdown.DirtShowdown), "DiRT Showdown", FormType.Game_Modder, Resources.DiRTShowdown_Thumb);
            addForm(FormID.DragonsDogma, typeof(PackageEditors.Dragons_Dogma.DragonsDogma), "Dragon's Dogma", FormType.Game_Modder, Resources.DragonsDogma_Thumb);
            addForm(FormID.DragonballXenoVerse, typeof(PackageEditors.Dragonball_XenoVerse.DragonballXenoVerse), "Dragon Ball XenoVerse", FormType.Game_Modder, Resources.DragonBallXenoVerse_Thumb);
            addForm(FormID.FEAR, typeof(PackageEditors.FEAR.FEAR), "F.E.A.R.", FormType.Game_Modder, Resources.FEAR_Thumb);
            addForm(FormID.FEAR2, typeof(PackageEditors.FEAR_2.FEAR2), "F.E.A.R. 2", FormType.Game_Modder, Resources.FEAR_2_Thumb);
            addForm(FormID.Fable2, typeof(PackageEditors.Fable_2.Fable2), "Fable 2", FormType.Game_Modder, Resources.Fable2_Thumb_New);
            addForm(FormID.FarCry3, typeof(PackageEditors.Far_Cry_3.FarCry3), "Far Cry 3", FormType.Game_Modder, Resources.FarCry3_Thumb);
            addForm(FormID.FarCry3BloodDragon, typeof(PackageEditors.Far_Cry_3_Blood_Dragon.FarCry3BloodDragon), "Far Cry 3: Blood Dragon", FormType.Game_Modder, Resources.FarCry3BloodDragon_Thumb);
            addForm(FormID.FarCry4, typeof(PackageEditors.Far_Cry_4.FarCry4), "Far Cry 4", FormType.Game_Modder, Resources.FarCry4_Thumb);
            addForm(FormID.FIFA11, typeof(PackageEditors.FIFA_11.FIFA11), "FIFA Soccer 11", FormType.Game_Modder, Resources.FIFA11_Thumb);
            addForm(FormID.FIFA12, typeof(PackageEditors.FIFA_12.FIFA12), "FIFA Soccer 12", FormType.Game_Modder, Resources.FIFA12_Thumb);
            addForm(FormID.FIFA13, typeof(PackageEditors.FIFA_13.FIFA13), "FIFA Soccer 13", FormType.Game_Modder, Resources.FIFA13_Thumb);
            addForm(FormID.FIFA14, typeof(PackageEditors.FIFA_14.FIFA14), "FIFA Soccer 14", FormType.Game_Modder, Resources.FIFA14_Thumb);
            addForm(FormID.FIFA15, typeof(PackageEditors.FIFA_15.FIFA15), "FIFA Soccer 15", FormType.Game_Modder, Resources.FIFA15_Thumb);
            addForm(FormID.Forza4Profile, typeof(PackageEditors.Forza_4.Forza4Profile), "Forza Motorsport 4", FormType.Game_Modder, Resources.Forza4_Thumb_New);
            addForm(FormID.Forza4Ss, typeof(PackageEditors.Forza_4.Forza4Ss), "Forza 4 Screenshot", FormType.Game_Modder, Resources.Forza4_SS_Thumb_New);
            addForm(FormID.Forza4Livery, typeof(PackageEditors.Forza_4.Forza4Livery), "Forza 4 Livery Unlocker", FormType.Game_Modder, Resources.Forza4_Livery_Thumb_New);
            addForm(FormID.ForzaHorizonProfile, typeof(PackageEditors.Forza_Horizon.ForzaHorizonProfile), "Forza Horizon", FormType.Game_Modder, Resources.ForzaHorizon_Thumb_New);
            addForm(FormID.ForzaHorizonLivery, typeof(PackageEditors.Forza_Horizon.ForzaHorizonLivery), "Forza Horizon Livery", FormType.Game_Modder, Resources.ForzaHorizon_Livery_Thumb_New);
            addForm(FormID.ForzaHorizonSS, typeof(PackageEditors.Forza_Horizon.ForzaHorizonSS), "Forza Horizon Screenshot", FormType.Game_Modder, Resources.ForzaHorizon_SS_Thumb_New);
            addForm(FormID.ForzaHorizon2Profile, typeof(PackageEditors.Forza_Horizon_2.ForzaHorizon2Profile), "Forza Horizon 2", FormType.Game_Modder, Resources.ForzaHorizon2_Thumb_New);
            addForm(FormID.GearsOfWar, typeof(PackageEditors.Gears_of_War.GearsOfWar), "Gears of War", FormType.Game_Modder, Resources.GoW_Thumb_New);
            addForm(FormID.GearsOfWar2, typeof(PackageEditors.Gears_of_War_2.GearsOfWar2), "Gears of War 2", FormType.Game_Modder, Resources.GoW2_Thumb_New);
            addForm(FormID.GearsOfWar3, typeof(PackageEditors.Gears_of_War_3.GearsOfWar3), "Gears of War 3", FormType.Game_Modder, Resources.GoW3_Thumb_New);
            addForm(FormID.GearsOfWar3PlayerData, typeof(PackageEditors.Gears_of_War_3.PlayerData), "Gears of War 3 Stats", FormType.Game_Modder, Resources.GoW3_Stats_Thumb_New);
            addForm(FormID.GearsOfWarJudgment, typeof(PackageEditors.Gears_of_War_Judgment.Campaign.GearsOfWarJudgment), "Gears of War: Judgment", FormType.Game_Modder, Resources.GoWJ_Thumb_New);
            addForm(FormID.GearsOfWarJudgmentStatsEditor, typeof(PackageEditors.Gears_of_War_Judgment.Stats.StatsEditor), "GoW: Judgment Stats", FormType.Game_Modder, Resources.GoWJ_Stats_Thumb_New);
            addForm(FormID.GrandTheftAutoIV, typeof(PackageEditors.Grand_Theft_Auto_IV.GrandTheftAutoIV), "Grand Theft Auto IV", FormType.Game_Modder, Resources.GTAIV_Thumb);
            addForm(FormID.GrandTheftAutoV, typeof(PackageEditors.Grand_Theft_Auto_V.GrandTheftAutoV), "Grand Theft Auto V", FormType.Game_Modder, Resources.GTAV_Thumb);
            addForm(FormID.InjusticeGodsAmongUs, typeof(PackageEditors.Injustice_Gods_Among_Us.InjusticeGAU), "Injustice: Gods Among Us", FormType.Game_Modder, Resources.InjusticeGAU_Thumb);
            addForm(FormID.JustCause2, typeof(PackageEditors.Just_Cause_2.JustCause2), "Just Cause 2", FormType.Game_Modder, Resources.Just_Cause_Thumb);
            addForm(FormID.Left4Dead2, typeof(PackageEditors.Left_4_Dead_2.Left4Dead2), "Left 4 Dead 2", FormType.Game_Modder, Resources.L4D2_Thumb);
            addForm(FormID.LIMBO, typeof(PackageEditors.LIMBO.LIMBO), "LIMBO", FormType.Game_Modder, Resources.LIMBO_Thumb);
            addForm(FormID.Metro2033, typeof(PackageEditors.Metro_2033.Metro2033), "Metro 2033", FormType.Game_Modder, Resources.Metro_2033_Thumb);
            addForm(FormID.MW3CampaignSave, typeof(PackageEditors.Modern_Warfare_3.MW3CampaignSave), "Modern Warfare 3", FormType.Game_Modder, Resources.MW3_Thumb);
            addForm(FormID.MotocrossMadness, typeof(PackageEditors.Motorcross_Madness.MotocrossMadness), "Motocross Madness", FormType.Game_Modder, Resources.MotocrossMadness_Thumb);
            addForm(FormID.MLB2K13, typeof(PackageEditors.MLB_2K13.MLB2K13), "MLB 2K13", FormType.Game_Modder, Resources.MLB_2k13_Thumb);
            addForm(FormID.NarutoUltimateNinjaStorm2, typeof(PackageEditors.Naruto_Ultimate_Ninja_Storm_2.NarutoUltimateNinjaStorm2), "Naruto Ninja Storm 2", FormType.Game_Modder, Resources.NarutoStorm2_Thumb);
            addForm(FormID.NarutoUNS3, typeof(PackageEditors.Naruto_Ultimate_Ninja_Storm_3.NarutoUNS3), "Naruto Ninja Storm 3", FormType.Game_Modder, Resources.NarutoStorm3_Thumb);
            addForm(FormID.NaughtyBear, typeof(PackageEditors.Naughty_Bear.NaughtyBear), "Naughty Bear", FormType.Game_Modder, Resources.NaughtyBear_Thumb);
            addForm(FormID.NBA2K13, typeof(PackageEditors.NBA_2K13.NBA2K13), "NBA 2K13", FormType.Game_Modder, Resources.NBA_2K13Thumb);
            addForm(FormID.NBA2K14, typeof(PackageEditors.NBA_2K14.NBA2K14), "NBA 2K14", FormType.Game_Modder, Resources.NBA_2K14Thumb);
            addForm(FormID.NBA2K15, typeof(PackageEditors.NBA_2K15.NBA2K15), "NBA 2K15", FormType.Game_Modder, Resources.NBA_2K15_Thumb);
            addForm(FormID.NeedForSpeedHP, typeof(PackageEditors.Need_for_Speed_HP.NeedForSpeedHP), "NFS: Hot Pursuit", FormType.Game_Modder, Resources.NeedForSpeedHP_Thumb);
            addForm(FormID.Oblivion, typeof(PackageEditors.Oblivion.Oblivion), "Oblivion", FormType.Game_Modder, Resources.Oblivion_Thumb);
            addForm(FormID.ProjectGothamRacing4, typeof(PackageEditors.Project_Gotham_Racing_4.PGR4), "PGR 4", FormType.Game_Modder, Resources.PGR4_Thumb);
            addForm(FormID.PlantsvsZombies, typeof(PackageEditors.Plants_vs_Zombies.PlantsvsZombies), "Plants vs. Zombies", FormType.Game_Modder, Resources.PlantsVsZombies_Thumb);
            addForm(FormID.QuakeArenaArcade, typeof(PackageEditors.Quake_Arena_Arcade.QuakeArenaArcade), "Quake Arena Arcade", FormType.Game_Modder, Resources.QuakeArenaArcade_Thumb);
            addForm(FormID.ResidentEvil5, typeof(PackageEditors.Resident_Evil_5.ResidentEvil5), "Resident Evil 5", FormType.Game_Modder, Resources.RE5_Thumb);
            addForm(FormID.ResidentEvil6, typeof(PackageEditors.Resident_Evil_6.ResidentEvil6), "Resident Evil 6", FormType.Game_Modder, Resources.RE6_Thumb);
            addForm(FormID.ResidetEvil_CVX, typeof(PackageEditors.Resident_Evil_Code_Veronica_X_HD.CodeVeronicaX), "RE Code: Veronica X HD", FormType.Game_Modder, Resources.CodeVeronicaX_Thumb);
            addForm(FormID.ResidentEvil_ORC, typeof(PackageEditors.Resident_Evil_ORC.ResidentEvil_ORC), "Resident Evil ORC", FormType.Game_Modder, Resources.REORC_Thumb);
            addForm(FormID.Saboteur, typeof(PackageEditors.The_Saboteur.Saboteur), "The Saboteur", FormType.Game_Modder, Resources.Saboteur_Thumb);
            addForm(FormID.SaintsRow3, typeof(PackageEditors.SaintsRow.SaintsRow3), "Saints Row: The Third", FormType.Game_Modder, Resources.SaintsRow3_Thumb);
            addForm(FormID.SaintsRow4, typeof(PackageEditors.Saint_s_Row_IV.SaintsRowIV), "Saints Row IV", FormType.Game_Modder, Resources.SaintsRow4_Thumb);
            addForm(FormID.SaintsRowGOOH, typeof(PackageEditors.Saint_s_Row_GOOH.SaintsRowGOOH), "Saints Row: GooH", FormType.Game_Modder, Resources.SaintsRowGOOH_Thumb);
            addForm(FormID.SleepingDogs, typeof(PackageEditors.Sleeping_Dogs.SleepingDogs), "Sleeping Dogs", FormType.Game_Modder, Resources.SleepingDogs_Thumb);
            addForm(FormID.SonicTheHedgehog, typeof(PackageEditors.Sonic_The_Hedgehog.SonicTheHedgehog), "Sonic The Hedgehog", FormType.Game_Modder, Resources.Sonic_Thumb);
            addForm(FormID.SSXTricky, typeof(PackageEditors.SSX_Tricky.SSXTricky), "SSX 2012", FormType.Game_Modder, Resources.SSXTricky_Thumb);
            addForm(FormID.StarWarsTFUII, typeof(PackageEditors.Star_Wars_TFU_II.StarWarsTFUII), "Star Wars: TFU II", FormType.Game_Modder, Resources.StarWarsTFUII_Thumb);
            addForm(FormID.StateofDecay, typeof(PackageEditors.State_of_Decay.StateofDecay), "State of Decay", FormType.Game_Modder, Resources.StateOfDecay_Thumb);
            addForm(FormID.SuperMeatBoy, typeof(PackageEditors.Super_Meat_Boy.SuperMeatBoy), "Super Meat Boy", FormType.Game_Modder, Resources.SMB_Thumb);
            addForm(FormID.TestDriveUnlimited, typeof(PackageEditors.Test_Drive_Unlimited.TestDriveUnlimited), "Test Drive Unlimited", FormType.Game_Modder, Resources.TestDrive_Thumb);
            addForm(FormID.TestDriveUnlimited2, typeof(PackageEditors.Test_Drive_Unlimited_2.TestDriveUnlimited2), "Test Drive Unlimited 2", FormType.Game_Modder, Resources.TestDrive2_Thumb);
            addForm(FormID.TigerWoodsPGATour14, typeof(PackageEditors.TW_PGA_Tour_14.TWPGATour14), "Tiger Woods PGA Tour 14", FormType.Game_Modder, Resources.TigerWoods14_Thumb);
            addForm(FormID.TombRaider, typeof(PackageEditors.Tomb_Raider.TombRaider), "Tomb Raider", FormType.Game_Modder, Resources.TombRaider_Thumb);
            addForm(FormID.WatchDogs, typeof(PackageEditors.Watch_Dogs.WatchDogs), "Watch Dogs", FormType.Game_Modder, Resources.WatchDogs_Thumb);
            addForm(FormID.WET, typeof(PackageEditors.WET.WET), "WET", FormType.Game_Modder, Resources.WET_Thumb);
            addForm(FormID.YuGiOh5Ds, typeof(PackageEditors.Yu_Gi_Oh_5Ds.YuGiOh5Ds), "Yu-Gi-Oh! 5D's", FormType.Game_Modder, Resources.YuGiOh_5DS_Thumb);
            addForm(FormID.YuGiOhMD, typeof(PackageEditors.Yu_Gi_Oh_MD.YuGiOhMD), "Yu-Gi-Oh! MD", FormType.Game_Modder, Resources.YuGiOh_MD_Thumb);
            
            // Misc
            addForm(FormID.About, null, "About", FormType.Misc, Resources.About_Thumb);
        }

        // This function is called when a form button is clicked.
        internal static void formOpenClick(object sender, EventArgs e)
        {
            var bMeta = (ButtonMeta)(sender.GetType() == typeof(ButtonItem) ? ((ButtonItem)sender).Tag : ((ButtonX)sender).Tag);
            if (bMeta.DeviceIndex != -1 && FormHandle.isFatxFileLoaded(bMeta.DeviceIndex, bMeta.FatxPath) != null)
                UI.errorBox("This file is currently open in another editor!");
            else if (FatxHandle.isDeviceWorkerAvailable(bMeta.DeviceIndex))
            {
                FormMeta fMeta = formList[bMeta.FormMetaIndex];
                loadForm(FormHandle.createNewFormConfig(bMeta.FormMetaIndex, bMeta.DeviceIndex, bMeta.FatxPath, bMeta.CachePartition));
            }
        }

        internal static void loadNewEditor(int x, EditorControl currentForm, string newFID)
        {
            byte newIndex = getFormMetaIndex(newFID);
            FormHandle.Forms[x].ActiveForm = currentForm;
            FormHandle.Forms[x].MetaIndex = newIndex;
            loadForm(x);
            
        }

        internal struct ButtonMeta
        {
            public byte FormMetaIndex;
            public int DeviceIndex;
            public string FatxPath;
            public bool CachePartition;
        }

        internal static Forms.About aboutBox;
        internal static void loadForm(int x)
        {
            if (Main.mainForm.WindowState == FormWindowState.Minimized)
                Main.mainForm.WindowState = FormWindowState.Normal;
            if (FormHandle.Forms[x].Meta.ID == FormID.FATX)
            {
                if (Main.mainForm.cmdDock.Checked)
                {
                    if (Main.mainForm.exFatx.Expanded)
                        for (byte i = 0; i < 3; i++)
                        {
                            System.Threading.Thread.Sleep(200);
                            Main.mainForm.cmdFatxDevicesLoaded.ColorTable = eButtonColor.Orange;
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(200);
                            Main.mainForm.cmdFatxDevicesLoaded.ColorTable = eButtonColor.BlueWithBackground;
                            Application.DoEvents();
                        }
                    else
                        Main.mainForm.exFatx.Expanded = true;
                }
                else
                    DeviceWindow.Open(Main.mainForm);

                return;
            }

            Main.mainForm.exFatx.Expanded = false;

            switch (FormHandle.Forms[x].Meta.ID)
            {
                case FormID.About:
                    if (aboutBox == null || !(bool)aboutBox.Tag)
                        (aboutBox = new About()).Show();
                    else
                        aboutBox.BringToFront();
                    break;
                default:
                    if (FormHandle.Forms[x].Meta.Type == FormType.Realtime_Editor)
                    {
                        FormHandle.tempRefGlass = !FormHandle.Forms[x].Meta.UseMDI;
                        var realtimeEditor = (RealtimeEditorControl)FormHandle.Forms[x].Meta.ClassType.GetConstructor(new Type[0]).Invoke(null);
                        realtimeEditor.initiateForm(x);
                    }
                    else
                    {
                        FormHandle.tempRefGlass = !FormHandle.Forms[x].Meta.UseMDI;
                        var editorControl = (EditorControl)FormHandle.Forms[x].Meta.ClassType.GetConstructor(new Type[0]).Invoke(null);
                        editorControl.initiateForm(x);
                    }
                    break;
            }
        }

        internal static void loadDiamondForm(XPathNavigator nav)
        {
            string data = nav.Value;
            nav.MoveToFirstAttribute();
            string hash = nav.Value;
            nav.MoveToNextAttribute();
            int x = int.Parse(nav.Value);
            nav.MoveToParent();
            if (FormSettings.validHash(FormHandle.Forms[x].Meta.ID, hash))
                loadForm(x);
            else
                if (FormSettings.formExists(FormHandle.Forms[x].Meta.ID))
                    FormSettings.removeForm(FormHandle.Forms[x].Meta.ID);
                    FormSettings.addForm(FormHandle.Forms[x].Meta.ID, hash);
                    string xml = Security.decryptFormXML(FormHandle.Forms[x].Meta.ID, hash, data);
            if (Security.validFormHash(FormHandle.Forms[x].Meta.ID, xml, hash))
            {
                Request.parseFormXML(FormHandle.Forms[x].Meta.ID, xml);
                loadForm(x);
            }
        }

        private static void addForm(string ID, Type formType, string FullName, FormType Type, Image Thumbnail)
        { addForm(ID, formType, FullName, Type, Thumbnail, true); }
        private static void addForm(string ID, Type formType, string FullName, FormType Type, Image Thumbnail, bool UseMDI)
        {
            formList.Add(new FormMeta
            {
                ID = ID,
                ClassType = formType,
                FullName = FullName,
                UseMDI = UseMDI,
                Type = Type,
                Thumbnail = Thumbnail
            });
        }

        internal static void populateTabs()
        {
            for (byte x = 0; x < formList.Count; x++)
            {
                ButtonMeta handle = new ButtonMeta();
                handle.FormMetaIndex = x;
                handle.DeviceIndex = -1;
                RibbonBar newRibbon = new RibbonBar();
                newRibbon.AutoOverflowEnabled = false;
                newRibbon.Dock = DockStyle.Left;
                newRibbon.MinimumSize = new Size(138, 0);
                newRibbon.Name = "rib" + formList[x].ID;
                newRibbon.Text = formList[x].FullName;
                newRibbon.Location = new Point(x, 0);
                ButtonItem newButton = new ButtonItem();
                newButton.Shape = new RoundRectangleShapeDescriptor();
                newButton.ColorTable = eButtonColor.OrangeWithBackground;
                newButton.Image = formList[x].Thumbnail;
                newButton.Name = "but" + formList[x].ID;
                newButton.Tag = handle;
                newButton.Click += new EventHandler(formOpenClick);
                newRibbon.Items.Add(newButton);
                switch (formList[x].Type)
                {
                    case FormType.Realtime_Editor:
                        Main.mainForm.panelRealtimeEditors.Controls.Add(newRibbon);
                        break;
                    case FormType.Game_Modder:
                        Main.mainForm.panelGameMods.Controls.Add(newRibbon);
                        break;
                    case FormType.GPD_Modder:
                    case FormType.Profile_Modder:
                        Main.mainForm.panelProfileMods.Controls.Add(newRibbon);
                        break;
                    case FormType.Tool:
                        Main.mainForm.panelTools.Controls.Add(newRibbon);
                        break;
                    case FormType.Misc:
                        Main.mainForm.panelMisc.Controls.Add(newRibbon);
                        break;
                }
            }
        }

        internal static byte getFormMetaIndex(string fid)
        {
            int x = formList.FindIndex(curForm => curForm.ID == fid);
            if (x == -1)
                return 255;
            return (byte)x;
        }

        // Different types of forms go in different tabs.
        internal enum FormType
        {
            Realtime_Editor,
            Game_Modder,
            GPD_Modder,
            Profile_Modder,
            Tool,
            Misc
        }

        // Data stored for each form in the project.
        internal struct FormMeta
        {
            public string ID;
            public Type ClassType;
            public string FullName;
            public bool UseMDI;
            public FormType Type;
            public Image Thumbnail;
        }
    }
}

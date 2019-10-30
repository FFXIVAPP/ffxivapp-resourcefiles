// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Game.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   Game.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.ResourceFiles {
    using System;
    using System.IO;
    using System.Reflection;
    using Avalonia.Media.Imaging;

    public static class Game {
        private static Assembly assembly = typeof(Game).GetTypeInfo().Assembly;
        private static Stream GetResource(string path) => assembly.GetManifestResourceStream(path);
        public static Bitmap Aetheryte = new Bitmap(GetResource($"{Constants.IconsPack}.aetheryte.png"));

        public static Bitmap Alchemist = new Bitmap(GetResource($"{Constants.IconsPack}.alc.png"));

        public static Bitmap Arcanist = new Bitmap(GetResource($"{Constants.IconsPack}.acn.png"));

        public static Bitmap Archer = new Bitmap(GetResource($"{Constants.IconsPack}.arc.png"));

        public static Bitmap Armorer = new Bitmap(GetResource($"{Constants.IconsPack}.arm.png"));

        public static Bitmap Astrologian = new Bitmap(GetResource($"{Constants.IconsPack}.ast.png"));

        public static Bitmap Avatar = new Bitmap(GetResource($"{Constants.IconsPack}.avatar.png"));

        public static Bitmap Bard = new Bitmap(GetResource($"{Constants.IconsPack}.brd.png"));

        public static Bitmap Blackmage = new Bitmap(GetResource($"{Constants.IconsPack}.blm.png"));

        public static Bitmap Blacksmith = new Bitmap(GetResource($"{Constants.IconsPack}.bsm.png"));

        public static Bitmap Botanist = new Bitmap(GetResource($"{Constants.IconsPack}.btn.png"));

        public static Bitmap Carpenter = new Bitmap(GetResource($"{Constants.IconsPack}.cpt.png"));

        public static Bitmap Chocobo = new Bitmap(GetResource($"{Constants.IconsPack}.chocobo.png"));

        public static Bitmap Conjurer = new Bitmap(GetResource($"{Constants.IconsPack}.cnj.png"));

        public static Bitmap Culinarian = new Bitmap(GetResource($"{Constants.IconsPack}.cul.png"));

        public static Bitmap DarkKnight = new Bitmap(GetResource($"{Constants.IconsPack}.drk.png"));

        public static Bitmap Dragoon = new Bitmap(GetResource($"{Constants.IconsPack}.drg.png"));

        public static Bitmap FateDefense = new Bitmap(GetResource($"{Constants.IconsPack}.fate_defense.png"));

        public static Bitmap FateEscort = new Bitmap(GetResource($"{Constants.IconsPack}.fate_escort.png"));

        public static Bitmap FateGather = new Bitmap(GetResource($"{Constants.IconsPack}.fate_gather.png"));

        public static Bitmap FateNM = new Bitmap(GetResource($"{Constants.IconsPack}.fate_nm.png"));

        public static Bitmap FateSlay = new Bitmap(GetResource($"{Constants.IconsPack}.fate_slay.png"));

        public static Bitmap Fisher = new Bitmap(GetResource($"{Constants.IconsPack}.fsh.png"));

        public static Bitmap Fishing = new Bitmap(GetResource($"{Constants.IconsPack}.fishing.png"));

        public static Bitmap Gathering = new Bitmap(GetResource($"{Constants.IconsPack}.gathering.png"));

        public static Bitmap Gladiator = new Bitmap(GetResource($"{Constants.IconsPack}.gld.png"));

        public static Bitmap Goldsmith = new Bitmap(GetResource($"{Constants.IconsPack}.gsm.png"));

        public static Bitmap Harvesting = new Bitmap(GetResource($"{Constants.IconsPack}.harvesting.png"));

        public static Bitmap HarvestingSuper = new Bitmap(GetResource($"{Constants.IconsPack}.harvesting_super.png"));

        public static Bitmap Lancer = new Bitmap(GetResource($"{Constants.IconsPack}.lnc.png"));

        public static Bitmap Leatherworker = new Bitmap(GetResource($"{Constants.IconsPack}.ltw.png"));

        public static Bitmap Logging = new Bitmap(GetResource($"{Constants.IconsPack}.logging.png"));

        public static Bitmap Machinist = new Bitmap(GetResource($"{Constants.IconsPack}.mch.png"));

        public static Bitmap Marauder = new Bitmap(GetResource($"{Constants.IconsPack}.mrd.png"));

        public static Bitmap Miner = new Bitmap(GetResource($"{Constants.IconsPack}.min.png"));

        public static Bitmap Mining = new Bitmap(GetResource($"{Constants.IconsPack}.mining.png"));

        public static Bitmap MiningSuper = new Bitmap(GetResource($"{Constants.IconsPack}.mining_super.png"));

        public static Bitmap MobAggressive1 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_aggressive_1.png"));

        public static Bitmap MobAggressive2 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_aggressive_2.png"));

        public static Bitmap MobAggressive3 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_aggressive_3.png"));

        public static Bitmap MobAggressive4 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_aggressive_4.png"));

        public static Bitmap MobAggressive5 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_aggressive_5.png"));

        public static Bitmap MobAggressive6 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_aggressive_6.png"));

        public static Bitmap MobClaimed = new Bitmap(GetResource($"{Constants.IconsPack}.mob_claimed.png"));

        public static Bitmap MobFate = new Bitmap(GetResource($"{Constants.IconsPack}.mob_fate.png"));

        public static Bitmap MobPassive1 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_passive_1.png"));

        public static Bitmap MobPassive2 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_passive_2.png"));

        public static Bitmap MobPassive3 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_passive_3.png"));

        public static Bitmap MobPassive4 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_passive_4.png"));

        public static Bitmap MobPassive5 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_passive_5.png"));

        public static Bitmap MobPassive6 = new Bitmap(GetResource($"{Constants.IconsPack}.mob_passive_6.png"));

        public static Bitmap MobUnclaimed = new Bitmap(GetResource($"{Constants.IconsPack}.mob_unclaimed.png"));

        public static Bitmap Monk = new Bitmap(GetResource($"{Constants.IconsPack}.mnk.png"));

        public static Bitmap Ninja = new Bitmap(GetResource($"{Constants.IconsPack}.nin.png"));

        public static Bitmap Paladin = new Bitmap(GetResource($"{Constants.IconsPack}.pld.png"));

        public static Bitmap Player = new Bitmap(GetResource($"{Constants.IconsPack}.player.png"));

        public static Bitmap Pugilist = new Bitmap(GetResource($"{Constants.IconsPack}.pug.png"));

        public static Bitmap Quarrying = new Bitmap(GetResource($"{Constants.IconsPack}.quarrying.png"));

        public static Bitmap RadarHeading = new Bitmap(GetResource($"{Constants.IconsPack}.radar_heading.png"));

        public static Bitmap RedMage = new Bitmap(GetResource($"{Constants.IconsPack}.rdm.png"));

        public static Bitmap Rogue = new Bitmap(GetResource($"{Constants.IconsPack}.rog.png"));

        public static Bitmap Samurai = new Bitmap(GetResource($"{Constants.IconsPack}.sam.png"));

        public static Bitmap Scholar = new Bitmap(GetResource($"{Constants.IconsPack}.sch.png"));

        public static Bitmap SpearFishing = new Bitmap(GetResource($"{Constants.IconsPack}.spearfishing.png"));

        public static Bitmap SpearFishingSuper = new Bitmap(GetResource($"{Constants.IconsPack}.spearfishing_super.png"));

        public static Bitmap Summoner = new Bitmap(GetResource($"{Constants.IconsPack}.smn.png"));

        public static Bitmap Thaumaturge = new Bitmap(GetResource($"{Constants.IconsPack}.thm.png"));

        public static Bitmap Unknown = new Bitmap(GetResource($"{Constants.IconsPack}.unknown.png"));

        public static Bitmap Vendor = new Bitmap(GetResource($"{Constants.IconsPack}.vendor.png"));

        public static Bitmap Warrior = new Bitmap(GetResource($"{Constants.IconsPack}.war.png"));

        public static Bitmap Weaver = new Bitmap(GetResource($"{Constants.IconsPack}.wvr.png"));

        public static Bitmap Whitemage = new Bitmap(GetResource($"{Constants.IconsPack}.whm.png"));

        public static Bitmap GetIconByName(string name) {
            try {
                return new Bitmap(GetResource($"{Constants.IconsPack}.{name.ToLowerInvariant()}.png"));
            }
            catch (Exception) {
                return Unknown;
            }
        }

        public static string GetIconPackURI(string name) {
            return $"{Constants.IconsPack}.{name.ToLowerInvariant()}.png";
        }
    }
}
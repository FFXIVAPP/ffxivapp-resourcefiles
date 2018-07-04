// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Theme.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   Theme.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.ResourceFiles {
    using System;
    using System.Windows.Media.Imaging;

    public static class Theme {
        public static BitmapImage ChineseFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/cn.png"));

        public static BitmapImage Default = new BitmapImage(new Uri($"{Constants.ThemePack}/default.png"));

        public static BitmapImage DefaultAvatar = new BitmapImage(new Uri($"{Constants.ThemePack}/default-avatar.jpg"));

        public static BitmapImage DefaultPluginLogo = new BitmapImage(new Uri($"{Constants.ThemePack}/default-plugin-logo.png"));

        public static BitmapImage EnglishFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/en.png"));

        public static BitmapImage FFXIVAPP = new BitmapImage(new Uri($"{Constants.ThemePack}/ffxivapp.png"));

        public static BitmapImage FFXIVAPPBase = new BitmapImage(new Uri($"{Constants.ThemePack}/ffxivapp-base.png"));

        public static BitmapImage FFXIVAPPIcon = new BitmapImage(new Uri($"{Constants.ThemePack}/ffxivapp.ico"));

        public static BitmapImage FFXIVAPPLogo = new BitmapImage(new Uri($"{Constants.ThemePack}/ffxivapp-logo.png"));

        public static BitmapImage FrenchFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/fr.png"));

        public static BitmapImage GermanFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/de.png"));

        public static BitmapImage JapaneseFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/ja.png"));

        public static BitmapImage KoreanFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/ko.png"));

        public static BitmapImage RussianFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/ru.png"));

        public static BitmapImage Splash = new BitmapImage(new Uri($"{Constants.ThemePack}/splash.png"));

        public static BitmapImage GetImageByName(string name) {
            try {
                return new BitmapImage(new Uri($"{Constants.IconsPack}/{name.ToLowerInvariant()}.png"));
            }
            catch (Exception) {
                return Default;
            }
        }

        public static string GetImagePackURI(string name) {
            return $"{Constants.ThemePack}/{name.ToLowerInvariant()}.png";
        }
    }
}
// FFXIVAPP.Resources ~ Theme.cs
// 
// Copyright © 2007 - 2017 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Windows.Media.Imaging;

namespace FFXIVAPP.Resources
{
    public static class Theme
    {
        public static BitmapImage ChineseFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/cn.png"));
        public static BitmapImage GermanFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/de.png"));
        public static BitmapImage EnglishFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/en.png"));
        public static BitmapImage FrenchFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/fr.png"));
        public static BitmapImage JapaneseFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/ja.png"));
        public static BitmapImage KoreanFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/ko.png"));
        public static BitmapImage RussianFlag = new BitmapImage(new Uri($"{Constants.ThemePack}/ru.png"));

        public static BitmapImage Default = new BitmapImage(new Uri($"{Constants.ThemePack}/default.png"));
        public static BitmapImage DefaultAvatar = new BitmapImage(new Uri($"{Constants.ThemePack}/default-avatar.jpg"));
        public static BitmapImage DefaultPluginLogo = new BitmapImage(new Uri($"{Constants.ThemePack}/default-plugin-logo.png"));

        public static BitmapImage FFXIVAPPIcon = new BitmapImage(new Uri($"{Constants.ThemePack}/ffxivapp.ico"));
        public static BitmapImage FFXIVAPPBase = new BitmapImage(new Uri($"{Constants.ThemePack}/ffxivapp-base.png"));
        public static BitmapImage FFXIVAPPLogo = new BitmapImage(new Uri($"{Constants.ThemePack}/ffxivapp-logo.png"));
        public static BitmapImage FFXIVAPP = new BitmapImage(new Uri($"{Constants.ThemePack}/ffxivapp.png"));
        public static BitmapImage Splash = new BitmapImage(new Uri($"{Constants.ThemePack}/splash.png"));

        public static BitmapImage GetImageByName(string name)
        {
            try
            {
                return new BitmapImage(new Uri($"{Constants.IconsPack}/{name.ToLowerInvariant()}.png"));
            }
            catch (Exception)
            {
                return Default;
            }
        }

        public static string GetImagePackURI(string name)
        {
            return $"{Constants.ThemePack}/{name.ToLowerInvariant()}.png";
        }
    }
}

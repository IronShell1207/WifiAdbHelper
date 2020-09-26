using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;

namespace WifiAdbHelper
{
    public class SettableVars
    {
        public static string AdbPath { get; set; }
        public static string ipAd { get; set; }
        public static MetroThemeStyle themeStyle { get; set; }
        public static MetroColorStyle colorStyle { get; set; }
        public static int ThemeId { get; set; }
        public static string DevicePathFile { get; set; }
        public static int DevicesUpdatingTiming { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;

namespace WifiAdbHelper
{
    static class consts
    {
        public static readonly string adbFilter = "adb.exe(*.exe)|*.exe| All files(*.*)|*.*";
        public static readonly string defFilter = "All files(*.*)|*.*";
        public static readonly string fileType = ".exe";
        public static readonly string settingFileName = "setting.ini";
        public static readonly Image imageRight = Properties.Resources.Arrow_right;
        public static readonly Image imageLeft = Properties.Resources.Arrow_left;
        public static readonly Size sizeStart = new Size(298, 383);
        public static readonly Size sizeMax = new Size(389, 383);
        public static readonly string[] comADB = new string[] { "start-server", "kill-server" , "connect " ,
            "disconnect ", "devices", "reboot","push ", "install ","reconnect "};
        public static readonly string[] mesADB = new string[] { "ADB server status", "ADB server status" , "Connected" ,
            "Disconnected", "Devices", "Reboot","Push","Installed","Reconnecting"};
        public static readonly string[] allStyles = new string[] { "Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow" };
        public static readonly string[] allThemes = new string[] { "Light", "Dark" };
        public static readonly Color[] listViewColors = new Color[] { Color.Gainsboro, Color.Black };
        public static readonly Color[] listViewColors2 = new Color[] { Color.Black, Color.Gainsboro };
        public static readonly string[] separator = { "\n", "\r" };
        public static string setFolderPath() {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\WifiadbHelper\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
            }

        public static readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static readonly string defaultPathVysor = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vysor\crx\gidgenkbbabolejbgbpnhbimgjbffefm\app-2.1.7.crx-unpacked\native\win32";

        public static string notifyIconTextM = "Wifi ADB Helper\nDouble click to show the window";
        public static string[] notificationMessagesHeader = new string[] {  };

        public static readonly string[] setThemeKeys = new string[] { "ThemeStyle", "ThemeColor" };
        public static readonly string[] allSettings = new string[] { "Settings","LastIP","AutoUpdate","DevicePath","TimerInterval","AutoConnect" };
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiAdbHelper
{
    class scrcpyMan
    {
        static string pPath = @"E:\Backups\Portable-Soft\scrcpy\scrcpy.exe";
        public static void startMonitor(string command)
        {
            var procs = Process.GetProcessesByName("scrcpy").Length > 0 ? Process.GetProcessesByName("scrcpy") : null;
            if (procs != null)
                foreach (Process proc in procs)
                    proc.Kill();
            Process.Start(pPath,command);
        }
        public static string[] Commands = new string[] { "--always-on-top", "-b {0}", "--disable-screensaver","--max-fps {0}",
        "--record {0}","--window-bordless", "--stay-awake"  };
        public static string[] ShortCutsSList = new string[] { "WIN+F - Switch fullscreen mode",
        "WIN+Left - Rotate display left",
        "WIN+Right - Rotate display right",
        "WIN+G - Resize window to 1:1 (pixel-perfect)",
        "WIN+W - Resize window to remove black borders",
        "WIN+H - Click on HOME",
        "WIN+Backspace - Click on BACK",
        "WIN+S - Click on APP_SWITCH",
        "WIN+M - Click on MENU",
        "WIN+Up - Click on VOLUME_UP",
        "WIN+Down - Click on VOLUME_DOWN",
        "WIN+P - Click on POWER (turn screen on/off)",
        "Right-click -  (when screen is off) Power on",
        "WIN+O - Turn device screen off (keep mirroring)",
        "WIN+Shift+O - Turn device screen on",
        "WIN+R - Rotate device screen",
        "WIN+N - Expand notification panel",
        "WIN+Shift+N - Collapse notification panel",
        "WIN+C - Copy to clipboard",
        "WIN+X - Cut to clipboard",
        "WIN+V - Copy computer clipboard to device, then paste",
        "WIN+Shift+V - Inject computer clipboard text as a sequence of key events",
        "WIN+i - Enable/disable FPS counter (print frames/second in logs)",
        "Ctrl+click-and-move - Pinch-to-zoom from the center of the screen",
        "Drag & drop APK file - Install APK from computer"};
        static void scrcpyPc(string argi)
        {
            var scrcpymain = new Process();
            scrcpymain.StartInfo.FileName = "scrcpy";
            scrcpymain.StartInfo.Arguments = argi;

            scrcpymain.StartInfo.RedirectStandardOutput = true;
            scrcpymain.StartInfo.UseShellExecute = false;
            scrcpymain.Start();
            StreamReader readerScr = scrcpymain.StandardOutput;
            String line;
            while ((line = readerScr.ReadLine()) != null)
                Console.WriteLine(line);


        }

    }
}

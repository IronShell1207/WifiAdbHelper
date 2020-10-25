using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inifiles;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.ComponentModel;

namespace WifiAdbHelper
{
    internal static class Extensions
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] uint dwFlags, [Out] StringBuilder lpExeName, [In, Out] ref uint lpdwSize);
        public static Form1 form1 = new Form1();
        public static String file_exe = consts.setFolderPath + "AdminRightsRestarter.exe";
        public static string GetMainModuleFileName(this Process process, int buffer = 1024)
        {
            var fileNameBuilder = new StringBuilder(buffer);
            uint bufferLength = (uint)fileNameBuilder.Capacity + 1;
            try
            {
                return QueryFullProcessImageName(process.Handle, 0, fileNameBuilder, ref bufferLength) ? fileNameBuilder.ToString() : null;
            }
            catch (Win32Exception ex)
            {
                try
                {
                    FileStream fs = new FileStream(file_exe, FileMode.Create);
                    fs.Write(Properties.Resources.AdminRightsRestarter, 0, Properties.Resources.AdminRightsRestarter.Length);
                    fs.Close();
                    Process.Start(consts.setFolderPath+"AdminRightsRestarter.exe", "WifiAdbHelper.exe");
                }
                catch (Exception exx) { }
                form1.messageBoxCaller("Close the adb.exe!\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
    public class mainVars
    {
        public static Form1 form = new Form1();
        public static IniFile ini = form.INI;
        public static string getVysorPath()
        {
            if (!Directory.Exists(consts.defaultPathVysor))
            {
                return @"C:\";
            }
            else return consts.defaultPathVysor;
        }
        public static string pathChecker(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }
        //public static void ThemeSetter()
        //{
        //    string iniThemeStyle, iniThemeColor;
        //    if (!ini.KeyExists(consts.setThemeKeys[0], consts.allSettings[0]) && !ini.KeyExists(consts.setThemeKeys[1], consts.allSettings[0]))
        //    {
        //        ini.Write(consts.allSettings[0], consts.setThemeKeys[0], form.Theme.ToString());
        //        ini.Write(consts.allSettings[0], consts.setThemeKeys[1], form.Style.ToString());
        //    }
        //    setVarsGlobal.colorStyle = form.Style; setVarsGlobal.themeStyle = form.Theme;
        //}
        public static void pathForADB()
        {
            DateTime dt = DateTime.Now;
            DialogResult dr = DialogResult.Yes;
            var adbFindProcess = Process.GetProcessesByName("adb");
            if (adbFindProcess.Length > 0)
            {
                SettableVars.AdbPath = adbFindProcess.First().GetMainModuleFileName();
                return;
            }
            else if (ini.KeyExists("path", "ADB"))
            {
                SettableVars.AdbPath = ini.ReadINI("ADB", "path");
                return;
            }
            else if (dr==form.messageBoxCaller("The path to adb.exe is not defined. Select now?","Can't define adb.exe",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                SettableVars.AdbPath = selectadbfile();
            }
            
        }
        public static void devicePath()
        {
            if (ini.KeyExists(consts.allSettings[3], consts.allSettings[0]))
                SettableVars.DevicePathFile = ini.ReadINI(consts.allSettings[0], @consts.allSettings[3]);
            else SettableVars.DevicePathFile = @"sdcard/";
        }
        //public static string adbpath()
        //{
        //    var adbProc = Process.GetProcessesByName("adb");
        //    string adbfilepathStarted;
        //    try
        //    {
        //        adbfilepathStarted = adbProc.First().GetMainModuleFileName();
        //        if (adbfilepathStarted != null)
        //            return adbfilepathStarted;
        //    }
        //    catch (InvalidOperationException d)
        //    {
        //        DateTime dt = DateTime.Now;

        //        File.AppendAllText(pathChecker(consts.setFolderPath) + "log.txt",dt.ToString()+" | "+ d.Message  + "\n");
        //        if (ini.KeyExists("path", "ADB"))
        //        {
        //            return ini.ReadINI("ADB", "path");
        //        }
        //        else return selectadbfile();
        //    }
        //    return selectadbfile();

        //}
        public static string selectadbfile()
        {
            string fileN = form.returnFromOpenFileD();
            if (fileN != null && fileN.Contains(consts.fileType))
            {
                ini.Write("ADB", "path", fileN);
                form.messageBoxCaller(fileN, "New patch selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // MetroFramework.MetroMessageBox.Show(new Form { TopMost = true, StartPosition=FormStartPosition.CenterScreen }, fileN,  "New patch selected",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return fileN;
            }
            else
            {
                form.messageBoxCaller("Need to select adb.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MetroFramework.MetroMessageBox.Show(new Form { }, "Need to select adb.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static void ipAddress()
        {

            if (SettableVars.ipAd == null)
                if (ini.KeyExists("lastIP", "Ip"))
                    SettableVars.ipAd = ini.ReadINI("Ip", "lastIP");
                else SettableVars.ipAd = "192.168.1.0";
        }
        

        public static string statusADBlaunched()
        {

            string _cks = System.Diagnostics.Process.GetProcessesByName("adb").Any() ? "started" : "closed";
            switch (_cks)
            {
                case ("started"):
                    form.buttonStart.Enabled = false;
                    form.buttonKill.Enabled = true;
                    return "adb: started";
                case ("closed"):
                    form.buttonStart.Enabled = true;
                    form.buttonKill.Enabled = false;
                    return "adb: closed";
                default:
                    form.buttonStart.Enabled = true;
                    form.buttonKill.Enabled = false;
                    return "adb: closed";
            }
        }

    }
}

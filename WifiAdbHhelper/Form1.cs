using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using inifiles;
using MetroFramework;

namespace WifiAdbHelper
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public EzShell.CheckUpdates checkUpd;
        public EzShell.SwMsgDwnldUpt swMsgDwnld;
        public settingForm settingForm;
        bool isLast = true;
        public string link = "";
        Form1 _form1;
        public NotifyIcon notificationM = new NotifyIcon()
        {
            Icon = Properties.Resources.icons,
            BalloonTipIcon = ToolTipIcon.Info,
            Text = consts.notifyIconTextM
        }; public IniFile INI = new IniFile(consts.setFolderPath() + consts.settingFileName);
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = mSM1;
            swMsgDwnld = messageBoxCaller;
            link = EzShell.CheckUpdates.LinkGenerator();
            _form1 = this;
            //mSM1.Theme = getThemeFromINI();
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            SettableVars.ipAd = textboxIP.Text;
            INI.Write(consts.allSettings[0], consts.allSettings[1], SettableVars.ipAd);
            AdbOperationCreator(consts.comADB[2] + SettableVars.ipAd, consts.mesADB[2]);
        }
        private void buttonKillServer_Click(object sender, EventArgs e)
        {
            timerAutoUpdateList.Stop();
            AdbOperationCreator(consts.comADB[1], consts.mesADB[1] + "s");
            //notifyBGW("kill-adb");
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            var r = new Thread(() =>
            {
                vysorStart();
            });
            r.IsBackground = true;
            r.Start();
        }
        void vysorStart()
        {
            try
            {
                if (Process.GetProcessesByName("Vysor").Length < 1)
                    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Vysor\Vysor.exe");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }
        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            AdbOperationCreator(consts.comADB[0], consts.mesADB[0]);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelADBstatus.Text = mainVars.statusADBlaunched();
            labeladbpop.Text = SettableVars.AdbPath;
            if (labelADBstatus.Text == "adb: started") { buttonStart.Enabled = false; buttonKill.Enabled = true; }
            else
            {
                buttonStart.Enabled = true; buttonKill.Enabled = false;
            }

        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            deviceOperation(consts.comADB[3], consts.mesADB[3]);
        }
        public string returnFromOpenFileD()
        {
            oFD1.Filter = consts.adbFilter;
            oFD1.InitialDirectory = mainVars.getVysorPath();
            if (oFD1.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            else
            {
                FileInfo fileInfo = new FileInfo(oFD1.FileName);
                return fileInfo.FullName;
            }
        }
        public int getThemeFromIniId(string switcherMetro, string[] list)
        {
            if (INI.KeyExists(switcherMetro, consts.allSettings[0]))
            {
                string themeIndex = INI.ReadINI(consts.allSettings[0], switcherMetro);
                int index = 1;
                for (int i = 0; i < list.Length; i++)
                    if (list[i] == themeIndex)
                    {
                        index = i + 1;
                        break;
                    }
                return index;
            }
            else return 2;
        }
        void updateSChecker()
        {
            Thread.Sleep(2000);
            EzShell.SwMsgDwnldUpt swMsa = messageBoxCaller;
            // EzUpdater.CheckUpdates.updateschecker(Application.ProductVersion.ToString(), "WifiAdbHelper", metroProgressBar1, @"https://www.fordroid.3dn.ru/WifiAdbHelper.zip", swMsa);
        }
        /*public string LinkGenerator()
        {
            string linkmaincheck = @"https://fordroid.3dn.ru/pictures/domaincheck.txt";
            string finaldomain = @"https://droidapps.cf";
            string filename = "linkdomain.txt";
            // Объект запроса
            HttpWebRequest rew = (HttpWebRequest)WebRequest.Create(linkmaincheck);

            // Отправить запрос и получить ответ
            HttpWebResponse resp = (HttpWebResponse)rew.GetResponse();

            // Получить поток
            Stream str = resp.GetResponseStream();

            // Выводим в TextBox
            int ch;
            string message = "";
            for (int i = 1; ; i++)
            {
                ch = str.ReadByte();
                if (ch == -1) break;
                message += (char)ch;
            }

            // Закрыть поток
            str.Close();
            messageBoxCaller(message, "c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return finaldomain;
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {

            checkUpd = new EzShell.CheckUpdates(Application.ProductName, Application.ProductVersion, link + @"/Files/WifiAdbHelper.zip", swMsgDwnld, metroProgressBar1, notificationM, labelADBstatus);
            mainVars.ipAddress();
            textboxIP.Text = SettableVars.ipAd;
            this.Size = consts.sizeStart;
            AutoUpdateMet();
            Refresher();
            ThemeFirst();
            NotifyIconPlace();
            mainVars.devicePath();
            SetTimerInterval();
            AutoreconAtStart();

        }
        void NotifyIconPlace() //иконка в трее запуск проверки обновлений и добавление событий
        {
            notificationM.ContextMenuStrip = contextMenuICon;
            notificationM.DoubleClick += NotificationM_DoubleClick;
            notificationM.Visible = true;
            var r = new Thread(() =>
            {
                string Ver = checkUpd.MsgUpdateAvailable();
                if (Ver != null)
                {
                    if (InvokeRequired) buttontest.Invoke(new Action(() => buttontest.Visible = true));
                    else buttontest.Visible = true;
                    notificationM.ShowBalloonTip(3000, "Update available " + Ver, "Click on this notification to see more", ToolTipIcon.Info);
                    notificationM.BalloonTipClicked += NotificationM_BalloonTipClicked;
                    isLast = false;
                }
            });
            r.IsBackground = true;
            r.Start();
        }
        private void NotificationM_BalloonTipClicked(object sender, EventArgs e)
        {
            checkUpd.UpdaterProg(swMsgDwnld);
            //notificationM.BalloonTipClicked += null;
        }
        public void ThemeFirst()
        {
            int themeIndex = getThemeFromIniId(consts.setThemeKeys[0], consts.allThemes);
            SettableVars.colorStyle = mSM1.Style = (MetroColorStyle)getThemeFromIniId(consts.setThemeKeys[1], consts.allStyles);
            SettableVars.themeStyle = mSM1.Theme = (MetroThemeStyle)themeIndex;
            listView1.BackColor = consts.listViewColors[themeIndex - 1];
            listView1.ForeColor = consts.listViewColors2[themeIndex - 1];
        }
        public void ThemeUpdater(int id)
        {
            mSM1.Style = SettableVars.colorStyle;
            mSM1.Theme = SettableVars.themeStyle;
            listView1.BackColor = consts.listViewColors[id];
            listView1.ForeColor = consts.listViewColors2[id];
        }
        private void NotificationM_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                //notifyIcon1.Visible = false;
            }
        }
        public void AdbOperationCreator(string operation, string mes)
        {
            mainVars.pathForADB();
            if (SettableVars.AdbPath != null)
            {
                var t = new Thread(() => CmdExecutor(operation, mes));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else messageBoxCaller("Need to select adb file to use this function", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuICon.Show(Control.MousePosition);
        }
        private void развернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notificationM.Visible = false;
            Application.Exit();
        }
        public void CmdExecutor(string commandMessage, string headMes)
        {
            ElementEnControl(false);
            ProcessStartInfo lcmdInfo1;
            lcmdInfo1 = new ProcessStartInfo(SettableVars.AdbPath, commandMessage)
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };
            Process cmd2 = new Process
            {
                StartInfo = lcmdInfo1
            };
            var output = new StringBuilder();
            var error = new StringBuilder();
            cmd2.OutputDataReceived += (o, ef) => output.Append(ef.Data + "\n");
            cmd2.ErrorDataReceived += (o, ef) => error.Append(ef.Data + "\n");
            cmd2.Start();
            cmd2.BeginOutputReadLine();
            cmd2.BeginErrorReadLine();
            cmd2.WaitForExit();
            cmd2.Close();
            string resultWError = error.ToString();
            string resultN = output.ToString();
            if (resultN.Replace("\n", "").Trim().Length == 0)
                messageMaker(headMes, resultWError + resultN);
            else
                messageMaker(headMes, resultN + resultWError);
            ElementEnControl(true);
            cmd2.Dispose();
        }
        public void messageMaker(string Head, string nResult)
        {
            switch (Head)
            {
                case ("Devices"):
                    refreshListDevices(nResult);
                    break;
                case ("Push"):
                    List<string> lines = new List<string>(nResult.Split(consts.separator, StringSplitOptions.RemoveEmptyEntries));
                    msg("Success", lines.Last());
                    break;
                case ("ADB server statuss"):
                    msg(consts.mesADB[0], "Server closed");
                    // msg("ADB stopped", "Server Killed");
                    listView1.Invoke(new Action(() => { listView1.Items.Clear(); }));
                    break;
                default:
                    msg(Head, nResult);
                    CmdExecutor(consts.comADB[4], "Devices");
                    break;
            }
        }
        public DialogResult messageBoxCaller(string message, string topMes, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            var dr = MetroMessageBox.Show(_form1, message, topMes, buttons, icon, 265);
            return dr;
        }
        public void AutoUpdateMet()
        {
            if (INI.KeyExists(consts.allSettings[2], consts.allSettings[0]))
            {
                bool checkin = Convert.ToBoolean(INI.ReadINI(consts.allSettings[0], consts.allSettings[2]));
                chcBoxUpdate.Checked = checkin;
                timerAutoUpdateList.Enabled = checkin;
            }
        }
        public void deviceOperation(string operation, string mesOper)
        {
            SettableVars.ipAd = textboxIP.Text;
            if (listView1.SelectedItems.Count != 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string wtf = item.SubItems[0].Text.Replace("unauthorized", "").Replace("offline", "");
                SettableVars.ipAd = wtf;
            }
            else
                INI.Write("Ip", "lastIP", SettableVars.ipAd);
            if (operation == consts.comADB[5])
                AdbOperationCreator(operation, mesOper);
            else
                AdbOperationCreator(operation + SettableVars.ipAd, mesOper);
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Refresher();
        }
        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConnect_Click(sender, e);
            }
        }
        public void msg(string title, string mesage)
        {
            if (mesage != "")
                notificationM.ShowBalloonTip(100, title, mesage, ToolTipIcon.Info);
        }
        private void buttonpush_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 1)
                MetroMessageBox.Show(this, "Need to be only ONE device connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                pushfilepatch("");
        }
        public void ElementEnControl(bool states)//, params Control[] controls)
        {
            List<Control> allEras;
            allEras = new List<Control> { buttonConnect, buttonDevices, buttonDisconnect, buttonKill, buttonPushFile, buttonStart, buttonVysor, textboxIP, buttonSetting, buttonRecon };
            foreach (Control control in allEras)
                control.Invoke(new Action(() => { control.Enabled = states; }));

            metroProgressBar1.Invoke(new Action(() => { metroProgressBar1.Visible = !states; }));
        }
        private void pushfilepatch(string path)
        {
            if (path == "")
            {
                oFD1.Filter = consts.defFilter;
                oFD1.InitialDirectory = consts.desktopPath;
                if (oFD1.ShowDialog() == DialogResult.Cancel)
                    return;
                FileInfo fileInfo = new FileInfo(oFD1.FileName);
                path = fileInfo.FullName;
            }
            //if (path.Contains(".apk"))
            //    AdbOperationCreator(consts.comADB[7]+ " [-lrtsdg] " + path, consts.mesADB[7]); //+ " " + SettableVars.DevicePathFile);
            else
                AdbOperationCreator(consts.comADB[6] + path + " " + SettableVars.DevicePathFile, consts.mesADB[6]);
        }
        public void refreshListDevices(string messageR)
        {
            listView1.Invoke(new Action(() => { listView1.Items.Clear(); }));
            string[] devices = messageR.Replace("List of devices attached\n", "").Replace("device", "").Replace("\t", " ").Split(consts.separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string dev in devices)
                listView1.Invoke(new Action(() => { listView1.Items.Add(dev); }));
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

            if (listView1.Items.Count > 1)
                MetroMessageBox.Show(this, "Need to be only ONE device connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                    pushfilepatch(file);
                //MetroMessageBox.Show(this, files.Length + " file(s) transfered to the device.\n" + transferedL, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\WifiadbHelper\log.txt", files);
                //Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\WifiadbHelper\log.txt");
            }
        }
        //void notifyBGW(string info)
        //{
        //   // notifyIcon1.Visible = true;
        //    switch (info)
        //    {
        //        case "startingADB":
        //            msg("Started", "ADB server started");
        //            break;
        //        case "kill-adb":
        //            msg("Stopped", "ADB stopped");
        //            break;
        //    }

        //}
        void Refresher()
        {
            if (mainVars.statusADBlaunched() != "adb: closed" && mainVars.statusADBlaunched() != "adb: ?")
                AdbOperationCreator(consts.comADB[4], consts.mesADB[4]);
            if (listView1.Items.Count > 1 || listView1.Items.Count == 0)
                buttonReboot.Enabled = false;
            else
                buttonReboot.Enabled = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Refresher();
        }
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBoxUpdate.Checked == true)
            {
                INI.Write(consts.allSettings[0], consts.allSettings[2], "true");
                timerAutoUpdateList.Enabled = true;
            }
            else if (chcBoxUpdate.Checked == false)
            {
                INI.Write(consts.allSettings[0], consts.allSettings[2], "false");
                timerAutoUpdateList.Enabled = false;
            }
        }
        private void buttonReboot_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "You realy want to reboot this device?", "Rebooting the device", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                deviceOperation(consts.comADB[5], consts.mesADB[5]);
        }
        private void copyADBPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SettableVars.AdbPath);
            Clipboard.SetText(SettableVars.AdbPath);
        }
        private void textboxIP_TextChanged(object sender, EventArgs e)
        {
            SettableVars.ipAd = textboxIP.Text;
        }
        private void buttonADB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMADB.Show(Cursor.Position);

            }
        }
        private void buttonVysor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        private void killVysorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] proc = Process.GetProcessesByName("vysor");
            foreach (var pc in proc)
                pc.Kill();
        }
        private void startCMDADBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.WorkingDirectory = SettableVars.AdbPath.Replace("adb.exe", "");
            p.StartInfo.FileName = "cmd.exe";
            p.Start();
        }
        public void SetTimerInterval()
        {
            SettableVars.DevicesUpdatingTiming = 10000;
            if (INI.KeyExists(consts.allSettings[4], consts.allSettings[0]))
                SettableVars.DevicesUpdatingTiming = Convert.ToInt32(INI.ReadINI(consts.allSettings[0], consts.allSettings[4]));
            timerAutoUpdateList.Interval = SettableVars.DevicesUpdatingTiming;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notificationM.Dispose();
            timer1.Stop();
            timerAutoUpdateList.Stop(); timerStatusAndButtons.Stop();
        }
        private void buttontest_Click(object sender, EventArgs e)
        {
            checkUpd.UpdaterProg(swMsgDwnld);
        }
        private void AutoreconAtStart()
        {
            if (INI.KeyExists(consts.allSettings[5], consts.allSettings[0]))
            {
                bool autorecoStat = bool.Parse(INI.ReadINI(consts.allSettings[0], consts.allSettings[5]));
                if (autorecoStat)
                {
                    vysorStart();
                    AdbOperationCreator(consts.comADB[2] + textboxIP.Text, consts.mesADB[2]);

                }
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (labeladbpop.Left > -labeladbpop.Width)
            {
                labeladbpop.Left -= 1;
            }
            else
            {
                labeladbpop.Left = metroPanel1.Width;
            }
        }
        private void labeladbpop_TextChanged(object sender, EventArgs e)
        {
            if (labeladbpop.Text.Length > 38)
                timer1.Start();
            else
            {
                timer1.Stop();
                labeladbpop.Location = new Point(0, 0);
            }
        }
        private void labeladbpop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled == true) timer1.Enabled = false;
            else if (timer1.Enabled == false) timer1.Enabled = true;
        }
        private void SettingButton_Click(object sender, EventArgs e)
        {
            settingForm settingFormm = new settingForm(isLast);
            if (settingFormm.ShowDialog() == DialogResult.OK)
            {
                SetTimerInterval();
                ThemeUpdater(SettableVars.ThemeId);
            }
            //mainVars.settingForm.ShowDialog();

        }
        private void timerStatusAndButtons_Tick(object sender, EventArgs e)
        {
            string status = mainVars.statusADBlaunched();
            if (metroProgressBar1.Visible == true)
            {
                labelADBstatus.Text = "adb: processing";
                buttonStart.Enabled = false;
                buttonKill.Enabled = false;
                return;
            }
            labelADBstatus.Text = status;
            if (status == "adb: started")
            {
                buttonStart.Enabled = false;
                buttonKill.Enabled = true;
            }
            if (status == "adb: closed")
            {
                buttonStart.Enabled = true;
                buttonKill.Enabled = false;
            }

            labeladbpop.Text = SettableVars.AdbPath;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.Size == consts.sizeStart)
            {
                this.Size = consts.sizeMax;
                pBoxArrow.Image = Properties.Resources.Arrow_left;
            }
            else if (this.Size == consts.sizeMax)
            {
                this.Size = consts.sizeStart;
                pBoxArrow.Image = Properties.Resources.Arrow_right;
            }
            //if ()
            //{
            //    this.Size = new Size(389, 383);
            //}
            //if (pBoxArrow.Image == Properties.Resources.Arrow_left)
            //{
            //    this.Size = new Size(298, 383);
            //}

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AdbOperationCreator(consts.comADB[8], consts.mesADB[8]);
            //deviceOperation(consts.comADB[8], consts.mesADB[8]);
        }

        private void textboxIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textboxIP_Leave(object sender, EventArgs e)
        {
            INI.Write("Ip", "lastIP", textboxIP.Text); ;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            checkUpd.UpdaterProg(swMsgDwnld);//Application.ProductName, Application.ProductVersion, @"https://www.fordroid.3dn.ru/WifiAdbHelper.zip", showMsg, metroProgressBar1);
        }

        private void contextMenuICon_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.movetray1;
            ToolTip toolTip = new ToolTip()
            {
                UseAnimation = true
            };
            toolTip.SetToolTip(pictureBox1, "Hide to tray");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.movetray0;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            notificationM.ShowBalloonTip(2, "Minimized to the tray", "The Wifi ADB helper hidded to the tray", ToolTipIcon.Info);
        }

        private void contextMADB_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

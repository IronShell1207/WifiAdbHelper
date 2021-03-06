﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EzShell;
using MetroFramework;
using MetroFramework.Components;

namespace WifiAdbHelper
{
    public partial class settingForm : MetroFramework.Forms.MetroForm
    {
        bool isLast1 = false;
        MetroStyleManager mSM1;
        ListView lb1;
        public settingForm(bool isLast, ref MetroStyleManager mSM2, ref ListView lb)
        {
            InitializeComponent();
            isLast1 = isLast;
            mSM1 = mSM2;
            lb1 = lb;
        }
        Form1 form1 = new Form1();
       
        private void settingForm_Load(object sender, EventArgs e)
        {
            this.StyleManager = mSM1;
            mSM1.Owner = this;
            //mainVars.pathForADB();
            labelVersion.Text = isLast1 ? "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " (latest)"  : "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            textBoxADBPath.Text = SettableVars.AdbPath;
          //  metroStyleManager1.Theme = SettableVars.themeStyle;
           // metroStyleManager1.Style = SettableVars.colorStyle;
            comboBoxColor.Items.AddRange(consts.allStyles);
            comboBoxTheme.Items.AddRange(consts.allThemes);
            comboBoxColor.SelectedIndex = getColorFromIniId()-1;
            comboBoxTheme.SelectedIndex = getThemeFromIniId()-1;
            numericUpDown1.BackColor = consts.listViewColors[getThemeFromIniId() - 1];
            numericUpDown1.ForeColor = consts.listViewColors2[getThemeFromIniId() - 1];
            numericUpDown1.Value = SettableVars.DevicesUpdatingTiming/1000;
            textBoxDevicePath.Text = SettableVars.DevicePathFile;
            if (form1.INI.KeyExists(consts.allSettings[5], consts.allSettings[0]))
                metroToggle1.Checked = bool.Parse(form1.INI.ReadINI(consts.allSettings[0], consts.allSettings[5]));
            //form1.getThemeFromINI();
        }
        int getThemeFromIniId()
        {
            if (form1.INI.KeyExists(consts.setThemeKeys[0], consts.allSettings[0]))
            {
                string themeIndex = form1.INI.ReadINI(consts.allSettings[0], consts.setThemeKeys[0]);
                int index = 1;
                for (int i = 0; i < consts.allThemes.Length; i++)
                    if (consts.allThemes[i] == themeIndex)
                    {
                        index = i + 1;
                        break;
                    }
                return index;
            }
            else return 2;
        }
        int getColorFromIniId()
        {
            if (form1.INI.KeyExists(consts.setThemeKeys[1], consts.allSettings[0]))
            {
                string colorIndex = form1.INI.ReadINI(consts.allSettings[0], consts.setThemeKeys[1]);
                int index = 1;
                for (int i = 0; i < consts.allStyles.Length; i++)
                    if (consts.allStyles[i] == colorIndex)
                    {
                        index = i + 1;
                        break;
                    }
                return index;
            }
            else return 2;
        }
        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSM1.Theme = (MetroThemeStyle)comboBoxTheme.SelectedIndex+1;
            SettableVars.themeStyle= (MetroThemeStyle)comboBoxTheme.SelectedIndex + 1;
           // form1.mSM1.Theme = (MetroThemeStyle) comboBoxTheme.SelectedIndex + 1;
            form1.INI.Write(consts.allSettings[0], consts.setThemeKeys[0],(string) comboBoxTheme.SelectedItem);
            numericUpDown1.BackColor = consts.listViewColors[getThemeFromIniId() - 1];
            numericUpDown1.ForeColor = consts.listViewColors2[getThemeFromIniId() - 1];
            lb1.BackColor = consts.listViewColors[getThemeFromIniId() - 1];
            lb1.ForeColor = consts.listViewColors2[getThemeFromIniId() - 1];
            //form1.INI.Write(")
            // if (comboBoxTheme.SelectedItem != null)
            //setVarsGlobal.themeStyle = ;
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSM1.Style = (MetroColorStyle) comboBoxColor.SelectedIndex+1;
            //form1.mSM1.Style = (MetroColorStyle)comboBoxColor.SelectedIndex + 1;
            SettableVars.colorStyle = (MetroColorStyle)comboBoxColor.SelectedIndex + 1;
            form1.INI.Write(consts.allSettings[0], consts.setThemeKeys[1], (string)comboBoxColor.SelectedItem);
        }
        void WhenClose()
        {
            SettableVars.colorStyle = (MetroColorStyle)comboBoxColor.SelectedIndex + 1;
            SettableVars.themeStyle = (MetroThemeStyle)comboBoxTheme.SelectedIndex + 1;
            SettableVars.ThemeId = comboBoxTheme.SelectedIndex;
            form1.INI.Write(consts.allSettings[0], @consts.allSettings[3], textBoxDevicePath.Text);
            if (textBoxDevicePath.Text.Trim() == "")
                textBoxDevicePath.Text = "sdcard/";
            SettableVars.DevicePathFile = textBoxDevicePath.Text;
            form1.SetTimerInterval();
            // form1.ThemeUpdater(comboBoxTheme.SelectedIndex);
            this.DialogResult = DialogResult.OK;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            WhenClose();
        }

        private void settingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WhenClose();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SettableVars.AdbPath = mainVars.selectadbfile();
            textBoxADBPath.Text = SettableVars.AdbPath;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,SettableVars.AdbPath,"ADB path copied!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Clipboard.SetText(SettableVars.AdbPath);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.WorkingDirectory = SettableVars.AdbPath.Replace("adb.exe", "");
            p.StartInfo.FileName = "cmd.exe";
            p.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SettableVars.DevicesUpdatingTiming = (int) numericUpDown1.Value*1000;
            form1.INI.Write(consts.allSettings[0], consts.allSettings[4], SettableVars.DevicesUpdatingTiming.ToString());
        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (!form1.INI.KeyExists("IsFirstEnable", consts.allSettings[0]))
            {
                form1.INI.Write(consts.allSettings[0], "IsFirstEnable", "true");
                MetroMessageBox.Show(this, "By enabling this function, each time you start this program, vysor will automatically start and connect to the last device!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            form1.INI.Write(consts.allSettings[0], consts.allSettings[5], metroToggle1.CheckState==CheckState.Checked? "true":"false");
        }
    }
}

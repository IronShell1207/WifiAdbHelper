namespace WifiAdbHelper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mSM1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.textboxIP = new MetroFramework.Controls.MetroTextBox();
            this.buttonConnect = new MetroFramework.Controls.MetroButton();
            this.buttonKill = new MetroFramework.Controls.MetroButton();
            this.buttonVysor = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelADBstatus = new MetroFramework.Controls.MetroLabel();
            this.buttonDisconnect = new MetroFramework.Controls.MetroButton();
            this.buttonStart = new MetroFramework.Controls.MetroButton();
            this.oFD1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuICon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDevices = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.buttonPushFile = new MetroFramework.Controls.MetroButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerAutoUpdateList = new System.Windows.Forms.Timer(this.components);
            this.chcBoxUpdate = new MetroFramework.Controls.MetroCheckBox();
            this.buttonReboot = new MetroFramework.Controls.MetroButton();
            this.contextMADB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyADBPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCMDADBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killVysorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttontest = new MetroFramework.Controls.MetroButton();
            this.labelADBpath = new MetroFramework.Controls.MetroLabel();
            this.labeladbpop = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.buttonSetting = new MetroFramework.Controls.MetroButton();
            this.timerStatusAndButtons = new System.Windows.Forms.Timer(this.components);
            this.buttonRecon = new MetroFramework.Controls.MetroButton();
            this.pBoxArrow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mSM1)).BeginInit();
            this.contextMenuICon.SuspendLayout();
            this.contextMADB.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mSM1
            // 
            this.mSM1.Owner = this;
            this.mSM1.Style = MetroFramework.MetroColorStyle.Brown;
            this.mSM1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textboxIP
            // 
            // 
            // 
            // 
            this.textboxIP.CustomButton.Image = null;
            this.textboxIP.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.textboxIP.CustomButton.Name = "";
            this.textboxIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxIP.CustomButton.TabIndex = 1;
            this.textboxIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxIP.CustomButton.UseSelectable = true;
            this.textboxIP.CustomButton.Visible = false;
            this.textboxIP.Lines = new string[] {
        "192.168.1."};
            this.textboxIP.Location = new System.Drawing.Point(49, 71);
            this.textboxIP.MaxLength = 32767;
            this.textboxIP.Name = "textboxIP";
            this.textboxIP.PasswordChar = '\0';
            this.textboxIP.PromptText = "Ip address";
            this.textboxIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxIP.SelectedText = "";
            this.textboxIP.SelectionLength = 0;
            this.textboxIP.SelectionStart = 0;
            this.textboxIP.ShortcutsEnabled = true;
            this.textboxIP.Size = new System.Drawing.Size(135, 23);
            this.textboxIP.TabIndex = 0;
            this.textboxIP.Text = "192.168.1.";
            this.textboxIP.UseSelectable = true;
            this.textboxIP.WaterMark = "Ip address";
            this.textboxIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxIP.TextChanged += new System.EventHandler(this.textboxIP_TextChanged);
            this.textboxIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox1_KeyDown);
            this.textboxIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxIP_KeyPress);
            this.textboxIP.Leave += new System.EventHandler(this.textboxIP_Leave);
            // 
            // buttonConnect
            // 
            this.buttonConnect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonConnect.Location = new System.Drawing.Point(206, 71);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseSelectable = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonKill
            // 
            this.buttonKill.Enabled = false;
            this.buttonKill.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonKill.Location = new System.Drawing.Point(206, 216);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(75, 23);
            this.buttonKill.TabIndex = 2;
            this.buttonKill.Text = "Kill server";
            this.buttonKill.UseSelectable = true;
            this.buttonKill.Click += new System.EventHandler(this.buttonKillServer_Click);
            // 
            // buttonVysor
            // 
            this.buttonVysor.AccessibleDescription = "";
            this.buttonVysor.AccessibleName = "";
            this.buttonVysor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonVysor.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonVysor.Location = new System.Drawing.Point(206, 245);
            this.buttonVysor.Name = "buttonVysor";
            this.buttonVysor.Size = new System.Drawing.Size(75, 23);
            this.buttonVysor.TabIndex = 3;
            this.buttonVysor.Text = "Open Vysor";
            this.buttonVysor.UseSelectable = true;
            this.buttonVysor.Click += new System.EventHandler(this.metroButton3_Click);
            this.buttonVysor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonVysor_MouseUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "IP";
            // 
            // labelADBstatus
            // 
            this.labelADBstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelADBstatus.AutoSize = true;
            this.labelADBstatus.Location = new System.Drawing.Point(193, 30);
            this.labelADBstatus.Name = "labelADBstatus";
            this.labelADBstatus.Size = new System.Drawing.Size(45, 19);
            this.labelADBstatus.TabIndex = 6;
            this.labelADBstatus.Text = "adb: ?";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonDisconnect.Location = new System.Drawing.Point(206, 100);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseSelectable = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonStart.Location = new System.Drawing.Point(206, 187);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start server";
            this.buttonStart.UseSelectable = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // oFD1
            // 
            this.oFD1.FileName = "adb.exe";
            this.oFD1.Title = "Select the adb.exe";
            // 
            // contextMenuICon
            // 
            this.contextMenuICon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuICon.Name = "contextMenuICon";
            this.contextMenuICon.Size = new System.Drawing.Size(169, 48);
            this.contextMenuICon.Text = "f";
            this.contextMenuICon.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuICon_Opening);
            // 
            // развернутьToolStripMenuItem
            // 
            this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
            this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.развернутьToolStripMenuItem.Text = "Show the window";
            this.развернутьToolStripMenuItem.Click += new System.EventHandler(this.развернутьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // buttonDevices
            // 
            this.buttonDevices.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.buttonDevices.Location = new System.Drawing.Point(23, 302);
            this.buttonDevices.Name = "buttonDevices";
            this.buttonDevices.Size = new System.Drawing.Size(51, 23);
            this.buttonDevices.TabIndex = 10;
            this.buttonDevices.Text = "Refresh";
            this.buttonDevices.UseSelectable = true;
            this.buttonDevices.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(23, 52);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(261, 17);
            this.metroProgressBar1.TabIndex = 11;
            this.metroProgressBar1.Value = 30;
            this.metroProgressBar1.Visible = false;
            // 
            // buttonPushFile
            // 
            this.buttonPushFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPushFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonPushFile.Location = new System.Drawing.Point(23, 331);
            this.buttonPushFile.Name = "buttonPushFile";
            this.buttonPushFile.Size = new System.Drawing.Size(253, 23);
            this.buttonPushFile.TabIndex = 1;
            this.buttonPushFile.Text = "Select or drop there file to push to device";
            this.buttonPushFile.UseSelectable = true;
            this.buttonPushFile.Click += new System.EventHandler(this.buttonpush_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gainsboro;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 129);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(161, 167);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 159;
            // 
            // timerAutoUpdateList
            // 
            this.timerAutoUpdateList.Interval = 10000;
            this.timerAutoUpdateList.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // chcBoxUpdate
            // 
            this.chcBoxUpdate.AutoSize = true;
            this.chcBoxUpdate.Checked = true;
            this.chcBoxUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcBoxUpdate.Location = new System.Drawing.Point(78, 306);
            this.chcBoxUpdate.Name = "chcBoxUpdate";
            this.chcBoxUpdate.Size = new System.Drawing.Size(111, 15);
            this.chcBoxUpdate.TabIndex = 14;
            this.chcBoxUpdate.Text = "Auto Update List";
            this.chcBoxUpdate.UseSelectable = true;
            this.chcBoxUpdate.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // buttonReboot
            // 
            this.buttonReboot.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonReboot.Location = new System.Drawing.Point(206, 158);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(75, 23);
            this.buttonReboot.TabIndex = 15;
            this.buttonReboot.Text = "Reboot";
            this.buttonReboot.UseSelectable = true;
            this.buttonReboot.Click += new System.EventHandler(this.buttonReboot_Click);
            // 
            // contextMADB
            // 
            this.contextMADB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyADBPathToolStripMenuItem,
            this.startCMDADBToolStripMenuItem});
            this.contextMADB.Name = "contextMenuStrip1";
            this.contextMADB.Size = new System.Drawing.Size(156, 48);
            this.contextMADB.Opening += new System.ComponentModel.CancelEventHandler(this.contextMADB_Opening);
            // 
            // copyADBPathToolStripMenuItem
            // 
            this.copyADBPathToolStripMenuItem.Name = "copyADBPathToolStripMenuItem";
            this.copyADBPathToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyADBPathToolStripMenuItem.Text = "Copy ADB Path";
            this.copyADBPathToolStripMenuItem.Click += new System.EventHandler(this.copyADBPathToolStripMenuItem_Click);
            // 
            // startCMDADBToolStripMenuItem
            // 
            this.startCMDADBToolStripMenuItem.Name = "startCMDADBToolStripMenuItem";
            this.startCMDADBToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.startCMDADBToolStripMenuItem.Text = "Start CMD ADB";
            this.startCMDADBToolStripMenuItem.Click += new System.EventHandler(this.startCMDADBToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killVysorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // killVysorToolStripMenuItem
            // 
            this.killVysorToolStripMenuItem.Name = "killVysorToolStripMenuItem";
            this.killVysorToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.killVysorToolStripMenuItem.Text = "Kill Vysor";
            this.killVysorToolStripMenuItem.Click += new System.EventHandler(this.killVysorToolStripMenuItem_Click);
            // 
            // buttontest
            // 
            this.buttontest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttontest.Location = new System.Drawing.Point(206, 301);
            this.buttontest.Name = "buttontest";
            this.buttontest.Size = new System.Drawing.Size(75, 19);
            this.buttontest.TabIndex = 1;
            this.buttontest.Text = "Update!";
            this.buttontest.UseSelectable = true;
            this.buttontest.Visible = false;
            this.buttontest.Click += new System.EventHandler(this.buttontest_Click);
            // 
            // labelADBpath
            // 
            this.labelADBpath.AutoSize = true;
            this.labelADBpath.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelADBpath.Location = new System.Drawing.Point(16, 360);
            this.labelADBpath.Name = "labelADBpath";
            this.labelADBpath.Size = new System.Drawing.Size(58, 15);
            this.labelADBpath.TabIndex = 16;
            this.labelADBpath.Text = "ADB Path:";
            // 
            // labeladbpop
            // 
            this.labeladbpop.AutoSize = true;
            this.labeladbpop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labeladbpop.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labeladbpop.Location = new System.Drawing.Point(0, 0);
            this.labeladbpop.Name = "labeladbpop";
            this.labeladbpop.Size = new System.Drawing.Size(23, 15);
            this.labeladbpop.TabIndex = 17;
            this.labeladbpop.Text = "null";
            this.labeladbpop.TextChanged += new System.EventHandler(this.labeladbpop_TextChanged);
            this.labeladbpop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labeladbpop_MouseDoubleClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.labeladbpop);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(78, 360);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(203, 15);
            this.metroPanel1.TabIndex = 18;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(119, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Devices connected:";
            // 
            // buttonSetting
            // 
            this.buttonSetting.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonSetting.Location = new System.Drawing.Point(206, 273);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(75, 23);
            this.buttonSetting.TabIndex = 20;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseSelectable = true;
            this.buttonSetting.Click += new System.EventHandler(this.SettingButton_Click);
            this.buttonSetting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonADB_MouseUp);
            // 
            // timerStatusAndButtons
            // 
            this.timerStatusAndButtons.Enabled = true;
            this.timerStatusAndButtons.Tick += new System.EventHandler(this.timerStatusAndButtons_Tick);
            // 
            // buttonRecon
            // 
            this.buttonRecon.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.buttonRecon.Location = new System.Drawing.Point(206, 129);
            this.buttonRecon.Name = "buttonRecon";
            this.buttonRecon.Size = new System.Drawing.Size(75, 23);
            this.buttonRecon.TabIndex = 21;
            this.buttonRecon.Text = "Reconnect";
            this.buttonRecon.UseSelectable = true;
            this.buttonRecon.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pBoxArrow
            // 
            this.pBoxArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxArrow.Image = global::WifiAdbHelper.Properties.Resources.Arrow_right;
            this.pBoxArrow.Location = new System.Drawing.Point(0, 7);
            this.pBoxArrow.Name = "pBoxArrow";
            this.pBoxArrow.Size = new System.Drawing.Size(22, 29);
            this.pBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxArrow.TabIndex = 24;
            this.pBoxArrow.TabStop = false;
            this.pBoxArrow.Visible = false;
            this.pBoxArrow.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WifiAdbHelper.Properties.Resources.movetray0;
            this.pictureBox1.Location = new System.Drawing.Point(217, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBoxArrow);
            this.Controls.Add(this.buttonRecon);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.labelADBpath);
            this.Controls.Add(this.buttonReboot);
            this.Controls.Add(this.chcBoxUpdate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.buttonDevices);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.labelADBstatus);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buttonVysor);
            this.Controls.Add(this.buttonKill);
            this.Controls.Add(this.buttonPushFile);
            this.Controls.Add(this.buttontest);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textboxIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "WifiADBHelper";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.mSM1)).EndInit();
            this.contextMenuICon.ResumeLayout(false);
            this.contextMADB.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton buttonConnect;
        private MetroFramework.Controls.MetroButton buttonVysor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labelADBstatus;
        private MetroFramework.Controls.MetroButton buttonDisconnect;
        private System.Windows.Forms.OpenFileDialog oFD1;
        private System.Windows.Forms.ContextMenuStrip contextMenuICon;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private MetroFramework.Controls.MetroButton buttonDevices;
        private MetroFramework.Controls.MetroButton buttonPushFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroButton buttonReboot;
        private System.Windows.Forms.ContextMenuStrip contextMADB;
        private System.Windows.Forms.ToolStripMenuItem copyADBPathToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Timer timerAutoUpdateList;
        public MetroFramework.Controls.MetroCheckBox chcBoxUpdate;
        public MetroFramework.Controls.MetroTextBox textboxIP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killVysorToolStripMenuItem;
        public MetroFramework.Controls.MetroButton buttonKill;
        public MetroFramework.Controls.MetroButton buttonStart;
        private System.Windows.Forms.ToolStripMenuItem startCMDADBToolStripMenuItem;
        private MetroFramework.Controls.MetroButton buttontest;
        private MetroFramework.Controls.MetroLabel labeladbpop;
        private MetroFramework.Controls.MetroLabel labelADBpath;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton buttonSetting;
        private System.Windows.Forms.Timer timerStatusAndButtons;
        public MetroFramework.Components.MetroStyleManager mSM1;
        private System.Windows.Forms.PictureBox pBoxArrow;
        private MetroFramework.Controls.MetroButton buttonRecon;
        public MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


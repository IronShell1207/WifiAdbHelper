namespace WifiAdbHelper
{
    partial class settingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.comboBoxTheme = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxColor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBoxADBPath = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.Adb = new MetroFramework.Controls.MetroLabel();
            this.labelVersion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textBoxDevicePath = new MetroFramework.Controls.MetroTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(342, 316);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Close";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.ItemHeight = 23;
            this.comboBoxTheme.Location = new System.Drawing.Point(117, 63);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(300, 29);
            this.comboBoxTheme.TabIndex = 1;
            this.comboBoxTheme.UseSelectable = true;
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.ItemHeight = 23;
            this.comboBoxColor.Location = new System.Drawing.Point(117, 108);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(300, 29);
            this.comboBoxColor.TabIndex = 2;
            this.comboBoxColor.UseSelectable = true;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Theme style";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Color style";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroButton2
            // 
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(342, 153);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 29);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Tag = "Путь к папке ADB";
            this.metroButton2.Text = "Set adb path";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 157);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "ADB Path";
            // 
            // textBoxADBPath
            // 
            // 
            // 
            // 
            this.textBoxADBPath.CustomButton.Image = null;
            this.textBoxADBPath.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.textBoxADBPath.CustomButton.Name = "";
            this.textBoxADBPath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBoxADBPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxADBPath.CustomButton.TabIndex = 1;
            this.textBoxADBPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxADBPath.CustomButton.UseSelectable = true;
            this.textBoxADBPath.CustomButton.Visible = false;
            this.textBoxADBPath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxADBPath.Lines = new string[0];
            this.textBoxADBPath.Location = new System.Drawing.Point(117, 153);
            this.textBoxADBPath.MaxLength = 32767;
            this.textBoxADBPath.Name = "textBoxADBPath";
            this.textBoxADBPath.PasswordChar = '\0';
            this.textBoxADBPath.ReadOnly = true;
            this.textBoxADBPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxADBPath.SelectedText = "";
            this.textBoxADBPath.SelectionLength = 0;
            this.textBoxADBPath.SelectionStart = 0;
            this.textBoxADBPath.ShortcutsEnabled = true;
            this.textBoxADBPath.Size = new System.Drawing.Size(208, 29);
            this.textBoxADBPath.TabIndex = 11;
            this.textBoxADBPath.UseSelectable = true;
            this.textBoxADBPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxADBPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton3.Location = new System.Drawing.Point(198, 196);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(90, 29);
            this.metroButton3.TabIndex = 12;
            this.metroButton3.Text = "Copy ADB Path";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton4.Location = new System.Drawing.Point(302, 196);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(115, 29);
            this.metroButton4.TabIndex = 13;
            this.metroButton4.Text = "Start cmd with path";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Adb
            // 
            this.Adb.AutoSize = true;
            this.Adb.Location = new System.Drawing.Point(17, 199);
            this.Adb.Name = "Adb";
            this.Adb.Size = new System.Drawing.Size(93, 19);
            this.Adb.TabIndex = 14;
            this.Adb.Text = "Update timing";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(17, 320);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(83, 19);
            this.labelVersion.TabIndex = 15;
            this.labelVersion.Text = "metroLabel4";
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 235);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 38);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Path on device\r\nto push file";
            // 
            // textBoxDevicePath
            // 
            // 
            // 
            // 
            this.textBoxDevicePath.CustomButton.Image = null;
            this.textBoxDevicePath.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.textBoxDevicePath.CustomButton.Name = "";
            this.textBoxDevicePath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBoxDevicePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxDevicePath.CustomButton.TabIndex = 1;
            this.textBoxDevicePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxDevicePath.CustomButton.UseSelectable = true;
            this.textBoxDevicePath.CustomButton.Visible = false;
            this.textBoxDevicePath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBoxDevicePath.Lines = new string[] {
        "sdcard/"};
            this.textBoxDevicePath.Location = new System.Drawing.Point(117, 242);
            this.textBoxDevicePath.MaxLength = 32767;
            this.textBoxDevicePath.Name = "textBoxDevicePath";
            this.textBoxDevicePath.PasswordChar = '\0';
            this.textBoxDevicePath.PromptText = "Must ends by \"/\"";
            this.textBoxDevicePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDevicePath.SelectedText = "";
            this.textBoxDevicePath.SelectionLength = 0;
            this.textBoxDevicePath.SelectionStart = 0;
            this.textBoxDevicePath.ShortcutsEnabled = true;
            this.textBoxDevicePath.Size = new System.Drawing.Size(300, 29);
            this.textBoxDevicePath.TabIndex = 17;
            this.textBoxDevicePath.Text = "sdcard/";
            this.textBoxDevicePath.UseSelectable = true;
            this.textBoxDevicePath.WaterMark = "Must ends by \"/\"";
            this.textBoxDevicePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxDevicePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Black;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(117, 196);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(69, 29);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.Location = new System.Drawing.Point(302, 288);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(50, 17);
            this.metroToggle1.TabIndex = 19;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 286);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(195, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Auto connect last device at start";
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 349);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxDevicePath);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.Adb);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.textBoxADBPath);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.settingForm_FormClosed);
            this.Load += new System.EventHandler(this.settingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox comboBoxTheme;
        private MetroFramework.Controls.MetroComboBox comboBoxColor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox textBoxADBPath;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel Adb;
        private MetroFramework.Controls.MetroLabel labelVersion;
        private MetroFramework.Controls.MetroTextBox textBoxDevicePath;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle metroToggle1;
    }
}
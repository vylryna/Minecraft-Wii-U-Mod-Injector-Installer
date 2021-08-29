
namespace Minecraft_Wii_U_Mod_Injector_Installer
{
    partial class MainForm
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
            this.MainTabs = new MetroFramework.Controls.MetroTabControl();
            this.WelcomeTab = new MetroFramework.Controls.MetroTabPage();
            this.welcomeInfoLbl = new MetroFramework.Controls.MetroLabel();
            this.welcomeLbl = new MetroFramework.Controls.MetroLabel();
            this.InstallPathTab = new MetroFramework.Controls.MetroTabPage();
            this.DesktopShortcutCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.BrowseBtn = new MetroFramework.Controls.MetroButton();
            this.browseLbl = new MetroFramework.Controls.MetroLabel();
            this.installPathLbl = new MetroFramework.Controls.MetroLabel();
            this.installPathBox = new MetroFramework.Controls.MetroTextBox();
            this.InstallingTab = new MetroFramework.Controls.MetroTabPage();
            this.InstallingLbl = new MetroFramework.Controls.MetroLabel();
            this.InstallProgress = new MetroFramework.Controls.MetroProgressBar();
            this.InstallLogBox = new MetroFramework.Controls.MetroTextBox();
            this.InstallCompleteTab = new MetroFramework.Controls.MetroTabPage();
            this.LaunchCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.nowInstalledLbl = new MetroFramework.Controls.MetroLabel();
            this.thankYouLbl = new MetroFramework.Controls.MetroLabel();
            this.CancelCloseBtn = new MetroFramework.Controls.MetroButton();
            this.NextBtn = new MetroFramework.Controls.MetroButton();
            this.BackBtn = new MetroFramework.Controls.MetroButton();
            this.topDivPnl = new MetroFramework.Controls.MetroPanel();
            this.InjectorLogo = new MetroFramework.Controls.MetroPanel();
            this.botDivPnl = new MetroFramework.Controls.MetroPanel();
            this.midDivPnl = new MetroFramework.Controls.MetroPanel();
            this.MainTabs.SuspendLayout();
            this.WelcomeTab.SuspendLayout();
            this.InstallPathTab.SuspendLayout();
            this.InstallingTab.SuspendLayout();
            this.InstallCompleteTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.WelcomeTab);
            this.MainTabs.Controls.Add(this.InstallPathTab);
            this.MainTabs.Controls.Add(this.InstallingTab);
            this.MainTabs.Controls.Add(this.InstallCompleteTab);
            this.MainTabs.ItemSize = new System.Drawing.Size(130, 1);
            this.MainTabs.Location = new System.Drawing.Point(318, 54);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 1;
            this.MainTabs.Size = new System.Drawing.Size(527, 397);
            this.MainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabs.Style = MetroFramework.MetroColorStyle.Red;
            this.MainTabs.TabIndex = 0;
            this.MainTabs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTabs.UseSelectable = true;
            // 
            // WelcomeTab
            // 
            this.WelcomeTab.Controls.Add(this.welcomeInfoLbl);
            this.WelcomeTab.Controls.Add(this.welcomeLbl);
            this.WelcomeTab.HorizontalScrollbarBarColor = true;
            this.WelcomeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.WelcomeTab.HorizontalScrollbarSize = 10;
            this.WelcomeTab.Location = new System.Drawing.Point(4, 5);
            this.WelcomeTab.Name = "WelcomeTab";
            this.WelcomeTab.Size = new System.Drawing.Size(519, 388);
            this.WelcomeTab.Style = MetroFramework.MetroColorStyle.Red;
            this.WelcomeTab.TabIndex = 0;
            this.WelcomeTab.Text = "Welcome";
            this.WelcomeTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WelcomeTab.VerticalScrollbarBarColor = true;
            this.WelcomeTab.VerticalScrollbarHighlightOnWheel = false;
            this.WelcomeTab.VerticalScrollbarSize = 10;
            // 
            // welcomeInfoLbl
            // 
            this.welcomeInfoLbl.AutoSize = true;
            this.welcomeInfoLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.welcomeInfoLbl.Location = new System.Drawing.Point(38, 64);
            this.welcomeInfoLbl.Name = "welcomeInfoLbl";
            this.welcomeInfoLbl.Size = new System.Drawing.Size(457, 57);
            this.welcomeInfoLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.welcomeInfoLbl.TabIndex = 3;
            this.welcomeInfoLbl.Text = "This setup will install the Minecraft: Wii U Mod Injector on your computer\r\n\r\nCli" +
    "ck Next to continue, or Cancel to stop the installation";
            this.welcomeInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeInfoLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcomeLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.welcomeLbl.Location = new System.Drawing.Point(14, 16);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(491, 25);
            this.welcomeLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.welcomeLbl.TabIndex = 2;
            this.welcomeLbl.Text = "Welcome to the Minecraft: Wii U Mod Injector Installer Setup";
            this.welcomeLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // InstallPathTab
            // 
            this.InstallPathTab.Controls.Add(this.DesktopShortcutCheckBox);
            this.InstallPathTab.Controls.Add(this.BrowseBtn);
            this.InstallPathTab.Controls.Add(this.browseLbl);
            this.InstallPathTab.Controls.Add(this.installPathLbl);
            this.InstallPathTab.Controls.Add(this.installPathBox);
            this.InstallPathTab.HorizontalScrollbarBarColor = true;
            this.InstallPathTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InstallPathTab.HorizontalScrollbarSize = 10;
            this.InstallPathTab.Location = new System.Drawing.Point(4, 5);
            this.InstallPathTab.Name = "InstallPathTab";
            this.InstallPathTab.Size = new System.Drawing.Size(519, 388);
            this.InstallPathTab.Style = MetroFramework.MetroColorStyle.Red;
            this.InstallPathTab.TabIndex = 1;
            this.InstallPathTab.Text = "Install Path";
            this.InstallPathTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InstallPathTab.VerticalScrollbarBarColor = true;
            this.InstallPathTab.VerticalScrollbarHighlightOnWheel = false;
            this.InstallPathTab.VerticalScrollbarSize = 10;
            // 
            // DesktopShortcutCheckBox
            // 
            this.DesktopShortcutCheckBox.AutoSize = true;
            this.DesktopShortcutCheckBox.Checked = true;
            this.DesktopShortcutCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DesktopShortcutCheckBox.Location = new System.Drawing.Point(202, 144);
            this.DesktopShortcutCheckBox.Name = "DesktopShortcutCheckBox";
            this.DesktopShortcutCheckBox.Size = new System.Drawing.Size(114, 15);
            this.DesktopShortcutCheckBox.Style = MetroFramework.MetroColorStyle.Red;
            this.DesktopShortcutCheckBox.TabIndex = 9;
            this.DesktopShortcutCheckBox.Text = "Desktop Shortcut";
            this.DesktopShortcutCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DesktopShortcutCheckBox.UseSelectable = true;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(4, 112);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(510, 23);
            this.BrowseBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.BrowseBtn.TabIndex = 5;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BrowseBtn.UseSelectable = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtnClicked);
            // 
            // browseLbl
            // 
            this.browseLbl.AutoSize = true;
            this.browseLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.browseLbl.Location = new System.Drawing.Point(89, 49);
            this.browseLbl.Name = "browseLbl";
            this.browseLbl.Size = new System.Drawing.Size(356, 19);
            this.browseLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.browseLbl.TabIndex = 4;
            this.browseLbl.Text = "If you would like to select a different folder, press Browse";
            this.browseLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // installPathLbl
            // 
            this.installPathLbl.AutoSize = true;
            this.installPathLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.installPathLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.installPathLbl.Location = new System.Drawing.Point(5, 15);
            this.installPathLbl.Name = "installPathLbl";
            this.installPathLbl.Size = new System.Drawing.Size(509, 25);
            this.installPathLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.installPathLbl.TabIndex = 3;
            this.installPathLbl.Text = "Setup will install the Minecraft: Wii U Mod Injector in this folder";
            this.installPathLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // installPathBox
            // 
            // 
            // 
            // 
            this.installPathBox.CustomButton.Image = null;
            this.installPathBox.CustomButton.Location = new System.Drawing.Point(488, 1);
            this.installPathBox.CustomButton.Name = "";
            this.installPathBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.installPathBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.installPathBox.CustomButton.TabIndex = 1;
            this.installPathBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.installPathBox.CustomButton.UseSelectable = true;
            this.installPathBox.CustomButton.Visible = false;
            this.installPathBox.Lines = new string[0];
            this.installPathBox.Location = new System.Drawing.Point(4, 83);
            this.installPathBox.MaxLength = 32767;
            this.installPathBox.Name = "installPathBox";
            this.installPathBox.PasswordChar = '\0';
            this.installPathBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.installPathBox.SelectedText = "";
            this.installPathBox.SelectionLength = 0;
            this.installPathBox.SelectionStart = 0;
            this.installPathBox.ShortcutsEnabled = true;
            this.installPathBox.Size = new System.Drawing.Size(510, 23);
            this.installPathBox.Style = MetroFramework.MetroColorStyle.Red;
            this.installPathBox.TabIndex = 2;
            this.installPathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.installPathBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.installPathBox.UseSelectable = true;
            this.installPathBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.installPathBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InstallingTab
            // 
            this.InstallingTab.Controls.Add(this.InstallingLbl);
            this.InstallingTab.Controls.Add(this.InstallProgress);
            this.InstallingTab.Controls.Add(this.InstallLogBox);
            this.InstallingTab.HorizontalScrollbarBarColor = true;
            this.InstallingTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InstallingTab.HorizontalScrollbarSize = 10;
            this.InstallingTab.Location = new System.Drawing.Point(4, 5);
            this.InstallingTab.Name = "InstallingTab";
            this.InstallingTab.Size = new System.Drawing.Size(519, 388);
            this.InstallingTab.Style = MetroFramework.MetroColorStyle.Red;
            this.InstallingTab.TabIndex = 2;
            this.InstallingTab.Text = "Installing";
            this.InstallingTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InstallingTab.VerticalScrollbarBarColor = true;
            this.InstallingTab.VerticalScrollbarHighlightOnWheel = false;
            this.InstallingTab.VerticalScrollbarSize = 10;
            // 
            // InstallingLbl
            // 
            this.InstallingLbl.AutoSize = true;
            this.InstallingLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InstallingLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.InstallingLbl.Location = new System.Drawing.Point(87, 10);
            this.InstallingLbl.Name = "InstallingLbl";
            this.InstallingLbl.Size = new System.Drawing.Size(344, 25);
            this.InstallingLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.InstallingLbl.TabIndex = 5;
            this.InstallingLbl.Text = "Please wait while installation is in progress";
            this.InstallingLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // InstallProgress
            // 
            this.InstallProgress.Location = new System.Drawing.Point(4, 361);
            this.InstallProgress.Name = "InstallProgress";
            this.InstallProgress.Size = new System.Drawing.Size(510, 23);
            this.InstallProgress.Style = MetroFramework.MetroColorStyle.Red;
            this.InstallProgress.TabIndex = 4;
            this.InstallProgress.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // InstallLogBox
            // 
            // 
            // 
            // 
            this.InstallLogBox.CustomButton.Image = null;
            this.InstallLogBox.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.InstallLogBox.CustomButton.Name = "";
            this.InstallLogBox.CustomButton.Size = new System.Drawing.Size(307, 307);
            this.InstallLogBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InstallLogBox.CustomButton.TabIndex = 1;
            this.InstallLogBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InstallLogBox.CustomButton.UseSelectable = true;
            this.InstallLogBox.CustomButton.Visible = false;
            this.InstallLogBox.Lines = new string[0];
            this.InstallLogBox.Location = new System.Drawing.Point(4, 43);
            this.InstallLogBox.MaxLength = 32767;
            this.InstallLogBox.Multiline = true;
            this.InstallLogBox.Name = "InstallLogBox";
            this.InstallLogBox.PasswordChar = '\0';
            this.InstallLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InstallLogBox.SelectedText = "";
            this.InstallLogBox.SelectionLength = 0;
            this.InstallLogBox.SelectionStart = 0;
            this.InstallLogBox.ShortcutsEnabled = true;
            this.InstallLogBox.Size = new System.Drawing.Size(510, 309);
            this.InstallLogBox.Style = MetroFramework.MetroColorStyle.Red;
            this.InstallLogBox.TabIndex = 3;
            this.InstallLogBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InstallLogBox.UseSelectable = true;
            this.InstallLogBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InstallLogBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InstallCompleteTab
            // 
            this.InstallCompleteTab.Controls.Add(this.LaunchCheckBox);
            this.InstallCompleteTab.Controls.Add(this.nowInstalledLbl);
            this.InstallCompleteTab.Controls.Add(this.thankYouLbl);
            this.InstallCompleteTab.HorizontalScrollbarBarColor = true;
            this.InstallCompleteTab.HorizontalScrollbarHighlightOnWheel = false;
            this.InstallCompleteTab.HorizontalScrollbarSize = 10;
            this.InstallCompleteTab.Location = new System.Drawing.Point(4, 5);
            this.InstallCompleteTab.Name = "InstallCompleteTab";
            this.InstallCompleteTab.Size = new System.Drawing.Size(519, 388);
            this.InstallCompleteTab.Style = MetroFramework.MetroColorStyle.Red;
            this.InstallCompleteTab.TabIndex = 3;
            this.InstallCompleteTab.Text = "Install Complete";
            this.InstallCompleteTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InstallCompleteTab.VerticalScrollbarBarColor = true;
            this.InstallCompleteTab.VerticalScrollbarHighlightOnWheel = false;
            this.InstallCompleteTab.VerticalScrollbarSize = 10;
            // 
            // LaunchCheckBox
            // 
            this.LaunchCheckBox.AutoSize = true;
            this.LaunchCheckBox.Location = new System.Drawing.Point(149, 128);
            this.LaunchCheckBox.Name = "LaunchCheckBox";
            this.LaunchCheckBox.Size = new System.Drawing.Size(221, 15);
            this.LaunchCheckBox.Style = MetroFramework.MetroColorStyle.Red;
            this.LaunchCheckBox.TabIndex = 8;
            this.LaunchCheckBox.Text = "Launch Minecraft: Wii U Mod Injector";
            this.LaunchCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LaunchCheckBox.UseSelectable = true;
            // 
            // nowInstalledLbl
            // 
            this.nowInstalledLbl.AutoSize = true;
            this.nowInstalledLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nowInstalledLbl.Location = new System.Drawing.Point(29, 56);
            this.nowInstalledLbl.Name = "nowInstalledLbl";
            this.nowInstalledLbl.Size = new System.Drawing.Size(460, 38);
            this.nowInstalledLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.nowInstalledLbl.TabIndex = 7;
            this.nowInstalledLbl.Text = "The application is now succesfully installed on your computer and you can\r\nnow ex" +
    "it the setup installer";
            this.nowInstalledLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nowInstalledLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // thankYouLbl
            // 
            this.thankYouLbl.AutoSize = true;
            this.thankYouLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.thankYouLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.thankYouLbl.Location = new System.Drawing.Point(25, 16);
            this.thankYouLbl.Name = "thankYouLbl";
            this.thankYouLbl.Size = new System.Drawing.Size(469, 25);
            this.thankYouLbl.Style = MetroFramework.MetroColorStyle.Red;
            this.thankYouLbl.TabIndex = 6;
            this.thankYouLbl.Text = "Thank you for installing the Minecraft: Wii U Mod Injector!";
            this.thankYouLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CancelCloseBtn
            // 
            this.CancelCloseBtn.Location = new System.Drawing.Point(738, 463);
            this.CancelCloseBtn.Name = "CancelCloseBtn";
            this.CancelCloseBtn.Size = new System.Drawing.Size(96, 23);
            this.CancelCloseBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.CancelCloseBtn.TabIndex = 1;
            this.CancelCloseBtn.Text = "Cancel";
            this.CancelCloseBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CancelCloseBtn.UseSelectable = true;
            this.CancelCloseBtn.Click += new System.EventHandler(this.CancelCloseBtnClicked);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(636, 463);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(96, 23);
            this.NextBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next >";
            this.NextBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NextBtn.UseSelectable = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtnClicked);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(534, 463);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(96, 23);
            this.BackBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "< Back";
            this.BackBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BackBtn.UseSelectable = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtnClicked);
            // 
            // topDivPnl
            // 
            this.topDivPnl.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector_Installer.Properties.Resources.topDiv;
            this.topDivPnl.HorizontalScrollbarBarColor = true;
            this.topDivPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.topDivPnl.HorizontalScrollbarSize = 10;
            this.topDivPnl.Location = new System.Drawing.Point(-3, 56);
            this.topDivPnl.Name = "topDivPnl";
            this.topDivPnl.Size = new System.Drawing.Size(328, 3);
            this.topDivPnl.Style = MetroFramework.MetroColorStyle.Red;
            this.topDivPnl.TabIndex = 5;
            this.topDivPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.topDivPnl.UseStyleColors = true;
            this.topDivPnl.VerticalScrollbarBarColor = true;
            this.topDivPnl.VerticalScrollbarHighlightOnWheel = false;
            this.topDivPnl.VerticalScrollbarSize = 10;
            // 
            // InjectorLogo
            // 
            this.InjectorLogo.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector_Installer.Properties.Resources.MinecraftWiiUModInjector;
            this.InjectorLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InjectorLogo.HorizontalScrollbarBarColor = true;
            this.InjectorLogo.HorizontalScrollbarHighlightOnWheel = false;
            this.InjectorLogo.HorizontalScrollbarSize = 10;
            this.InjectorLogo.Location = new System.Drawing.Point(0, 56);
            this.InjectorLogo.Name = "InjectorLogo";
            this.InjectorLogo.Size = new System.Drawing.Size(325, 396);
            this.InjectorLogo.Style = MetroFramework.MetroColorStyle.Red;
            this.InjectorLogo.TabIndex = 4;
            this.InjectorLogo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InjectorLogo.UseStyleColors = true;
            this.InjectorLogo.VerticalScrollbarBarColor = true;
            this.InjectorLogo.VerticalScrollbarHighlightOnWheel = false;
            this.InjectorLogo.VerticalScrollbarSize = 10;
            // 
            // botDivPnl
            // 
            this.botDivPnl.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector_Installer.Properties.Resources.topDiv;
            this.botDivPnl.HorizontalScrollbarBarColor = true;
            this.botDivPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.botDivPnl.HorizontalScrollbarSize = 10;
            this.botDivPnl.Location = new System.Drawing.Point(1, 450);
            this.botDivPnl.Name = "botDivPnl";
            this.botDivPnl.Size = new System.Drawing.Size(840, 3);
            this.botDivPnl.Style = MetroFramework.MetroColorStyle.Red;
            this.botDivPnl.TabIndex = 6;
            this.botDivPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.botDivPnl.UseStyleColors = true;
            this.botDivPnl.VerticalScrollbarBarColor = true;
            this.botDivPnl.VerticalScrollbarHighlightOnWheel = false;
            this.botDivPnl.VerticalScrollbarSize = 10;
            // 
            // midDivPnl
            // 
            this.midDivPnl.BackgroundImage = global::Minecraft_Wii_U_Mod_Injector_Installer.Properties.Resources.topDiv;
            this.midDivPnl.HorizontalScrollbarBarColor = true;
            this.midDivPnl.HorizontalScrollbarHighlightOnWheel = false;
            this.midDivPnl.HorizontalScrollbarSize = 10;
            this.midDivPnl.Location = new System.Drawing.Point(318, 57);
            this.midDivPnl.Name = "midDivPnl";
            this.midDivPnl.Size = new System.Drawing.Size(3, 395);
            this.midDivPnl.Style = MetroFramework.MetroColorStyle.Red;
            this.midDivPnl.TabIndex = 7;
            this.midDivPnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.midDivPnl.UseStyleColors = true;
            this.midDivPnl.VerticalScrollbarBarColor = true;
            this.midDivPnl.VerticalScrollbarHighlightOnWheel = false;
            this.midDivPnl.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 500);
            this.Controls.Add(this.botDivPnl);
            this.Controls.Add(this.topDivPnl);
            this.Controls.Add(this.midDivPnl);
            this.Controls.Add(this.InjectorLogo);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.CancelCloseBtn);
            this.Controls.Add(this.MainTabs);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Minecraft: Wii U Mod Injector Installer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Init);
            this.MainTabs.ResumeLayout(false);
            this.WelcomeTab.ResumeLayout(false);
            this.WelcomeTab.PerformLayout();
            this.InstallPathTab.ResumeLayout(false);
            this.InstallPathTab.PerformLayout();
            this.InstallingTab.ResumeLayout(false);
            this.InstallingTab.PerformLayout();
            this.InstallCompleteTab.ResumeLayout(false);
            this.InstallCompleteTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroProgressBar InstallProgress;
        public MetroFramework.Controls.MetroTextBox InstallLogBox;
        public MetroFramework.Controls.MetroButton CancelCloseBtn;
        public MetroFramework.Controls.MetroButton NextBtn;
        public MetroFramework.Controls.MetroButton BackBtn;
        public MetroFramework.Controls.MetroTabControl MainTabs;
        public MetroFramework.Controls.MetroTabPage WelcomeTab;
        public MetroFramework.Controls.MetroLabel welcomeLbl;
        public MetroFramework.Controls.MetroPanel InjectorLogo;
        public MetroFramework.Controls.MetroPanel topDivPnl;
        public MetroFramework.Controls.MetroPanel botDivPnl;
        public MetroFramework.Controls.MetroPanel midDivPnl;
        public MetroFramework.Controls.MetroLabel welcomeInfoLbl;
        public MetroFramework.Controls.MetroTabPage InstallPathTab;
        public MetroFramework.Controls.MetroLabel installPathLbl;
        public MetroFramework.Controls.MetroButton BrowseBtn;
        public MetroFramework.Controls.MetroLabel browseLbl;
        public MetroFramework.Controls.MetroTabPage InstallingTab;
        public MetroFramework.Controls.MetroLabel InstallingLbl;
        public MetroFramework.Controls.MetroTextBox installPathBox;
        public MetroFramework.Controls.MetroTabPage InstallCompleteTab;
        public MetroFramework.Controls.MetroLabel thankYouLbl;
        public MetroFramework.Controls.MetroLabel nowInstalledLbl;
        public MetroFramework.Controls.MetroCheckBox LaunchCheckBox;
        public MetroFramework.Controls.MetroCheckBox DesktopShortcutCheckBox;
    }
}


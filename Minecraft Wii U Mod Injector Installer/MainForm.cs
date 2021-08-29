using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using MetroFramework;
using MetroFramework.Forms;
using Minecraft_Wii_U_Mod_Injector_Installer.Helpers;

namespace Minecraft_Wii_U_Mod_Injector_Installer
{
    public partial class MainForm : MetroForm
    {
        private Downloader _downloader;

        private readonly string _modInjectorUrl =
            "https://github.com/Kashiiera/Minecraft-Wii-U-Mod-Injector/releases/latest/download/Minecraft.Wii.U.Mod.Injector.exe";

        private readonly string _modInjectorName = "Minecraft.Wii.U.Mod.Injector.exe";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            _downloader = new Downloader(this);
            installPathBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                                  @"\Minecraft Wii U Mod Injector\";
        }

        public void CreateShortcut()
        {
            object shDesktop = "Desktop";
            var shell = new WshShell();
            var shortcutAddress =
                (string) shell.SpecialFolders.Item(ref shDesktop) + @"\Minecraft Wii U Mod Injector.lnk";
            var shortcut = (IWshShortcut) shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "The first and original Minecraft: Wii U Mod Injector by Kashiiera";
            shortcut.TargetPath = installPathBox.Text + _modInjectorName;
            shortcut.Save();
        }

        private void NextBtnClicked(object sender, EventArgs e)
        {
            if (installPathBox.Text == string.Empty && MainTabs.SelectedIndex != 0)
            {
                MetroMessageBox.Show(this, "Please select an install path before continuing", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (MainTabs.SelectedIndex)
            {
                case 1:
                    if (!Directory.Exists(installPathBox.Text))
                        Directory.CreateDirectory(installPathBox.Text);

                    _downloader.StartDownloading(_modInjectorUrl, installPathBox.Text);
                    break;
                case 2:
                    CancelCloseBtn.Text = @"Close";
                    break;
                case 3:
                {
                    if (LaunchCheckBox.Checked)
                        Process.Start(installPathBox.Text + "/" + _modInjectorName);

                    Environment.Exit(0);
                    break;
                }
            }

            MainTabs.SelectedIndex += 1;
        }

        private void BackBtnClicked(object sender, EventArgs e)
        {
            if (MainTabs.SelectedIndex != 0)
                MainTabs.SelectedIndex -= 1;

            if (MainTabs.SelectedIndex != 3) CancelCloseBtn.Text = @"Cancel";

            if (MainTabs.SelectedIndex != 3) return;

            if (LaunchCheckBox.Checked)
                Process.Start(installPathBox.Text + "/" + _modInjectorName);

            Environment.Exit(0);
        }

        private void BrowseBtnClicked(object sender, EventArgs e)
        {
            var installPathDialog = new FolderBrowserDialog();
            installPathDialog.ShowDialog();

            installPathBox.Text = installPathDialog.SelectedPath;
        }

        private void CancelCloseBtnClicked(object sender, EventArgs e)
        {
            if (MainTabs.SelectedIndex == 2)
                _downloader.CancelDownload();

            if (MainTabs.SelectedIndex == 3)
                Environment.Exit(0);
        }
    }
}

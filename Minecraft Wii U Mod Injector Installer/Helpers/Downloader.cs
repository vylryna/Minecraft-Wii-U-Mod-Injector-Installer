using System;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace Minecraft_Wii_U_Mod_Injector_Installer.Helpers
{
    internal class Downloader
    {
        public MainForm Installer;
        public StringBuilder DownloadLogBuilder = new StringBuilder();
        public WebClient DownloadClient = new WebClient();

        public Downloader(MainForm mf)
        {
            Installer = mf;
        }

        public void StartDownloading(string downloadUrl, string downloadPath)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                DownloadClient.DownloadProgressChanged += DownloadProgress;
                DownloadClient.DownloadFileCompleted += Completed;
                Installer.BackBtn.Enabled = false;
                Installer.NextBtn.Enabled = false;
                DownloadClient.DownloadFileAsync(new Uri(downloadUrl), downloadPath + "/Minecraft.Wii.U.Mod.Injector.exe");
            }
            catch (Exception e)
            {
                DownloadLogBuilder.AppendLine("Installation failed:\n" + e);
                Installer.InstallLogBox.AppendText(DownloadLogBuilder.ToString());
            }
        }

        public void DownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadLogBuilder.AppendLine(string.Format(
                "Downloading... " + e.ProgressPercentage + "% [ {0:0.00}/{1:0.00} MB ]",
                e.BytesReceived / 1024.0 / 1024.0, e.TotalBytesToReceive / 1024.0 / 1024.0));

            Installer.InstallProgress.Value = e.ProgressPercentage;
        }

        public void CancelDownload()
        {
            DownloadClient.CancelAsync();
        }

        public void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                DownloadLogBuilder.AppendLine("Installation cancelled by user");
            }
            else
            {
                DownloadLogBuilder.AppendLine("Installation complete, press Next to continue.");

                if (Installer.DesktopShortcutCheckBox.Checked)
                    Installer.CreateShortcut();

                Installer.NextBtn.Enabled = true;
            }

            Installer.InstallLogBox.AppendText(DownloadLogBuilder.ToString());
        }
    }
}

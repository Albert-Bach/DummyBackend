﻿namespace InstallerBackend.Model
{
    public class Technology
    {
        public string Focus { get; set; }
        public string Name { get; set; }
        public string DownloadUrl { get; set; }
        public string FileName { get; set; }
        public string VersionNumber { get; set; }
        public string InstallString { get; set; }
        public string UninstallString { get; set; }

        public Technology(string focus, string name, string downloadUrl, string fileName, string versionNumber, string installString, string uninstallString)
        {
            Focus = focus;
            Name = name;
            DownloadUrl = downloadUrl;
            FileName = fileName;
            VersionNumber = versionNumber;
            InstallString = installString;
            UninstallString = uninstallString;
        }
    }
}

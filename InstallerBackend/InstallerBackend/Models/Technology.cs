namespace InstallerBackend.Model
{
    public class Technology
    {
        public string Focus { get; set; }
        public string Name { get; set; }
        public string DownloadUrl { get; set; }
        public string VersionNumber { get; set; }
        public string InstallString { get; set; }

        public Technology(string focus, string name, string downloadUrl, string versionNumber, string installString)
        {
            Focus = focus;
            Name = name;
            DownloadUrl = downloadUrl;
            VersionNumber = versionNumber;
            InstallString = installString;
        }
    }
}

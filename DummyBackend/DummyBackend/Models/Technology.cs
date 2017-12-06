using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyBackend.Model
{
    public class Technology
    {
        public string Focus { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Version { get; set; }
        public string InstallString { get; set; }

        public Technology(string focus, string name, string url, string version, string installString)
        {
            Focus = focus;
            Name = name;
            Url = url;
            Version = version;
            InstallString = installString;
        }
    }
}

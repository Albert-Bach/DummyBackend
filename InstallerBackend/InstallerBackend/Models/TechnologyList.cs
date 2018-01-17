using System.Collections.Generic;
using System.Linq;

namespace InstallerBackend.Model
{
    public class TechnologyList
    { 

        public List<Technology> TechList { get; set; } = new List<Technology>
        {
            new Technology("c#", "Visual Studio", "https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15#", "vs.exe" , null, "installstring", null),
            new Technology("c#", "Python", "https://www.python.org/ftp/python/3.6.4/python-3.6.4.exe", "python.exe" , null, "/s InstallAllUsers=1 PrependPath=1", null),
            new Technology("java", "IntelliJ IDEA", "https://www.jetbrains.com/idea/download/#section=windows", "ii.exe" , null, "installstring", null),
            new Technology("java", "javaSDK", "http://download.oracle.com/otn-pub/java/jdk/9.0.4+11/c2514751926b4512b076cc82f959763f/jdk-9.0.4_windows-x64_bin.exe", "jdk.exe" , null, $"/s ADDLOCAL=\"ToolsFeature,SourceFeature,PublicjreFeature\"", null),
            new Technology("javascript", "Python", "https://www.python.org/ftp/python/3.6.4/python-3.6.4.exe", "python.exe" , null, "/quiet InstallAllUsers=1 PrependPath=1", null),
            new Technology("javascript", "NotePad", "https://www.greenfoxacademy.com/", "notepad.exe" , null, "installstring", null),
            new Technology("c++", "GCC/c++", "https://www.greenfoxacademy.com/", "gc.exe" , null, "installstring", null),
            new Technology("c++", "GCC/c++", "https://www.greenfoxacademy.com/", "gc.exe", null, "installstring", null)
        };

        public List<Technology> FilterFocus(string focus)
        {
            return TechList.FindAll(technology => technology.Focus == focus);
        }
    }
}
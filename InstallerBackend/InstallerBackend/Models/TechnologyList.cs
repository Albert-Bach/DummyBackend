using System.Collections.Generic;
using System.Linq;

namespace InstallerBackend.Model
{
    public class TechnologyList
    {
        public List<Technology> TechList { get; set; } = new List<Technology>
        {
            new Technology("c#", "Visual Studio", "https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15#", "vs.exe" , "15.5.27130.2010", "installstring", null),
            new Technology("c#", "Python", "https://www.python.org/ftp/python/3.6.4/python-3.6.4.exe", "python.exe" , "3.6.6032.0", "/quiet InstallAllUsers=1 PrependPath=1", null),
            new Technology("java", "IntelliJ IDEA", "https://www.jetbrains.com/idea/download/#section=windows", "ii.exe" , "1.1.8", "installstring", null),
            new Technology("java", "IntelliJ IDEA", "https://www.jetbrains.com/idea/download/#section=windows", "ii.exe" , "1.1.8", "installstring", null),
            new Technology("javascript", "Python", "https://www.python.org/ftp/python/3.6.4/python-3.6.4.exe", "python.exe" , "3.6.6032.0", "/quiet InstallAllUsers=1 PrependPath=1", null),
            new Technology("javascript", "NotePad", "https://www.greenfoxacademy.com/", "notepad.exe" , "1.1.9", "installstring", null),
            new Technology("c++", "GCC/c++", "https://www.greenfoxacademy.com/", "gc.exe" , "1.1.9", "installstring", null),
            new Technology("c++", "GCC/c++", "https://www.greenfoxacademy.com/", "gc.exe", "1.1.9", "installstring", null)
        };

        public List<Technology> FilterFocus(string focus)
        {
            return TechList.FindAll(technology => technology.Focus == focus);
        }
    }
}
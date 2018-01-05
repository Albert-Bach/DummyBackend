using System.Collections.Generic;
using System.Linq;

namespace InstallerBackend.Model
{
    public class TechnologyList
    {
        public List<Technology> TechList { get; set; } = new List<Technology>
        {
            new Technology("c#", "Visual Studio", "https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15#", "15.5.27130.2010", "installstring"),
            new Technology("c#", "Python", "https://www.python.org/ftp/python/3.6.4/python-3.6.4.exe", "3.6.4", "installstring"),
            new Technology("java", "IntelliJ IDEA", "https://www.jetbrains.com/idea/download/#section=windows", "1.1.8", "installstring"),
            new Technology("java", "IntelliJ IDEA", "https://www.jetbrains.com/idea/download/#section=windows", "1.1.8", "installstring"),
            new Technology("javascript", "Python", "https://www.python.org/ftp/python/3.6.4/python-3.6.4.exe", "3.6.4", "installstring"),
            new Technology("javascript", "NotePad", "https://www.greenfoxacademy.com/", "1.1.9", "installstring"),
            new Technology("hardware", "GCC/c++", "https://www.greenfoxacademy.com/", "1.1.9", "installstring"),
            new Technology("hardware", "GCC/c++", "https://www.greenfoxacademy.com/", "1.1.9", "installstring")
        };

        public List<Technology> FilterFocus(string focus)
        {
            return TechList.FindAll(technology => technology.Focus == focus);
        }

        //public Technology FilterFocus(string focus)
        //{
        //    return TechList.FirstOrDefault(technology => technology.Focus == focus);
        //}
    }
}
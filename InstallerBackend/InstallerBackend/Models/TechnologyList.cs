using System.Collections.Generic;
using System.Linq;

namespace InstallerBackend.Model
{
    public class TechnologyList
    {
        public List<Technology> TechList { get; set; } = new List<Technology>
        {
            new Technology("c#", "Visual Studio", "https://www.visualstudio.com/thank-you-downloading-visual-studio/", "1.1.7", "installstring"),
            new Technology("java", "NetBeans", "https://netbeans.org/downloads/", "1.1.8", "installstring"),
            new Technology("javascript", "NotePad", "https://www.greenfoxacademy.com/", "1.1.9", "installstring")
        };

        public Technology FilterFocus(string focus)
        {
            return TechList.FirstOrDefault(technology => technology.Focus == focus);
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace InstallerBackend.Model
{
    public class TechnologyList
    {
        public List<Technology> TechList { get; set; } = new List<Technology>
        {
            new Technology("c#", "Visual Studio", "https://www.visualstudio.com/thank-you-downloading-visual-studio/", "1.1.7", "installstring"),
            new Technology("c#", "Visual Studio", "https://www.visualstudio.com/thank-you-downloading-visual-studio/", "1.1.7", "installstring"),
            new Technology("java", "IntelliJ IDEA", "https://www.jetbrains.com/idea/download/#section=windows", "1.1.8", "installstring"),
            new Technology("java", "IntelliJ IDEA", "https://www.jetbrains.com/idea/download/#section=windows", "1.1.8", "installstring"),
            new Technology("javascript", "NotePad", "https://www.greenfoxacademy.com/", "1.1.9", "installstring"),
            new Technology("javascript", "NotePad", "https://www.greenfoxacademy.com/", "1.1.9", "installstring"),
            new Technology("hardware", "GCC/c++", "https://www.greenfoxacademy.com/", "1.1.9", "installstring"),
            new Technology("hardware", "GCC/c++", "https://www.greenfoxacademy.com/", "1.1.9", "installstring")
        };

        public List<Technology> FilterFocus(string focus)
        {
            return TechList.FindAll(technology => technology.Focus == focus);
        }
    }
}
using InstallerBackend.Model;
using Microsoft.AspNetCore.Mvc;

namespace InstallerBackend.Controllers
{
    [Route("")]
    public class RestController : Controller
    {
        TechnologyList technologyList;

        public RestController(TechnologyList technologyList)
        {
            this.technologyList = technologyList;
        }

        [HttpGet]
        [Route("/query")]
        public IActionResult ListTechnology([FromQuery] string technologyfocus)
        {
            if (technologyfocus == "c#" || technologyfocus == "java" || technologyfocus == "javascript" || technologyfocus == "c++")
            {
                return Json (technologyList.FilterFocus(technologyfocus));
            }
            
            return Json(new { result = "error", error = "Wrong query!" });
        }
    }
}

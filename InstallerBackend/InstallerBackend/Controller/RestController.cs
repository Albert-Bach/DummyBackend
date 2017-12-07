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
        public IActionResult ListTechnology([FromQuery] string focus)
        {
            if (focus == "c#")
            {
                return Json(new { result = "ok", data = technologyList.FilterFocus(focus) });
            }
            else if (focus == "java")
            {
                return Json(new { result = "ok", data = technologyList.FilterFocus(focus) });
            }
            else if (focus == "javascript")
            {
                return Json(new { result = "ok", data = technologyList.FilterFocus(focus) });
            }
            else

                return Json(new { result = "error", error = "Wrong query!" });
        }
    }
}

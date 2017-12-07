using DummyBackend.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyBackend.Controllers
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

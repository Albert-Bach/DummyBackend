using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyBackend.Controllers
{
    public class RestController : Controller
    {
        [HttpGet]
        [Route("/query")]
        public IActionResult ListTechnology([FromQuery] string focus)
        {
            if (focus == "c#")
            {
                return Json(new { result = "ok" });
            }
            else if (focus == "java")
            {
                return Json(new { result = "ok",  });
            }
            else if (focus == "javascript")
            {
                return Json(new { result = "ok", });
            }
            else

                return Json(new { result = "error", error = "Wrong query!" });
        }
    }
}

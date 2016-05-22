using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Picturra.com.Controllers
{
    public class UploadController : Controller
    {
        public JsonResult Upload()
        {

            return Json(new { test = "test" });
        }

    }
}
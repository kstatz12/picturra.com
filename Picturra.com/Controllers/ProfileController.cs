using System;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Picturra.Models.Profile;

namespace Picturra.com.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            var model = new Profile();
            return View(model);
        }
        [HttpPost]
        public JsonResult Save(Profile profile)
        {
            var loginId = Guid.Parse(User.Identity.GetUserId());
            profile.LogindId = loginId;

            return Json(new {Message = "Ok"});
        }

    }
}
using System.Web.Mvc;
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

    }
}
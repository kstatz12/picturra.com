using System.Web.Mvc;
using Newtonsoft.Json;
using Picturra.Models.Profile;

namespace Picturra.com.Controllers
{
    public class ContactController : Controller
    {
        public string GetContactInformation()
        {
            return JsonConvert.SerializeObject(new Contact());
        }

        public string SaveContactInformation()
        {
            return string.Empty;
        }
    }
}
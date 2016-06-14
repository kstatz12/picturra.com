using System.Web.Mvc;
using Newtonsoft.Json;
using Picturra.Models.Profile;
namespace Picturra.com.Controllers
{
    public class PortfolioController : Controller
    {
        public string GetPortfolio()
        {
            return JsonConvert.SerializeObject(new Porftolio());
        }
    }
}
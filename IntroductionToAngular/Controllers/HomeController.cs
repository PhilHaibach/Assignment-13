using System.Web.Mvc;
using IntroductionToAngular.Extensions;
using System.Collections.Generic;

namespace IntroductionToAngular.Controllers
{
    public class HomeController : Controller
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public ActionResult Index()
        {
            return View();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        public JsonResult GetBattingOrder()
        {
            return new JsonResult().SerializeObject(new
            {
                BattingOrder = new[] {
                    new { FirstName = "Kenny" , LastName = "Lofton" , playerNumber = 7},
                    new { FirstName = "Omar" , LastName = "Vizquel" , playerNumber = 13},
                    new { FirstName = "Carlos" , LastName = "Baerga" , playerNumber = 9},
                    new { FirstName = "Albert" , LastName = "Belle" , playerNumber = 8},
                    new { FirstName = "Eddie" , LastName = "Murray" , playerNumber = 33},
                    new { FirstName = "Jim" , LastName = "Thome" , playerNumber = 25},
                    new { FirstName = "Manny" , LastName = "Ramirez" , playerNumber = 24},
                    new { FirstName = "Paul" , LastName = "Sorrento" , playerNumber = 11},
                    new { FirstName = "Sandy" , LastName = "Alomar" , playerNumber = 15}
                }
            });
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
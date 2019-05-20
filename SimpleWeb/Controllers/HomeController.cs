
using System.Linq;
using System.Web.Mvc;

namespace SimpleWeb.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index() => View(new MainViewModel());

        [HttpPost]
        public ActionResult Race(MainViewModel model)
        {
            var data = Cache.GetPeople();
            var people = data.Where(x => x.Race == model.Race && x.Age % 2 == 0).OrderBy(x => x.Age).ToList();
            model.People = people;
            return View("Index", model);
        }
    }
}
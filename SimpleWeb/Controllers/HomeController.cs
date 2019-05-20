
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;

using SimpleWeb.Data;
using SimpleWeb.Entities;

namespace SimpleWeb.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new MainViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Race(MainViewModel model)
        {
            var data = GetCachedData();
            var people = data.Where(x => x.Race == model.Race && x.Age % 2 == 0).OrderBy(x => x.Age).ToList();
            model.People = people;
            return View("Index", model);
        }

        private List<Person> GetCachedData()
        {
            var cacheKey = "CachedPeople";
            List<Person> people = WebCache.Get(cacheKey);

            if (people == null)
            {
                people = PeopleRepository.InitPeople();
                WebCache.Set(cacheKey, people, 1, false);
            }

            return people;
        }
    }
}
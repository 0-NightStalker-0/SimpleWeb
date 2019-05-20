
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using PagedList;

using SimpleWeb.Entities;

namespace SimpleWeb.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        private const int PeoplePerPage = 10;

        public ActionResult Index(string race, int? page)
        {
            var model = new MainViewModel();

            List<Person> people = new List<Person>();

            if (!string.IsNullOrEmpty(race))
            {
                model.Race = race;

                var data = Cache.GetPeople();
                people = data.Where(x => x.Race.ToString() == race && x.Age % 2 == 0).OrderBy(x => x.Age).ToList();
            }

            model.OnePageOfPeople = people.ToPagedList(page ?? 1, PeoplePerPage);

            return View(model);
        }
    }
}
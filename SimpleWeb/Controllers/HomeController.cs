using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SimpleWeb.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public static List<Person> InitPeople()
        {
            List<Person> people = new List<Person>();
            Random ageRnd = new Random();
            Random raceRnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                people.Add(new Person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = ageRnd.Next(1, 99),
                    Race = (Race)ageRnd.Next(1, 4)
                });
            }

            return people;
        }
    }
}
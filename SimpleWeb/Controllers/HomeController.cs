using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SimpleWeb.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public static List<Person> InitPeople()
        {
            List<Person> people = new List<Person>();
            Random rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                people.Add(new Person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = rnd.Next(1, 99)
                });
            }

            return people;
        }
    }
}
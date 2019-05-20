
using System.Linq;
using System.Web.Http;

using SimpleWeb.Entities;

namespace SimpleWeb.Controllers
{
    public class StatusController : ApiController
    {
        public IHttpActionResult Get()
        {
            var people = Cache.GetPeople();

            var number = people.Count;
            var avgAge = people.Sum(x => x.Age) / number;
            var minAge = people.Min(x => x.Age);
            var maxAge = people.Max(x => x.Age);
            var angles = people.Where(x => x.Race == Race.Angles).Count();
            var saxons = people.Where(x => x.Race == Race.Saxons).Count();
            var jutes = people.Where(x => x.Race == Race.Jutes).Count();
            var hawaiian = people.Where(x => x.Race == Race.Hawaiian).Count();

            var status = new { number, avgAge, minAge, maxAge, angles, saxons, jutes, hawaiian };
            return Json(status);
        }
    }
}


using System.Collections.Generic;
using System.Web.Helpers;

using SimpleWeb.Data;
using SimpleWeb.Entities;

namespace SimpleWeb
{
    public class Cache
    {
        public static List<Person> GetPeople()
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
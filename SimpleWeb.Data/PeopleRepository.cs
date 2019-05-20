using System;
using System.Collections.Generic;

using SimpleWeb.Entities;

namespace SimpleWeb.Data
{
    public class PeopleRepository
    {
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
                    Race = (Race)ageRnd.Next(1, 5)
                });
            }

            return people;
        }

        public static void Add1Year(IEnumerable<Person> persons)
        {
            foreach (var person in persons)
            {
                person.Age += 1;
            }
        }
    }
}

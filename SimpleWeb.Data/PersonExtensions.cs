
using SimpleWeb.Entities;

namespace SimpleWeb.Data
{
    public static class PersonExtensions
    {
        public static double Height(this Person person)
        {
            switch (person.Race)
            {
                case Race.Angles:
                case Race.Saxons:
                    return 1.5 + (person.Age * 0.45);

                case Race.Jutes:
                    return person.Age * 1.6 / 2;

                case Race.Hawaiian:
                    return 1.7 + ((person.Age + 2) * 0.23);

                default:
                    return 0;
            }
        }
    }
}

using Postgres.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Postgres.Persistance
{
    public class FrcContextInitializer
    {
        public static void Initialize(FrcContext context)
        {
            var initializer = new FrcContextInitializer();
            initializer.SeedEverything(context);
        }

        private void SeedEverything(FrcContext context)
        {
            context.Database.EnsureCreated();

            if (context.Events.Any())
            {
                return; // Db has been seeded
            }

            SeedIdentities(context);
            SeedAggregatedEvents(context);
            SeedEvents(context);
        }

        private void SeedAggregatedEvents(FrcContext context)
        {
            Random rand = new Random();
            var bytes = new byte[256];
            List<AggregatedEvents> events = new List<AggregatedEvents>();
            for (int i = 0; i < 100; i++)
            {
                rand.NextBytes(bytes);

                var aggregatedEvent = new AggregatedEvents()
                {
                    BestImage = bytes,
                    IdentityId = rand.Next(0, 100).ToString(),
                    Recognized = true,
                    TimestampStart = DateTime.Now,
                    TimestampEnd = DateTime.Now.AddSeconds(100),
                    CameraId = "StreetCamera"
                };
                events.Add(aggregatedEvent);
            }

            context.AggregatedEvents.AddRange(events);
            context.SaveChanges();
        }

        private void SeedIdentities(FrcContext context)
        {
            var data = new[] {
                new Identity{ FirstName = "Thaddeus", LastName = "Shannon", Age = 76, Gender = 0 },
                new Identity{ FirstName = "Justine", LastName = "Nash", Age = 51, Gender = 0 },
                new Identity{ FirstName = "Ira", LastName = "Walsh", Age = 35, Gender = 1 },
                new Identity{ FirstName = "Daquan", LastName = "Jensen", Age = 80, Gender = 0 },
                new Identity{ FirstName = "Shea", LastName = "Mcintyre", Age = 16, Gender = 0 },
                new Identity{ FirstName = "Uriah", LastName = "Morse", Age = 94, Gender = 0 },
                new Identity{ FirstName = "Neve", LastName = "Rodgers", Age = 42, Gender = 0 },
                new Identity{ FirstName = "Anika", LastName = "Hoffman", Age = 17, Gender = 0 },
                new Identity{ FirstName = "Geraldine", LastName = "Stanley", Age = 17, Gender = 0 },
                new Identity{ FirstName = "Eugenia", LastName = "Dale", Age = 43, Gender = 0 },
                new Identity{ FirstName = "Maxwell", LastName = "Gallegos", Age = 68, Gender = 1 },
                new Identity{ FirstName = "Timon", LastName = "Cain", Age = 99, Gender = 0 },
                new Identity{ FirstName = "James", LastName = "Bush", Age = 20, Gender = 0 },
                new Identity{ FirstName = "Joy", LastName = "Hopper", Age = 82, Gender = 0 },
                new Identity{ FirstName = "Wynter", LastName = "Farrell", Age = 30, Gender = 0 },
                new Identity{ FirstName = "Judith", LastName = "Sharpe", Age = 42, Gender = 1 },
                new Identity{ FirstName = "Bernard", LastName = "Duran", Age = 68, Gender = 1 },
                new Identity{ FirstName = "Aquila", LastName = "Dale", Age = 17, Gender = 0 },
                new Identity{ FirstName = "Leo", LastName = "Dominguez", Age = 36, Gender = 1 },
                new Identity{ FirstName = "Dalton", LastName = "Walter", Age = 85, Gender = 0 },
                new Identity{ FirstName = "Kelly", LastName = "Henry", Age = 74, Gender = 0 },
                new Identity{ FirstName = "Aimee", LastName = "Joyner", Age = 78, Gender = 1 },
                new Identity{ FirstName = "Priscilla", LastName = "Lynch", Age = 69, Gender = 1 },
                new Identity{ FirstName = "Aspen", LastName = "Sykes", Age = 81, Gender = 0 },
                new Identity{ FirstName = "Flavia", LastName = "Gray", Age = 98, Gender = 0 },
                new Identity{ FirstName = "Griffin", LastName = "Gamble", Age = 68, Gender = 1 },
                new Identity{ FirstName = "Carson", LastName = "Brady", Age = 91, Gender = 1 },
                new Identity{ FirstName = "Hashim", LastName = "Pacheco", Age = 31, Gender = 0 },
                new Identity{ FirstName = "Rafael", LastName = "Mccarthy", Age = 70, Gender = 0 },
                new Identity{ FirstName = "Upton", LastName = "Ewing", Age = 21, Gender = 0 },
                new Identity{ FirstName = "Xenos", LastName = "Gillespie", Age = 98, Gender = 0 },
                new Identity{ FirstName = "Neville", LastName = "Fry", Age = 88, Gender = 1 },
                new Identity{ FirstName = "Maya", LastName = "Dennis", Age = 59, Gender = 0 },
                new Identity{ FirstName = "Maile", LastName = "Horton", Age = 73, Gender = 0 },
                new Identity{ FirstName = "Omar", LastName = "Fuller", Age = 46, Gender = 1 },
                new Identity{ FirstName = "Keely", LastName = "Harper", Age = 24, Gender = 1 },
                new Identity{ FirstName = "Kimberly", LastName = "Simpson", Age = 71, Gender = 0 },
                new Identity{ FirstName = "Ingrid", LastName = "Savage", Age = 28, Gender = 1 },
                new Identity{ FirstName = "Abraham", LastName = "Fitzpatrick", Age = 45, Gender = 0 },
                new Identity{ FirstName = "Rosalyn", LastName = "Morgan", Age = 80, Gender = 0 },
                new Identity{ FirstName = "Scarlet", LastName = "Wolfe", Age = 52, Gender = 1 },
                new Identity{ FirstName = "Dane", LastName = "Perry", Age = 81, Gender = 1 },
                new Identity{ FirstName = "Lareina", LastName = "Lane", Age = 88, Gender = 0 },
                new Identity{ FirstName = "Derek", LastName = "Bowers", Age = 46, Gender = 1 },
                new Identity{ FirstName = "Prescott", LastName = "Murray", Age = 38, Gender = 0 },
                new Identity{ FirstName = "Penelope", LastName = "Fernandez", Age = 48, Gender = 1 },
                new Identity{ FirstName = "Anastasia", LastName = "Salinas", Age = 32, Gender = 0 },
                new Identity{ FirstName = "Kylie", LastName = "Drake", Age = 20, Gender = 1 },
                new Identity{ FirstName = "Dillon", LastName = "Beard", Age = 41, Gender = 0 },
                new Identity{ FirstName = "Walker", LastName = "Mills", Age = 95, Gender = 0 },
                new Identity{ FirstName = "Murphy", LastName = "Ramsey", Age = 56, Gender = 0 },
                new Identity{ FirstName = "Hoyt", LastName = "Cherry", Age = 59, Gender = 1 },
                new Identity{ FirstName = "Griffin", LastName = "Gates", Age = 43, Gender = 0 },
                new Identity{ FirstName = "Lewis", LastName = "Mcneil", Age = 25, Gender = 1 },
                new Identity{ FirstName = "Macaulay", LastName = "Cunningham", Age = 64, Gender = 0 },
                new Identity{ FirstName = "Hector", LastName = "Dale", Age = 59, Gender = 0 },
                new Identity{ FirstName = "Darrel", LastName = "Johns", Age = 16, Gender = 1 },
                new Identity{ FirstName = "Benjamin", LastName = "Vaughn", Age = 38, Gender = 1 },
                new Identity{ FirstName = "Desirae", LastName = "Sampson", Age = 57, Gender = 0 },
                new Identity{ FirstName = "Linus", LastName = "Baird", Age = 46, Gender = 1 },
                new Identity{ FirstName = "Riley", LastName = "Snow", Age = 67, Gender = 0 },
                new Identity{ FirstName = "Jerry", LastName = "May", Age = 87, Gender = 0 },
                new Identity{ FirstName = "Abbot", LastName = "Hammond", Age = 71, Gender = 0 },
                new Identity{ FirstName = "Russell", LastName = "Valdez", Age = 35, Gender = 1 },
                new Identity{ FirstName = "Quemby", LastName = "Mooney", Age = 25, Gender = 0 },
                new Identity{ FirstName = "Aubrey", LastName = "Norman", Age = 66, Gender = 0 },
                new Identity{ FirstName = "Tatyana", LastName = "Macias", Age = 85, Gender = 1 },
                new Identity{ FirstName = "Diana", LastName = "Osborne", Age = 88, Gender = 1 },
                new Identity{ FirstName = "Salvador", LastName = "Ingram", Age = 62, Gender = 1 },
                new Identity{ FirstName = "Jocelyn", LastName = "Craig", Age = 31, Gender = 0 },
                new Identity{ FirstName = "Pamela", LastName = "Lee", Age = 34, Gender = 1 },
                new Identity{ FirstName = "Kiara", LastName = "Suarez", Age = 39, Gender = 1 },
                new Identity{ FirstName = "Allistair", LastName = "Maynard", Age = 28, Gender = 1 },
                new Identity{ FirstName = "Russell", LastName = "Burke", Age = 56, Gender = 0 },
                new Identity{ FirstName = "Althea", LastName = "Mcfarland", Age = 94, Gender = 0 },
                new Identity{ FirstName = "Palmer", LastName = "Brock", Age = 67, Gender = 0 },
                new Identity{ FirstName = "Galvin", LastName = "Atkinson", Age = 92, Gender = 1 },
                new Identity{ FirstName = "Wade", LastName = "Summers", Age = 71, Gender = 1 },
                new Identity{ FirstName = "Rafael", LastName = "Dillard", Age = 87, Gender = 0 },
                new Identity{ FirstName = "Patricia", LastName = "King", Age = 81, Gender = 0 },
                new Identity{ FirstName = "Dillon", LastName = "Hodge", Age = 69, Gender = 1 },
                new Identity{ FirstName = "Axel", LastName = "Farrell", Age = 64, Gender = 0 },
                new Identity{ FirstName = "Ira", LastName = "Roberts", Age = 71, Gender = 1 },
                new Identity{ FirstName = "Linus", LastName = "Ayala", Age = 75, Gender = 0 },
                new Identity{ FirstName = "Shea", LastName = "Dale", Age = 48, Gender = 1 },
                new Identity{ FirstName = "Francesca", LastName = "Cohen", Age = 19, Gender = 1 },
                new Identity{ FirstName = "Oscar", LastName = "Douglas", Age = 81, Gender = 1 },
                new Identity{ FirstName = "Elaine", LastName = "Matthews", Age = 38, Gender = 0 },
                new Identity{ FirstName = "Paul", LastName = "Norman", Age = 31, Gender = 1 },
                new Identity{ FirstName = "Thaddeus", LastName = "Johnston", Age = 46, Gender = 1 },
                new Identity{ FirstName = "Portia", LastName = "Guthrie", Age = 90, Gender = 0 },
                new Identity{ FirstName = "Zelda", LastName = "Romero", Age = 58, Gender = 0 },
                new Identity{ FirstName = "Grant", LastName = "Anderson", Age = 57, Gender = 1 },
                new Identity{ FirstName = "Patience", LastName = "Tanner", Age = 51, Gender = 1 },
                new Identity{ FirstName = "Uma", LastName = "Solis", Age = 27, Gender = 1 },
                new Identity{ FirstName = "Ivana", LastName = "Reese", Age = 37, Gender = 1 },
                new Identity{ FirstName = "Kasper", LastName = "Shaffer", Age = 81, Gender = 1 },
                new Identity{ FirstName = "Molly", LastName = "Fischer", Age = 48, Gender = 1 },
                new Identity{ FirstName = "Kendall", LastName = "Chavez", Age = 62, Gender = 1 },
                new Identity{ FirstName = "Cameran", LastName = "Burns", Age = 80, Gender = 1 }
            };

            context.Identities.AddRange(data);
            context.SaveChanges();
        }

        private void SeedEvents(FrcContext context)
        {
            Random rand = new Random();
            var events = new List<FrcEvent>();
            for (int i = 0; i < 1000; i++)
            {
                var bytes = new byte[256];
                rand.NextBytes(bytes);
                events.Add(new FrcEvent()

                {
                    Confidence = "{\"psn_arr\": [{\"psn_id\": 9,\"similarity\": 326},{\"psn_id\": 14,\"similarity\": 336},{\"psn_id\": 12,\"similarity\": 401},{\"psn_id\": 35,\"similarity\": 409},{\"psn_id\": 8,\"similarity\": 866}]}",
                    Image = bytes,
                    Rectangle = "{\"test\":[34,34,43,43]}",
                    Timestamp = DateTime.Now,
                    AggregatedEventsId = context.AggregatedEvents.ToList()[i / 10].AggregatedEventsId
                });
            }
            context.Events.AddRange(events);
            context.SaveChanges();
        }
    }
}
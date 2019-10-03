using System;
using System.Collections.Generic;
using System.Linq;
using Postgres.Domain.Entities;

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

            if (context.Events.Any()) return; // Db has been seeded

            SeedIdentities(context);
            SeedAggregatedEvents(context);
            SeedEvents(context);
        }

        private void SeedAggregatedEvents(FrcContext context)
        {
            var rand = new Random();
            var bytes = new byte[256];
            var events = new List<AggregatedEvents>();
            for (var i = 0; i < 100; i++)
            {
                rand.NextBytes(bytes);

                var aggregatedEvent = new AggregatedEvents
                {
                    BestImage = bytes,
                    IdentityId = Guid.NewGuid(),
                    Recognized = true,
                    TimestampStart = DateTime.Now,
                    TimestampEnd = DateTime.Now.AddSeconds(100),
                    CameraId = Guid.NewGuid()
                };
                events.Add(aggregatedEvent);
            }

            context.AggregatedEvents.AddRange(events);
            context.SaveChanges();
        }

        private void SeedIdentities(FrcContext context)
        {
            var rand = new Random();

            var data = new[]
            {
                new Identity
                {
                    FirstName = "Thaddeus", LastName = "Shannon",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 0
                },
                new Identity
                {
                    FirstName = "Justine", LastName = "Nash", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Ira", LastName = "Walsh", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Daquan", LastName = "Jensen", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Shea", LastName = "Mcintyre", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Uriah", LastName = "Morse", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Neve", LastName = "Rodgers", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Anika", LastName = "Hoffman", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Geraldine", LastName = "Stanley",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 0
                },
                new Identity
                {
                    FirstName = "Eugenia", LastName = "Dale", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Maxwell", LastName = "Gallegos",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 1
                },
                new Identity
                {
                    FirstName = "Timon", LastName = "Cain", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "James", LastName = "Bush", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Joy", LastName = "Hopper", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Wynter", LastName = "Farrell", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Judith", LastName = "Sharpe", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Bernard", LastName = "Duran", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Aquila", LastName = "Dale", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Leo", LastName = "Dominguez", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Dalton", LastName = "Walter", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Kelly", LastName = "Henry", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Aimee", LastName = "Joyner", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Priscilla", LastName = "Lynch", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Aspen", LastName = "Sykes", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Flavia", LastName = "Gray", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Griffin", LastName = "Gamble", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Carson", LastName = "Brady", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Hashim", LastName = "Pacheco", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Rafael", LastName = "Mccarthy", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Upton", LastName = "Ewing", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Xenos", LastName = "Gillespie", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Neville", LastName = "Fry", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Maya", LastName = "Dennis", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Maile", LastName = "Horton", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Omar", LastName = "Fuller", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Keely", LastName = "Harper", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Kimberly", LastName = "Simpson",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 0
                },
                new Identity
                {
                    FirstName = "Ingrid", LastName = "Savage", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Abraham", LastName = "Fitzpatrick",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 0
                },
                new Identity
                {
                    FirstName = "Rosalyn", LastName = "Morgan", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Scarlet", LastName = "Wolfe", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Dane", LastName = "Perry", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Lareina", LastName = "Lane", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Derek", LastName = "Bowers", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Prescott", LastName = "Murray", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Penelope", LastName = "Fernandez",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 1
                },
                new Identity
                {
                    FirstName = "Anastasia", LastName = "Salinas",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 0
                },
                new Identity
                {
                    FirstName = "Kylie", LastName = "Drake", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Dillon", LastName = "Beard", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Walker", LastName = "Mills", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Murphy", LastName = "Ramsey", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Hoyt", LastName = "Cherry", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Griffin", LastName = "Gates", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Lewis", LastName = "Mcneil", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Macaulay", LastName = "Cunningham",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 0
                },
                new Identity
                {
                    FirstName = "Hector", LastName = "Dale", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Darrel", LastName = "Johns", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Benjamin", LastName = "Vaughn", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Desirae", LastName = "Sampson", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Linus", LastName = "Baird", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Riley", LastName = "Snow", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Jerry", LastName = "May", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Abbot", LastName = "Hammond", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Russell", LastName = "Valdez", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Quemby", LastName = "Mooney", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Aubrey", LastName = "Norman", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Tatyana", LastName = "Macias", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Diana", LastName = "Osborne", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Salvador", LastName = "Ingram", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Jocelyn", LastName = "Craig", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Pamela", LastName = "Lee", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Kiara", LastName = "Suarez", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Allistair", LastName = "Maynard",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 1
                },
                new Identity
                {
                    FirstName = "Russell", LastName = "Burke", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Althea", LastName = "Mcfarland",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 0
                },
                new Identity
                {
                    FirstName = "Palmer", LastName = "Brock", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Galvin", LastName = "Atkinson", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Wade", LastName = "Summers", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Rafael", LastName = "Dillard", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Patricia", LastName = "King", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Dillon", LastName = "Hodge", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Axel", LastName = "Farrell", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Ira", LastName = "Roberts", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Linus", LastName = "Ayala", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Shea", LastName = "Dale", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Francesca", LastName = "Cohen", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Oscar", LastName = "Douglas", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Elaine", LastName = "Matthews", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Paul", LastName = "Norman", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Thaddeus", LastName = "Johnston",
                    BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)), Gender = 1
                },
                new Identity
                {
                    FirstName = "Portia", LastName = "Guthrie", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Zelda", LastName = "Romero", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 0
                },
                new Identity
                {
                    FirstName = "Grant", LastName = "Anderson", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Patience", LastName = "Tanner", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Uma", LastName = "Solis", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Ivana", LastName = "Reese", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Kasper", LastName = "Shaffer", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Molly", LastName = "Fischer", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Kendall", LastName = "Chavez", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                },
                new Identity
                {
                    FirstName = "Cameran", LastName = "Burns", BirthDate = DateTime.Now.AddYears(rand.Next(-70, -10)),
                    Gender = 1
                }
            };

            context.Identities.AddRange(data);
            context.SaveChanges();
        }

        private void SeedEvents(FrcContext context)
        {
            var rand = new Random();
            var events = new List<FrcEvent>();
            for (var i = 0; i < 1000; i++)
            {
                var bytes = new byte[256];
                rand.NextBytes(bytes);
                events.Add(new FrcEvent
                {
                    Confidence =
                        "{\"psn_arr\": [{\"psn_id\": 9,\"similarity\": 326},{\"psn_id\": 14,\"similarity\": 336},{\"psn_id\": 12,\"similarity\": 401},{\"psn_id\": 35,\"similarity\": 409},{\"psn_id\": 8,\"similarity\": 866}]}",
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
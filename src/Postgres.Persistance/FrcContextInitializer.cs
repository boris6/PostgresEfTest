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
                    IdentityId = rand.Next(0, 100),
                    Recognized = true,
                    TimestampStart = DateTime.Now,
                    TimestampEnd = DateTime.Now.AddSeconds(100)
                };
                events.Add(aggregatedEvent);
            }

            context.AggregatedEvents.AddRange(events);
            context.SaveChanges();
        }

        private void SeedIdentities(FrcContext context)
        {
            var data = new[]
{
                new Identity {Name = "Garrison Trujillo", Age = 45},
                new Identity {Name = "Burke Pierce", Age = 98},
                new Identity {Name = "Scarlet Mcgowan", Age = 67},
                new Identity {Name = "Ori Chen", Age = 78},
                new Identity {Name = "Ima Gardner", Age = 88},
                new Identity {Name = "Norman Bond", Age = 89},
                new Identity {Name = "Kay Jensen", Age = 80},
                new Identity {Name = "Aaron Saunders", Age = 17},
                new Identity {Name = "Alfreda Bray", Age = 87},
                new Identity {Name = "Montana Gonzales", Age = 99},
                new Identity {Name = "Lee Simmons", Age = 26},
                new Identity {Name = "Sopoline Mcdaniel", Age = 39},
                new Identity {Name = "Lionel Higgins", Age = 53},
                new Identity {Name = "Katell Cervantes", Age = 95},
                new Identity {Name = "Tate Logan", Age = 80},
                new Identity {Name = "Armando Osborn", Age = 88},
                new Identity {Name = "Allegra Baldwin", Age = 81},
                new Identity {Name = "Jarrod Jefferson", Age = 30},
                new Identity {Name = "Justine Fletcher", Age = 32},
                new Identity {Name = "Zena Wade", Age = 41},
                new Identity {Name = "Zorita Cotton", Age = 27},
                new Identity {Name = "Yoshio Floyd", Age = 49},
                new Identity {Name = "Harriet Mann", Age = 71},
                new Identity {Name = "Ryder Young", Age = 90},
                new Identity {Name = "Rudyard Navarro", Age = 26},
                new Identity {Name = "Zeph Pena", Age = 68},
                new Identity {Name = "Duncan Barlow", Age = 78},
                new Identity {Name = "Eric Ayala", Age = 99},
                new Identity {Name = "Darius Pena", Age = 59},
                new Identity {Name = "Logan Everett", Age = 88},
                new Identity {Name = "Rose Higgins", Age = 22},
                new Identity {Name = "Benjamin Carrillo", Age = 12},
                new Identity {Name = "Brynne Patel", Age = 19},
                new Identity {Name = "Neve Rivas", Age = 20},
                new Identity {Name = "Quintessa Fitzpatrick", Age = 74},
                new Identity {Name = "Logan Lowe", Age = 86},
                new Identity {Name = "Rylee Pate", Age = 13},
                new Identity {Name = "Kamal Young", Age = 35},
                new Identity {Name = "Delilah Hinton", Age = 73},
                new Identity {Name = "Urielle Reeves", Age = 64},
                new Identity {Name = "Elton Banks", Age = 78},
                new Identity {Name = "Veronica Bennett", Age = 85},
                new Identity {Name = "Thomas Sweet", Age = 55},
                new Identity {Name = "Raphael Wyatt", Age = 95},
                new Identity {Name = "Carlos Short", Age = 96},
                new Identity {Name = "Sheila Hess", Age = 70},
                new Identity {Name = "Nissim Stephenson", Age = 63},
                new Identity {Name = "Alden Sexton", Age = 70},
                new Identity {Name = "Ian Howard", Age = 90},
                new Identity {Name = "Kato Holt", Age = 66},
                new Identity {Name = "Marcia Richards", Age = 80},
                new Identity {Name = "Emerald Hoover", Age = 96},
                new Identity {Name = "Irma Stout", Age = 70},
                new Identity {Name = "Demetria Valentine", Age = 65},
                new Identity {Name = "Cedric Hines", Age = 12},
                new Identity {Name = "Quentin Kidd", Age = 58},
                new Identity {Name = "Nash Carpenter", Age = 21},
                new Identity {Name = "Keith Conley", Age = 34},
                new Identity {Name = "Sacha Sharpe", Age = 26},
                new Identity {Name = "Daria Mathews", Age = 74},
                new Identity {Name = "Xander Merritt", Age = 79},
                new Identity {Name = "Jaime Lloyd", Age = 51},
                new Identity {Name = "Noel Kidd", Age = 47},
                new Identity {Name = "Ivy Hardy", Age = 93},
                new Identity {Name = "Yuri Green", Age = 27},
                new Identity {Name = "Tashya Parks", Age = 59},
                new Identity {Name = "Honorato Whitley", Age = 38},
                new Identity {Name = "Roanna Aguirre", Age = 86},
                new Identity {Name = "Meredith Kelley", Age = 54},
                new Identity {Name = "Gage Hardy", Age = 39},
                new Identity {Name = "Jarrod Hines", Age = 84},
                new Identity {Name = "Heather Boyle", Age = 82},
                new Identity {Name = "Winifred Albert", Age = 34},
                new Identity {Name = "Kennedy Jordan", Age = 61},
                new Identity {Name = "Jacob Peterson", Age = 34},
                new Identity {Name = "Chloe Finch", Age = 20},
                new Identity {Name = "Blair Kline", Age = 73},
                new Identity {Name = "Yasir Good", Age = 38},
                new Identity {Name = "Nissim Haynes", Age = 82},
                new Identity {Name = "Jane Stark", Age = 80},
                new Identity {Name = "Chava Farrell", Age = 84},
                new Identity {Name = "Joel Harrington", Age = 49},
                new Identity {Name = "Roary Patton", Age = 77},
                new Identity {Name = "Gretchen Charles", Age = 76},
                new Identity {Name = "Meghan Ballard", Age = 86},
                new Identity {Name = "Dana Valencia", Age = 15},
                new Identity {Name = "Arsenio Thompson", Age = 53},
                new Identity {Name = "Adrian Cleveland", Age = 36},
                new Identity {Name = "Rigel Sweet", Age = 23},
                new Identity {Name = "Lillian Short", Age = 68},
                new Identity {Name = "Hanae Fischer", Age = 25},
                new Identity {Name = "Alec Moss", Age = 65},
                new Identity {Name = "Boris Greer", Age = 36},
                new Identity {Name = "Mark Chavez", Age = 33},
                new Identity {Name = "Hector Benjamin", Age = 54},
                new Identity {Name = "Bert Wallace", Age = 15},
                new Identity {Name = "Xanthus Garrett", Age = 19},
                new Identity {Name = "Kaden Jensen", Age = 81},
                new Identity {Name = "Seth Christian", Age = 23},
                new Identity {Name = "Remedios Ramos", Age = 59}
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
                    BestImage = bytes,
                    Rectangle = "{\"test\":[34,34,43,43]}",
                    Timestamp = DateTime.Now,
                    AggregatedEventsId = context.AggregatedEvents.ToList()[i/10].AggregatedEventsId
                });
            }
            context.Events.AddRange(events);
            context.SaveChanges();
        }
    }
}
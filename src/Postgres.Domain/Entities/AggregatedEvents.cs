using System;
using System.Collections.Generic;

namespace Postgres.Domain.Entities
{
    public class AggregatedEvents
    {
        public AggregatedEvents()
        {
            FrcEvent = new HashSet<FrcEvent>();
        }

        public Guid AggregatedEventsId { get; set; }

        public string IdentityId { get; set; }
        public bool Recognized { get; set; }
        public string CameraId { get; set; }
        public DateTimeOffset TimestampStart { get; set; }
        public DateTimeOffset TimestampEnd { get; set; }
        public byte[] BestImage { get; set; }
        public double Confidence { get; set; }

        public ICollection<FrcEvent> FrcEvent { get; private set; }
    }
}
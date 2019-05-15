using System;

namespace Postgres.Domain.Entities
{
    public class FrcEvent
    {
        public int FrcEventId { get; set; }

        public string Rectangle { get; set; }

        public string Confidence { get; set; }

        public DateTimeOffset Timestamp { get; set; }
        public byte[] Image { get; set; }
        public int Framenumber { get; set; }
        public string HeadId { get; set; }
        public ulong EventId { get; set; }
        public Guid AggregatedEventsId { get; set; }
        public AggregatedEvents AggregatedEvents { get; set; }
    }
}
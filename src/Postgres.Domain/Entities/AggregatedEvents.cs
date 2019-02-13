using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Domain.Entities
{
    public class AggregatedEvents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AggregatedEventsId { get; set; }

        public int IdentityId { get; set; }
        public bool Recognized { get; set; }
        public DateTime TimestampStart { get; set; }
        public DateTime TimestampEnd { get; set; }
        public byte[] BestImage { get; set; }
        public List<Event> Events { get; set; }
    }
}
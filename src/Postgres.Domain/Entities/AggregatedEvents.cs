using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Domain.Entities
{
    public class AggregatedEvents
    {
        public AggregatedEvents()
        {
            FrcEvent = new HashSet<FrcEvent>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AggregatedEventsId { get; set; }

        public int IdentityId { get; set; }
        public bool Recognized { get; set; }
        public DateTime TimestampStart { get; set; }
        public DateTime TimestampEnd { get; set; }
        public byte[] BestImage { get; set; }

        public ICollection<FrcEvent> FrcEvent { get; private set; }
    }
}
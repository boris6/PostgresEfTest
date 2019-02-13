using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Domain.Entities
{
    public class FrcEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [Column(TypeName = "jsonb")]
        public string Rectangle { get; set; }

        [Column(TypeName = "jsonb")]
        public string Confidence { get; set; }

        public DateTime Timestamp { get; set; }
        public byte[] BestImage { get; set; }

        public Guid AggregatedEventsId { get; set; }
        public AggregatedEvents AggregatedEvents { get; set; }
    }
}
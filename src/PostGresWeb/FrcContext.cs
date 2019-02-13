using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostGresWeb
{
    public class FrcContext : DbContext
    {
        public DbSet<AggregatedEvents> AggregatedEvents { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Event> Events { get; set; }

        public FrcContext(DbContextOptions<FrcContext> options) : base(options)
        {
        }
    }

    public class Identity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdentityId { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }

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

    public class Event
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
    }
}
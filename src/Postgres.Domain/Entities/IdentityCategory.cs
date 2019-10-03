using System;

namespace Postgres.Domain.Entities
{
    public class IdentityCategory
    {
        public Guid IdentityId { get; set; }
        public Guid CategoryId { get; set; }

        public Identity Identity { get; set; }
        public Category Category { get; set; }
    }
}
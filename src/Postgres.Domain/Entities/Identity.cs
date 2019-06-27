using System;
using System.Collections.Generic;

namespace Postgres.Domain.Entities
{
    public class Identity
    {
        public Identity()
        {
            IdentityCategories = new HashSet<IdentityCategory>();
        }

        public string IdentityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Gender { get; set; }
        public string Info { get; set; }
        public string ExternalId { get; set; }
        public string Group { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedAt { get; set; }
        public ICollection<IdentityCategory> IdentityCategories { get; }
        public List<ReferenceImage> ReferenceImages { get; set; }
    }
}
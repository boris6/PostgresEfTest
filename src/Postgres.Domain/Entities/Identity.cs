using System.Collections.Generic;

namespace Postgres.Domain.Entities
{
    public class Identity
    {
        public Identity()
        {
            ReferenceImages = new HashSet<ReferenceImage>();
            IdentityGroups = new HashSet<IdentityGroup>();
        }

        public string IdentityId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string Info { get; set; }
        public string ExternalId { get; set; }

        public ICollection<IdentityGroup> IdentityGroups { get; }
        public ICollection<ReferenceImage> ReferenceImages { get; }
    }
}
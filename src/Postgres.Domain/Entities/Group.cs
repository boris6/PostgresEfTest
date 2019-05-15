using System.Collections.Generic;

namespace Postgres.Domain.Entities
{
    public class Group
    {
        public Group()
        {
            IdentityGroups = new HashSet<IdentityGroup>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public ICollection<IdentityGroup> IdentityGroups { get; private set; }
    }
}
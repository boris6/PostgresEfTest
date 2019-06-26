using System;

namespace HitachiSyncService.Entities
{
    public class Identity
    {
        public Guid IdentityId { get; set; }
        public DateTime Changed { get; set; }
    }
}

using System;

namespace Postgres.Domain.Entities
{
    public class FeatureVector
    {
        public int FeatureVectorId { get; set; }
        public byte[] FeatureVectorData { get; set; }
        public string ExternailId { get; set; }
        public Guid? ReferenceImageId { get; set; }
        public Guid? IdentityId { get; set; }
        public bool CombinedVector { get; set; }

    }
}
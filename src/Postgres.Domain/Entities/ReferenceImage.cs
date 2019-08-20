using System;

namespace Postgres.Domain.Entities
{
    public class ReferenceImage
    {
        public Guid ReferenceImageId { get; set; }
        public byte[] Image { get; set; }

        public string IdentityId { get; set; }
        public Identity Identity { get; set; }

        public string ExternalImageId { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Image = new byte[] { };
                IdentityId = null;
            }
        }
    }
}
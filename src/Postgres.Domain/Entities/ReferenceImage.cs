namespace Postgres.Domain.Entities
{
    public class ReferenceImage
    {
        public int ReferenceImageId { get; set; }
        public byte[] Image { get; set; }

        public string IdentityId { get; set; }
        public Identity Identity { get; set; }
    }
}
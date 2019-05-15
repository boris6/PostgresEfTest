namespace Postgres.Domain.Entities
{
    public class IdentityGroup
    {
        public string IdentityId { get; set; }
        public Identity Identity { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
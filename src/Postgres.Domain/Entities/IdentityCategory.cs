namespace Postgres.Domain.Entities
{
    public class IdentityCategory
    {
        public string IdentityId { get; set; }
        public string CategoryId { get; set; }

        public Identity Identity { get; set; }
        public Category Category { get; set; }
    }
}
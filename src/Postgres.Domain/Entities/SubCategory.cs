namespace Postgres.Domain.Entities
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Domain.Entities
{
    public class Identity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdentityId { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
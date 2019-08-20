using System;
using System.Collections.Generic;

namespace Postgres.Domain.Entities
{
    public class Identity
    {
        public Identity()
        {
            IdentityCategories = new HashSet<IdentityCategory>();

            ReferenceImages = new List<ReferenceImage>();
        }

        public string IdentityId { get; set; }
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Gender { get; set; }
        public string Info { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? Active { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string ExternalId { get; set; } // for Face recognition algoritams
        public string Group { get; set; } // for Hitachi
        public string AddedBy { get; set; }
        public DateTime? AddedAt { get; set; }
        public Guid ReferenceImageId { get; set; } // id of main image
        public ICollection<IdentityCategory> IdentityCategories { get; }
        public List<ReferenceImage> ReferenceImages { get; set; }
    }
}
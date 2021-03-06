﻿using System;
using System.Collections.Generic;

namespace Postgres.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            IdentityCategories = new HashSet<IdentityCategory>();
            SubCategories = new HashSet<SubCategory>();
        }

        public Guid CategoryId { get; set; }
        public Guid CustomerId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }

        public ICollection<IdentityCategory> IdentityCategories { get; }
    }
}
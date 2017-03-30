using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace XChange.Models
{
        public class Auction
        {
            public long Id { get; set; }

            public bool Active { get; set; }

            // Info
            public string Creator { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
            public string City { get; set; }

            // Categories
            public Category Category { get; set; }
            public Subcategory Subcategory { get; set; }

            // public string[] Tags { get; set; } // TODO: EntityFramework string list

            // Timestamps
            public DateTime CreatedAt { get; set; }
            public DateTime EndsAt { get; set; }

            // Money
            public int MoneyGoal { get; set; }
            public int MoneyRaised { get; set; }
            public int MoneyStep { get; set; }
        }

        public class Category {
            public long Id { get; set; }
            public string Name {get; set;}
        }

        public class Subcategory {
            public long Id { get; set; }
            public Category Category { get; set; }
            public string Name {get; set;}
        }
}

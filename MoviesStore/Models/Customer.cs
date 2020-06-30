using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // For Attributes

namespace MoviesStore.Models
{
    public class Customer
    {
        public int Id { get; set; }

        // overriding default conventions. Type of string is assigned nvarchar with max length and nullable in db.
        [Required] // Not nullable anymore.
        [StringLength(255)] // Not of max length anymore.
        public string Name { get; set; }

        // New property added.
        public bool IsSubscribedToNewsletter { get; set; }

        // Navigation Property (used for joins)
        public MembershipType MembershipType { get; set; }

        // when we only want the foreign key and not whole navigation property
        // we use only the foreign key with className + id which is auto recgnized by EF as FK.
        public byte MembershipTypeId { get; set; }

        // New property.
        public DateTime? Birthdate { get; set; }
    }
}
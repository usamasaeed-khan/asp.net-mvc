using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesStore.Models
{
    public class MembershipType
    {
        // Primary key.
        public byte Id { get; set; }

        // Won't be > 32000.
        public short SignUpFee { get; set; }

        // Won't be > 12.
        public short DurationInMonths { get; set; }

        // Will be between 0-100.
        public byte DiscountRate { get; set; }

        // New Migration
        public string Name { get; set; }
    }
}
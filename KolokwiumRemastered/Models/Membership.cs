using System;
using System.Collections.Generic;

namespace KolokwiumRemastered.Models
{
    public class Membership
    {

        public int MemberID { get; set; }
        public int TeamID { get; set; }
        public DateTime MembershipDate { get; set; }

        public Team Team { get; set; }
        public Member Member { get; set; }

    }
}

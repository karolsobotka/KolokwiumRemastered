using System;

namespace KolokwiumRemastered.Models.DTOs
{
    public class SomeSortOfMembership
    {
        public DateTime MembershipDate { get; set; }
        public SomeSortOfTeam Team { get; set; }
        public SomeSortOfMember Member { get; set; }
    }
}

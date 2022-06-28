using System.Collections.Generic;

namespace KolokwiumRemastered.Models.DTOs
{
    public class SomeSortOfTeam
    {
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public SomeSortOfOrganization Organization { get; set; }
        public virtual IEnumerable<SomeSortOfFile> Files{ get; set; }
        public virtual IEnumerable<SomeSortOfMembership> Memberships{ get; set; }


    }
}

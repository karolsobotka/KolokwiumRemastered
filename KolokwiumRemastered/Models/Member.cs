using System.Collections.Generic;

namespace KolokwiumRemastered.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public int OrganizationID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberNickName { get; set; }

        public Organization Organization { get; set; }

        public ICollection<Membership> Memberhips{ get; set; }
    }
}

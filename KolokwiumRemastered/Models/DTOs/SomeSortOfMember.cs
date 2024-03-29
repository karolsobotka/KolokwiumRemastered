﻿using System.Collections.Generic;

namespace KolokwiumRemastered.Models.DTOs
{
    public class SomeSortOfMember
    {
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberNickName { get; set; }
        public virtual ICollection<SomeSortOfMembership> Membership { get; set; }
        public SomeSortOfOrganization Organization { get; set; }

    }
}

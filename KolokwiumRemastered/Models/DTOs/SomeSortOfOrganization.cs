﻿using System.Collections;
using System.Collections.Generic;

namespace KolokwiumRemastered.Models.DTOs
{
    public class SomeSortOfOrganization
    {
        public string OrganizationName { get; set; }
        public string OrganizationDomain{ get; set; }
        public virtual IEnumerable<SomeSortOfTeam> Teams { get; set; } 
        public virtual IEnumerable<SomeSortOfMember> Members { get; set; }

    }
}

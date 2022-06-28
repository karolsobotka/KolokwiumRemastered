using KolokwiumRemastered.Models;
using KolokwiumRemastered.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumRemastered.Services
{
    public class DbService : IDbService
    {

        private readonly MainDbContext _dbContext;
        public DbService(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddMember(Member member)
        {
            _dbContext.Add(member);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<SomeSortOfTeam> GetTeam(int id)
        {
            return await _dbContext.Team.Where(e => e.TeamID == id)
            .Select(x => new SomeSortOfTeam
            {
                TeamName = x.TeamName,
                TeamDescription = x.TeamDescription,
                Organization = new SomeSortOfOrganization
                {
                    OrganizationName = x.Organization.OrganizationName
                },
                Memberships = (ICollection<SomeSortOfMembership>)x.Memberships.Select(m => new SomeSortOfMember
                {
                    MemberName = m.Member.MemberName,
                    MemberSurname = m.Member.MemberSurname,
                    MemberNickName = m.Member.MemberSurname,


                })
            }).FirstOrDefaultAsync();
         
        }
    }
}

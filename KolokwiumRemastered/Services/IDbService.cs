using KolokwiumRemastered.Models;
using KolokwiumRemastered.Models.DTOs;
using System.Threading.Tasks;

namespace KolokwiumRemastered.Services
{
    public interface IDbService
    {
        public Task<SomeSortOfTeam> GetTeam(int id);
       
        public Task AddMember(Member member);
    }
}

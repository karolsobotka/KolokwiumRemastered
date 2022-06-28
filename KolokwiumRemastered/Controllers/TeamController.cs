using KolokwiumRemastered.Models;
using KolokwiumRemastered.Models.DTOs;
using KolokwiumRemastered.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KolokwiumRemastered.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IDbService _dBservice;
        public TeamController(IDbService dbservice)
        {
            _dBservice = dbservice;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetTeam(int id)
        {
            var team = await _dBservice.GetTeam(id);

            if (team == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(team);
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddMember(SomeSortOfMember member)
        {
            Member memberToAdd = new()
            {
                MemberName = member.MemberName,
                MemberSurname = member.MemberSurname,
                MemberNickName = member.MemberNickName
            };
            await _dBservice.AddMember(memberToAdd);
            return Ok("Member added");
        }

       
    }
}


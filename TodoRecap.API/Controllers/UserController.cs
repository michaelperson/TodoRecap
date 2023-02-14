 
using ConnectDB.Interfaces;
using ConnectDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoRecap.API.Models;

namespace TodoRecap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository<UserEntity, int> _repo;

        public UserController(IRepository<UserEntity,int> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IEnumerable<UserDto> Get()
        {
            //List<UserDto> result = new List<UserDto>();
            //List<UserEntity> users = _repo.GetAll();
            //foreach (UserEntity item in users)
            //{
            //    result.Add(new UserDto() { Id = item.Id, UserName = item.Name });

            //}
            //return result;

            return _repo.GetAll()
                .Select(item=>
                new UserDto() { Id = item.Id, UserName = item.Name });

        }
    }
}

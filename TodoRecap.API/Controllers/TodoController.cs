using ConnectDB.Interfaces;
using ConnectDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoRecap.API.Models;

namespace TodoRecap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IRepository<ToDoEntity, int> _repo;

        public TodoController(IRepository<ToDoEntity,int> repo)
        {
            _repo = repo;
        }
        //GET
        [HttpGet]
        public IEnumerable<TodoDTO> GetAllTitleOnly()
        {
             
            IEnumerable <ToDoEntity> mesTodo = _repo.GetAll();
            List<TodoDTO> retour = new List<TodoDTO>();
            //mapper
            foreach (ToDoEntity item in mesTodo)
            {
                 
                if (!item.Done)
                {
                    retour.Add(
                         new TodoDTO() { Titre = item.Title }
                        );
                }
            }
            return retour;
        }
 
        //POST

        //PUT

        //PATCH

        //DELETE
    }
}

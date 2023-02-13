using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_2.ClassesService;
using Service_2.InterfacesService;
using Service_2.Models;

namespace WebApi_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildOfUserController : Controller
    {
        IChildOfUserService ChildOfUserService;

        public ChildOfUserController(IChildOfUserService ChildOfUserService)
        {
            this.ChildOfUserService = ChildOfUserService;
        }

        [HttpGet]
        public async Task<IEnumerable<ChildOfUserModel>> Get()
        {
            var result = await ChildOfUserService.GetAllAsync();
            return result;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ChildOfUserModel>> Get(int id)
        {
            var book = await ChildOfUserService.GetByIdAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpPost]
        public async Task<ActionResult<ChildOfUserModel>> Post([FromBody] ChildOfUserModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await ChildOfUserService.AddAsync(new ChildOfUserModel()
            {
             
                Name = model.Name,
               Tz = model.Tz,
                ChildOfUserId = model.ChildOfUserId,
                BirthDate = model.BirthDate,
                



            });

        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await ChildOfUserService.DeleteAsync(id);
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_2.InterfacesService;
using Service_2.Models;

namespace WebApi_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
      
        IUserService userService;
 
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task< IEnumerable<UserModel>> Get()
        {
            var result =await userService.GetAllAsync();
            return result;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> Get(int id)
        {
            var book = await userService.GetByIdAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> Post([FromBody] UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await userService.AddAsync(new UserModel()
            {
                Tz = model.Tz,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserHMO = model.UserHMO,
                UserId = model.UserId,
                BirthDate = model.BirthDate,
                Gemder = model.Gemder,
                ChildrenOfUser = model.ChildrenOfUser,
              
               
            }); ;

        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await userService.DeleteAsync(id);
        }
       
        
    }
}

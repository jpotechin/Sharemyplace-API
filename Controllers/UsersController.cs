using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController
    {
        private readonly DataContext context;
        public UsersController(DataContext context)
        {
            this.context = context;
        }
    }
}
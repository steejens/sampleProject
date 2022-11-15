using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Application.SampleQueries.GetAllSamplesQuery;
using Project.Domain.Entities.Identity;

namespace Project.API.Controllers
{

    public class IdentityController : BaseController
    {
        private readonly UserManager<User> _userManager;

        public IdentityController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        [Produces("application/json")]
        [HttpPost("create-user")]
        public async Task<ApiResponse> CreateUser([FromBody]  CreateUserRequest request)
        {
            await _userManager.CreateAsync(new User()
            {
                Id= Guid.NewGuid().ToString(),
                UserName = request.UserName,
                Email = request.Email,
            },request.Password);
            return new ApiResponse(_userManager.ErrorDescriber);
        }

    }

    public class CreateUserRequest
    {
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    }
}

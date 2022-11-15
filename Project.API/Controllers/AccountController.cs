using AutoWrapper.Extensions;
using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Commands.AccountCommands.SigninUser;
using Project.Core.Enums.Enitity;
using Project.Core.Extensions;

namespace Project.API.Controllers
{
    public class AccountController : BaseController
    {


        [Produces("application/json")]
        [HttpPost("Auth")]
        public async Task<ApiResponse> AuthAsync([FromBody] SignInUserRequest request)
        {
            if (!ModelState.IsValid)
                throw new ApiException(ModelState.AllErrors());
            var isEmail = request.EmailOrUsername.IsEmail();
            var isUsername = request.EmailOrUsername.IsUsername();

            if (!(isEmail || isUsername))
                ModelState.AddModelError("emailOrUsername", "Enter valid Email/Username");


            var response = await Mediator.Send(new SignInUserCommand(request));

            return new ApiResponse(result: response);
        }

    
    }
}

using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Application.SampleQueries.GetAllSamplesQuery;

namespace Project.API.Controllers.Sample
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class AboutUsController : BaseController
    {

        [Produces("application/json")]
        [HttpGet("get-all-samples")]
        public async Task<ApiResponse> GetAboutUsAsync([FromQuery] GetAllSamplesRequest request)
        {
            var result = await Mediator.Send(new GetAllSamplesQuery(request));
            return new ApiResponse(result);
        }

    }
}

using CleanArchitecture.Application.Features.Lookups.Requests.Queries;
using CleanArchitecture.Utility.Results;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LookupController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
        }

        [Route("GetLookupDetailByType")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        //  [Authorize]
        public async Task<ActionResult<Result>> GetLookupDetailByType(string lookupType)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var querry = new GetLookupDetailByTypeRequest { LookupType = lookupType };
            var response = await _mediator.Send(querry);
            return Ok(response);
        }
    }
}

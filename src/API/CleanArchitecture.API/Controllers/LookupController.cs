using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.Features.Lookups.Requests.Commands;
using CleanArchitecture.Application.Features.Lookups.Requests.Queries;
using CleanArchitecture.Application.Responses;
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
        // GET: api/<LookupsController>
        [HttpGet]
        public async Task<ActionResult<List<LookupMasterDTO>>> Get()
        {
            var lookupMasters = await _mediator.Send(new GetLookupMasterListRequest());
            return Ok(lookupMasters);
        }

        // GET api/<LeaveTypesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LookupMasterDTO>> Get(int id)
        {
            var leaveType = await _mediator.Send(new GetLookupMasterDetailRequest { Id = id });
            return Ok(leaveType);
        }

        // POST api/<LeaveTypesController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        // [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateLookupMasterDTO lookupMaster)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateLookupMasterCommand {LookupMasterDTO  = lookupMaster };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<LeaveTypesController>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        // [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> Put([FromBody] UpdateLookupMasterDTO lookupMasterDto)
        {
            var command = new UpdateLookupMasterCommand { UpdateLookupMasterDTO = lookupMasterDto };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<LeaveTypesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        // [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> Delete(int id)
        {
            DeleteLookupMasterDTO _DeleteLookupMasterDTO = new DeleteLookupMasterDTO
            {
                Id = id,
                IsDeleted = true,
                IsActive = false,
                LastModifiedBy = "SystemUser"
            };
            var command = new DeleteLookupMasterCommand { DeleteLookupMasterDTO = _DeleteLookupMasterDTO };
            await _mediator.Send(command);
            return NoContent();
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

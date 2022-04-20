using CleanArchitecture.Application.Responses;
using MediatR;
using CleanArchitecture.Application.DTOs.Lookup;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Commands;

public class CreateLookupMasterCommand : IRequest<BaseCommandResponse>
{
    public CreateLookupMasterDTO LookupMasterDTO { get; set; }

}

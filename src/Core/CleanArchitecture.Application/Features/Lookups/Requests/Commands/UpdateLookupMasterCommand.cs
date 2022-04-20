using CleanArchitecture.Application.DTOs.Lookup;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Commands;

public class UpdateLookupMasterCommand : IRequest<Unit>
{
    public UpdateLookupMasterDTO UpdateLookupMasterDTO { get; set; }

}

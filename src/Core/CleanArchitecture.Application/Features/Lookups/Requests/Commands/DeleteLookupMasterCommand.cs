
using CleanArchitecture.Application.DTOs.Lookup;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Commands;

public class DeleteLookupMasterCommand : IRequest<Unit>
{
    public DeleteLookupMasterDTO DeleteLookupMasterDTO { get; set; }

}


using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.ViewModels.Lookup;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Commands;

public class DeleteLookupMasterCommand : IRequest<Unit>
{
    public DeleteLookupMasterViewModel DeleteLookupMasterViewModel { get; set; }

}

using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.ViewModels.Lookup;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Commands;

public class UpdateLookupMasterCommand : IRequest<Unit>
{
    public UpdateLookupMasterViewModel UpdateLookupMasterViewModel { get; set; }

}

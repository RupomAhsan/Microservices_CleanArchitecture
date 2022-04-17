using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.Responses;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Commands;

public class CreateLookupMasterCommand : IRequest<BaseCommandResponse>
{
    public CreateLookupMasterViewModel LookupMasterViewModel { get; set; }

}

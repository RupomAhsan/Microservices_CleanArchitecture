using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.ViewModels;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Queries;

public class GetLookupMasterDetailRequest : IRequest<CreateLookupMasterViewModel>
{
    public int Id { get; set; }
}

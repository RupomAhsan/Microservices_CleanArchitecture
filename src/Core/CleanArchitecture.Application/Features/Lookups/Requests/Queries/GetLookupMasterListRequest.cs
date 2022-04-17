using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.ViewModels;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Queries;

public class GetLookupMasterListRequest : IRequest<List<CreateLookupMasterViewModel>>
{
}

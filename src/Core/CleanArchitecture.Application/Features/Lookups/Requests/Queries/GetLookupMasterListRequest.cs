using CleanArchitecture.Application.DTOs.Lookup;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Queries;

public class GetLookupMasterListRequest : IRequest<List<CreateLookupMasterDTO>>
{
}

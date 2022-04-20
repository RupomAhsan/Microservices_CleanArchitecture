using CleanArchitecture.Application.DTOs.Lookup;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Queries;

public class GetLookupMasterDetailRequest : IRequest<CreateLookupMasterDTO>
{
    public int Id { get; set; }
}

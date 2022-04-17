using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Utility.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Lookups.Requests.Queries
{
    public class GetLookupDetailByTypeRequest : IRequest<Result<List<GetLookupDetailByTypeResponseDTO>>>
    {
        public string LookupType { get; set; }
    }
}

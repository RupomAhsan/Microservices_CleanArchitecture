using AutoMapper;
using CleanArchitecture.Application.Contracts.Interfaces;
using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.Features.Lookups.Requests.Queries;
using CleanArchitecture.Application.Features.Lookups.Specifications;
using CleanArchitecture.Domain.Entity.Lookup;
using CleanArchitecture.Utility.Extensions;
using CleanArchitecture.Utility.Results;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Handlers.Queries
{
    public class GetLookupDetailByTypeRequestHandler : IRequestHandler<GetLookupDetailByTypeRequest, Result<List<GetLookupDetailByTypeResponseDTO>>>
    {
        private readonly IMapper _mapper;
       // private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<LookupDetailEntity> _LookupDetailRepository;
        public GetLookupDetailByTypeRequestHandler(
            IMapper mapper,
           // IUnitOfWork unitOfWork,
            IRepository<LookupDetailEntity> lookupDetailRepository
            )
        {
            _mapper = mapper;
           // _unitOfWork = unitOfWork;
            _LookupDetailRepository = lookupDetailRepository;

        }

        public async Task<Result<List<GetLookupDetailByTypeResponseDTO>>> Handle(GetLookupDetailByTypeRequest request, CancellationToken cancellationToken)
        {
            var response = new Result<List<GetLookupDetailByTypeResponseDTO>>();
            try
            {
                var getLookupDetailByTypeSpec = new GgetLookupDetailByTypeSpec(request.LookupType);
                var lookupDetails = await _LookupDetailRepository.ListAsync(getLookupDetailByTypeSpec);
                if (lookupDetails != null)
                {
                    
                    response.Data = _mapper.Map<List<GetLookupDetailByTypeResponseDTO>>(lookupDetails); 
                    response.Successful().WithMessage("Get Lookup Detail By Type Successful.");
                }
                else
                {
                    response.Failed().WithMessage("Lookup Detail not found.");
                }


            }
            catch (Exception ex)
            {
                response.Failed().WithMessage(ex.Message);
            }
            return response;
        }
    }
}

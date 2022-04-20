
using AutoMapper;
using CleanArchitecture.Application.Contracts.Interfaces;
using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.Features.Lookups.Requests.Queries;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Handlers.Queries;

public class GetLookupMasterDetailRequestHandler : IRequestHandler<GetLookupMasterDetailRequest, CreateLookupMasterDTO>
{    
    private readonly IMapper _mapper;

    private readonly IUnitOfWork _unitOfWork;

    public GetLookupMasterDetailRequestHandler(IMapper mapper,
        IUnitOfWork unitOfWork
        )
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<CreateLookupMasterDTO> Handle(GetLookupMasterDetailRequest request, CancellationToken cancellationToken)
    {
        var lookupMaster = await _unitOfWork.LookupMasterRepository.GetByIdAsync(request.Id);
        return _mapper.Map<CreateLookupMasterDTO>(lookupMaster);
    }

}


﻿

using AutoMapper;
using CleanArchitecture.Application.Contracts.Interfaces;
using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.Features.Lookups.Requests.Queries;
using CleanArchitecture.Domain.Entity.Lookup;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Handlers.Queries;

public class GetLookupMasterListRequestHandler : IRequestHandler<GetLookupMasterListRequest, List<CreateLookupMasterDTO>>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GetLookupMasterListRequestHandler(
        IMapper mapper,
        IUnitOfWork unitOfWork
        )
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;

    }

    public async Task<List<CreateLookupMasterDTO>> Handle(GetLookupMasterListRequest request, CancellationToken cancellationToken)
    {
        var lookupMasters = await _unitOfWork.LookupMasterRepository.ListAsync();
        return _mapper.Map<List<CreateLookupMasterDTO>>(lookupMasters);
    }
}

﻿using AutoMapper;
using CleanArchitecture.Application.Contracts.Interfaces;
using CleanArchitecture.Application.DTOs.Lookup.Validators;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Features.Lookups.Requests.Commands;
using CleanArchitecture.Domain.Entity.Lookup;
using MediatR;

namespace CleanArchitecture.Application.Features.Lookups.Handlers.Commands;

public class DeleteLookupMasterCommandHandler : IRequestHandler<DeleteLookupMasterCommand, Unit>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DeleteLookupMasterCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteLookupMasterCommand request, CancellationToken cancellationToken)
    {
        var validator = new DeleteLookupMasterViewModelValidator();
        var validationResult = await validator.ValidateAsync(request.DeleteLookupMasterViewModel);

        if (validationResult.IsValid == false)
            throw new ValidationException(validationResult);

        var lookupMaster = await _unitOfWork.LookupMasterRepository.GetByIdAsync(request.DeleteLookupMasterViewModel.Id);

        if (lookupMaster is null)
            throw new NotFoundException(nameof(lookupMaster), request.DeleteLookupMasterViewModel.Id);

        _mapper.Map(request.DeleteLookupMasterViewModel, lookupMaster);

        await _unitOfWork.LookupMasterRepository.UpdateAsync(lookupMaster);
        await _unitOfWork.SaveAsync();

        return Unit.Value;
    }
}

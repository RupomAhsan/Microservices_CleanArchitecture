using AutoMapper;
using CleanArchitecture.Application.Contracts.Interfaces;
using CleanArchitecture.Application.Features.Lookups.Requests.Commands;
using CleanArchitecture.Application.Responses;
using CleanArchitecture.Domain.Entity.Lookup;
using MediatR;
using CleanArchitecture.Application.DTOs.Lookup.Validators;

namespace CleanArchitecture.Application.Features.Lookups.Handlers.Commands;

public class CreateLookupMasterCommandHandler : IRequestHandler<CreateLookupMasterCommand, BaseCommandResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateLookupMasterCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

public async Task<BaseCommandResponse> Handle(CreateLookupMasterCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseCommandResponse();
        var validator = new CreateLookupMasterDTOValidator();
        var validationResult = await validator.ValidateAsync(request.LookupMasterDTO);

        if (validationResult.IsValid == false)
        {
            response.Success = false;
            response.Message = "Creation Failed";
            response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
        }
        else
        {
            var lookupmMaster = _mapper.Map<LookupMasterEntity>(request.LookupMasterDTO);

            lookupmMaster = await _unitOfWork.LookupMasterRepository.AddAsync(lookupmMaster);
            await _unitOfWork.SaveAsync();

            response.Success = true;
            response.Message = "Creation Successful";
          //  response.Id = lookupmMaster.Id;
        }

        return response;
    }
}

using AutoMapper;
using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.ViewModels.Lookup;
using CleanArchitecture.Domain.Entity;
using CleanArchitecture.Domain.Entity.Lookup;

namespace CleanArchitecture.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LookupMasterEntity, CreateLookupMasterViewModel>().ReverseMap();
            CreateMap<LookupMasterEntity, UpdateLookupMasterViewModel>().ReverseMap();
            CreateMap<LookupMasterEntity, DeleteLookupMasterViewModel>().ReverseMap();
            CreateMap<LookupDetailEntity, LookupDetailViewModel>().ReverseMap();
            CreateMap<LookupDetailEntity, GetLookupDetailByTypeResponseDTO>().ReverseMap();
        }
    }
}

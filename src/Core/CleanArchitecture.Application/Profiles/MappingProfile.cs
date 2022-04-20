using AutoMapper;
using CleanArchitecture.Application.DTOs.Lookup;
using CleanArchitecture.Domain.Entity.Lookup;

namespace CleanArchitecture.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LookupMasterEntity, CreateLookupMasterDTO>().ReverseMap();
            CreateMap<LookupMasterEntity, UpdateLookupMasterDTO>().ReverseMap();
            CreateMap<LookupMasterEntity, DeleteLookupMasterDTO>().ReverseMap();
            CreateMap<LookupDetailEntity, LookupDetailDTO>().ReverseMap();
            CreateMap<LookupDetailEntity, GetLookupDetailByTypeResponseDTO>().ReverseMap();
        }
    }
}

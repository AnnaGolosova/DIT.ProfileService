using AutoMapper;
using Entities.ModelsDto;

namespace ProfileMicroservice.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProfileDto, Entities.Models.Profile>();
        }
    }
}

using AutoMapper;
using Entities.ModelsDto;

namespace ProfileMicroservice.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProfileDto, Entities.Models.Profile>();

            CreateMap<Entities.Models.Profile, ReturnProfileDto>().ForMember(x => x.Gender, opt => opt.MapFrom(m => m.Gender.Title));
        }
    }
}

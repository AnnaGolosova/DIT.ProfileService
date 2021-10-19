using AutoMapper;
using Entities.ModelsDto;

namespace ProfileMicroservice.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProfileDto, Entities.Models.Profile>();
            
            CreateMap<UpdateProfileDto, Entities.Models.Profile>().ForMember(x => x.Gender, opt => opt.Ignore());

            CreateMap<Entities.Models.Profile, ReturnProfileDto>().ForMember(x => x.Gender, opt => opt.MapFrom(m => m.Gender.Title));

            CreateMap<Entities.Models.Gender, ReturnGenderDto>();

        }
    }
}

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

            CreateMap<Entities.Models.Friend, ReturnProfileDto>()
                .ForMember(x => x.Age, opt => opt.MapFrom(m => m.Profile.Age))
                .ForMember(x => x.FirstName, opt => opt.MapFrom(m => m.Profile.FirstName))
                .ForMember(x => x.LastName, opt => opt.MapFrom(m => m.Profile.LastName))
                .ForMember(x => x.Id, opt => opt.MapFrom(m => m.Profile.Id))
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(m => m.Profile.ImageId))
                .ForMember(x => x.Gender, opt => opt.MapFrom(m => m.Profile.Gender.Title));

        }
    }
}

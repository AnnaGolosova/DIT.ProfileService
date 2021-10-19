using AutoMapper;
using Entities.ModelsDto;
using MediatR;
using Repository.Manager;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Commands.ProfileCommands
{
    public class UpdateProfileCommand : IRequest<ReturnProfileDto>
    {
        public UpdateProfileDto updateProfile { get; set; }
        public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, ReturnProfileDto>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public UpdateProfileCommandHandler(IRepositoryManager manager, IMapper mapper)
            {
                _mapper = mapper;
                _manager = manager;
            }
            public async Task<ReturnProfileDto> Handle(UpdateProfileCommand command, CancellationToken cancellationToken)
            {
                var profile = _manager.Profiles.ReturnDistinct(p => p.Id == command.updateProfile.Id, true).SingleOrDefault(); 
                var gender = _manager.Genders.ReturnDistinct(g => g.Title == command.updateProfile.Gender, false).SingleOrDefault();

                _mapper.Map(command.updateProfile, profile);
                profile.GenderId = gender.Id;
                _manager.Profiles.Save();

                var changedProfileDto = _mapper.Map<ReturnProfileDto>(profile);
                changedProfileDto.Gender = gender.Title;

                return (changedProfileDto);
            }
        }
    }
}

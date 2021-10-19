using AutoMapper;
using Entities.ModelsDto;
using MediatR;
using Repository.Manager;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Commands.ProfileCommands
{
    public class CreateProfileCommand : IRequest<Guid>
    {
        public CreateProfileDto createProfile { get; set; }
        public class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand, Guid>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public CreateProfileCommandHandler(IRepositoryManager manager, IMapper mapper)
            {
                _mapper = mapper;
                _manager = manager;
            }
            public async Task<Guid> Handle(CreateProfileCommand command, CancellationToken cancellationToken)
            {
                var profile = _mapper.Map<Entities.Models.Profile>(command.createProfile);

                profile.Id = Guid.NewGuid();
                _manager.Profiles.Create(profile);

                return (profile.Id);
            }
        }
    }
}

using AutoMapper;
using MediatR;
using Repository.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Commands.ProfileCommands
{
    public class DeleteProfileCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public class DeleteProfileByIdCommandHandler : IRequestHandler<DeleteProfileCommand, Guid>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public DeleteProfileByIdCommandHandler(IRepositoryManager manager, IMapper mapper)
            {
                _mapper = mapper;
                _manager = manager;
            }
            public async Task<Guid> Handle(DeleteProfileCommand command, CancellationToken cancellationToken)
            {
                var profile = _manager.Profiles.ReturnDistinct(p => p.Id == command.Id, true).SingleOrDefault(); 
                _manager.Profiles.Delete(profile);
                return profile.Id;
            }
        }
    }
}

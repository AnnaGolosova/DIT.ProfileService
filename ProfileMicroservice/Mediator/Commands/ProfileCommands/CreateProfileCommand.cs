using MediatR;
using Entities.ModelsDto;
using Repository.Manager;
using System.Threading.Tasks;
using System.Threading;
using System;
using Entities.Models;

namespace Mediator.Commands.ProfileCommands
{
    public class CreateProfileCommand : IRequest<Guid>
    {
        public CreateProfileDto Name { get; set; }
        public class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand, Guid>
        {
            private readonly IRepositoryManager _manager;
            public CreateProfileCommandHandler(IRepositoryManager manager)
            {
                _manager = manager;
            }
            public async Task<Guid> Handle(CreateProfileCommand command, CancellationToken cancellationToken)
            {
                Profile profile = new Profile()
                {
                    Id = Guid.NewGuid(),
                }


               
            }
        }
    }
}

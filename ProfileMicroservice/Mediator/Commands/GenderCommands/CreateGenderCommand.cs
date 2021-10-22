using AutoMapper;
using Entities.ModelsDto;
using Mediator.Commands.ProfileCommands;
using MediatR;
using Repository.Manager;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Commands.GenderCommands
{
    public class CreateGenderCommand : IRequest<string>
    {

        public CreateGenderDto createGenderDto;
        public class CreateGenderCommandHandler : IRequestHandler<CreateGenderCommand, string>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public CreateGenderCommandHandler(IRepositoryManager manager, IMapper mapper)
            {
                _mapper = mapper;
                _manager = manager;
            }
            public async Task<string> Handle(CreateGenderCommand command, CancellationToken cancellationToken)
            {
                //var genders = _manager.Genders.Create(  )

                return "df";
            }
        }
    }
}

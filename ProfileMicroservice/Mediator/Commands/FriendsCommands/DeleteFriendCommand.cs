using AutoMapper;
using MediatR;
using Repository.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Commands.FriendsCommands
{
    public class DeleteFriendCommand : IRequest<Guid>
    {
        public Guid ProfileId { get; set; }
        public Guid FriendId { get; set; }
        public class DeleteFriendCommandHandler : IRequestHandler<DeleteFriendCommand, Guid>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public DeleteFriendCommandHandler(IRepositoryManager manager, IMapper mapper)
            {
                _mapper = mapper;
                _manager = manager;
            }
            public async Task<Guid> Handle(DeleteFriendCommand command, CancellationToken cancellationToken)
            {
                var profile = _manager.Friends.ReturnDistinct(f => f.ProfileId == command.ProfileId && f.FriendId == command.FriendId, true).SingleOrDefault();
                _manager.Friends.Delete(profile);
                return command.FriendId;
            }
        }
    }
}

using AutoMapper;
using Entities.Models;
using Entities.ModelsDto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Repository.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Queries.FriendsQueries
{
    public class GetAllFriendByProfileIdQuery : IRequest<IEnumerable<ReturnProfileDto>>
    {
        public Guid Id { get; set; }
        public class GetAllFriendByProfileIdQueryHandler : IRequestHandler<GetAllFriendByProfileIdQuery, IEnumerable<ReturnProfileDto>>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public GetAllFriendByProfileIdQueryHandler(IMapper mapper, IRepositoryManager manager)
            {
                _mapper = mapper;
                _manager = manager;
            }
            public async Task<IEnumerable<ReturnProfileDto>> Handle(GetAllFriendByProfileIdQuery query, CancellationToken cancellationToken)
            {
                var profileList = _manager.Friends.ReturnDistinct(p => p.ProfileId == query.Id, false).Include(p => p.Profile).Include(c => c.Profile.Gender);//.ToListAsync();
                if (profileList == null)
                {
                    return null;
                }
                var profileListDto = _mapper.Map<IEnumerable<ReturnProfileDto>>(profileList);
                return profileListDto;
            }
        }
    }
}

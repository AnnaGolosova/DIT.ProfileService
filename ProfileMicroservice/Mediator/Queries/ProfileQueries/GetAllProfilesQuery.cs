using AutoMapper;
using Entities.Models;
using Entities.ModelsDto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Repository.Manager;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Queries.ProfileQuery
{
    public class GetAllProfilesQuery : IRequest<IEnumerable<ReturnProfileDto>>
    {
        public class GetAllProfilesQueryHandler : IRequestHandler<GetAllProfilesQuery, IEnumerable<ReturnProfileDto>>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public GetAllProfilesQueryHandler(IMapper mapper, IRepositoryManager manager)
            {
                _mapper = mapper;
                _manager = manager;
            }
            public async Task<IEnumerable<ReturnProfileDto>> Handle(GetAllProfilesQuery query, CancellationToken cancellationToken)
            {
                var profileList = _manager.Profiles.ReturnAll(false).Include(p => p.Gender);//.ToListAsync();
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

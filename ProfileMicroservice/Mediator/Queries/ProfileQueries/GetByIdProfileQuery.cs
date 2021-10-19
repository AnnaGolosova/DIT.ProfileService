using AutoMapper;
using Entities.ModelsDto;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Repository.Manager;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Queries.ProfileQueries
{
    public class GetByIdProfileQuery : IRequest<ReturnProfileDto>
    {
        public Guid Id { get; set; }
        public class GetProfileByIdQueryHandler : IRequestHandler<GetByIdProfileQuery, ReturnProfileDto>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public GetProfileByIdQueryHandler(IMapper mapper, IRepositoryManager manager)
            {
                _mapper = mapper;
                _manager = manager;
            }
            public async Task<ReturnProfileDto> Handle(GetByIdProfileQuery query, CancellationToken cancellationToken)
            {
                var profile = _manager.Profiles.ReturnDistinct(p => p.Id == query.Id, false).Include(p => p.Gender).SingleOrDefault();

                var profileDto = _mapper.Map<ReturnProfileDto>(profile);

                return (profileDto);
            }
        }
    }
}

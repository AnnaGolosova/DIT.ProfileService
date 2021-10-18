using Entities.Models;
using MediatR;
using Repository.Manager;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    public class GetAllProfilesQuery : IRequest<IEnumerable<Profile>>
    {
        public class GetAllProfilesQueryHandler : IRequestHandler<GetAllProfilesQuery, IEnumerable<Profile>>
        {
            private readonly IRepositoryManager _manager;
            public GetAllProfilesQueryHandler(IRepositoryManager manager)
            {
                _manager = manager;
            }
            public async Task<IEnumerable<Profile>> Handle(GetAllProfilesQuery query, CancellationToken cancellationToken)
            {
                var productList = _manager.Profiles.ReturnAll(false);//.ToListAsync();
                if (productList == null)
                {
                    return null;
                }
                return productList;
            }
        }
    }
}

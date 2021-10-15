using Context;
using Entities.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProfileMicroservice.Mediator
{
    public class GetAllProfilesQuery : IRequest<IEnumerable<Profile>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProfilesQuery, IEnumerable<Profile>>
        {
            private readonly ProfileContext _context;
            public GetAllProductsQueryHandler(ProfileContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Profile>> Handle(GetAllProfilesQuery query, CancellationToken cancellationToken)
            {
                var productList = await _context.Profiles.ToListAsync();
                if (productList == null)
                {
                    return null;
                }
                return productList.AsReadOnly();
            }
        }
    }
}

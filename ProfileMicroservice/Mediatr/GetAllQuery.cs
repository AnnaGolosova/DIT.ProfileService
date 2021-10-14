using Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    public class GetAllQuery<T> : IRequest<IEnumerable<T>>
    {
        public class GetAllQueryHandler<T> : IRequestHandler<GetAllQuery<T>, IEnumerable<T>> where T : class
        {
            private readonly ProfileContext _context;
            public GetAllQueryHandler(ProfileContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<T>> Handle(GetAllQuery<T> query, CancellationToken cancellationToken)
            {
                var productList = _context.Set<T>();
                if (productList == null)
                {
                    return null;
                }
                return productList;
            }
        }
    }
}

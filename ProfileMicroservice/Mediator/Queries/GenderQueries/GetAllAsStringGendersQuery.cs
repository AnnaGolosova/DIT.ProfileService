using AutoMapper;
using Entities.ModelsDto;
using MediatR;
using Repository.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Queries.GenderQueries
{
    public class GetAllAsStringGendersQuery : IRequest<IEnumerable<string>>
    {
        public class GetAllAsStringGendersQueryHandler : IRequestHandler<GetAllAsStringGendersQuery, IEnumerable<string>>
        {
            private readonly IRepositoryManager _manager;
            private readonly IMapper _mapper;
            public GetAllAsStringGendersQueryHandler(IMapper mapper, IRepositoryManager manager)
            {

                _mapper = mapper;
                _manager = manager;
            }
            public async Task<IEnumerable<string>> Handle(GetAllAsStringGendersQuery query, CancellationToken cancellationToken)
            {
                var genderList = _manager.Genders.ReturnAll(false);
                if (genderList == null)
                {
                    return null;
                }
                List<string> genders = new List<string>();
                foreach(var gender in genderList)
                {
                    genders.Add(gender.Title);
                }
                return genders;
            }
        }
    }
}


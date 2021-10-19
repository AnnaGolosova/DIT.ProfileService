using Context;
using Entities.Models;

namespace Repository.Repositories
{
    public class GenderRepository : BaseRepository<Gender>, IGenderRepository
    {
        public GenderRepository(ProfileContext context) : base(context)
        {

        }
    }
}

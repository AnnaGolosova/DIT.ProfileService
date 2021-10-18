using Context;
using Entities.Models;

namespace Repository.Repositories
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(ProfileContext context) : base(context)
        {

        }
    }
}

using Context;
using Repository.Manager;
using Repository.Repositories;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private IProfileRepository _profileRepository;
        private ProfileContext _context;

        public RepositoryManager(ProfileContext context)
        {
            _context = context;
        }

        public IProfileRepository Profiles
        {
            get
            {
                if (_profileRepository == null)
                    _profileRepository = new ProfileRepository(_context);
                return _profileRepository;
            }
        }
    }
}

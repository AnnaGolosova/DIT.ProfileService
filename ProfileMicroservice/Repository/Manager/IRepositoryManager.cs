using Repository.Repositories;

namespace Repository.Manager
{
    public interface IRepositoryManager
    {
        IProfileRepository Profiles { get; }
        IGenderRepository Genders { get; }
        IFriendRepository Friends { get; }
    }
}

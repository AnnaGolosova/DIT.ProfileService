using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Manager
{
    public interface IRepositoryManager
    {
        IProfileRepository Profiles { get; }
    }
}

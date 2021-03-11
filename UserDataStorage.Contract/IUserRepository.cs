using Kukshaus.InTime.Data.DataStorage.Contract;
using Kukshaus.InTime.Data.UserDataStorage.Contract.DataClasses;

namespace Kukshaus.InTime.Data.UserDataStorage.Contract
{
    public interface IUserRepository : IRepository<UserDto>
    {
    }
}
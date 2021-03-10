using System.Collections.Generic;
using Kukshaus.InTime.Data.UserDataStorage.Contract;
using Kukshaus.InTime.Data.UserDataStorage.Contract.DataClasses;

namespace Kukshaus.InTime.Data.UserDataStorage.InMemory
{
    public class InMemoryUserRepository : IUserRepository
    {
        public List<UserDto> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
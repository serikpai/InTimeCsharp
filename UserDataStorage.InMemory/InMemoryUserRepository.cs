using System;
using System.Collections.Generic;
using Kukshaus.InTime.Data.UserDataStorage.Contract;
using Kukshaus.InTime.Data.UserDataStorage.Contract.DataClasses;

namespace Kukshaus.InTime.Data.UserDataStorage.InMemory
{
    public class InMemoryUserRepository : IUserRepository
    {
        public IReadOnlyList<UserDto> GetAll()
        {
            return new List<UserDto>();
        }

        public void Create(UserDto dto)
        {
        }

        public void Update(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public void Remove(UserDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
using System.Collections.Generic;

namespace Kukshaus.InTime.Data.DataStorage.Contract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
    }
}
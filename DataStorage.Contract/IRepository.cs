using System.Collections.Generic;

namespace Kukshaus.InTime.Data.DataStorage.Contract
{
    public interface IRepository<T>
    {
        IReadOnlyList<T> GetAll();

        void Create(T dto);
        void Update(T dto);
        void Remove(T dto);
    }
}
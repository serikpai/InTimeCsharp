using System.Collections.Generic;
using System.Linq;
using Kukshaus.InTime.Data.IssueDataStorage.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.Contract.DataClasses;

namespace Kukshaus.InTime.Data.IssueDataStorage.InMemory
{
    public sealed class InMemoryIssueRepository : IIssueRepository
    {
        private readonly List<IssueDto> _dataStore = new List<IssueDto>();
        
        public IReadOnlyList<IssueDto> GetAll()
            => _dataStore;

        public void Create(IssueDto dto)
            => _dataStore.Add(dto);

        public void Update(IssueDto dto)
        {
            Remove(dto);
            Create(dto);
        }

        public void Remove(IssueDto dto)
        {
            var needle = _dataStore.FirstOrDefault(x => x.Id == dto.Id);
            var wasFound = needle != null;
            
            if (wasFound)
            {
                _dataStore.Remove(needle);
            }
        }
    }
}
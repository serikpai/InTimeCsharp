using System.Collections.Generic;
using Kukshaus.InTime.Data.IssueDataStorage.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.Contract.DataClasses;

namespace Kukshaus.InTime.Data.IssueDataStorage.InMemory
{
    public sealed class InMemoryIssueRepository : IIssueRepository
    {
        private readonly List<IssueDto> _dataStore = new List<IssueDto>();
        
        public IReadOnlyList<IssueDto> GetAll()
        {
            return _dataStore;
        }

        public void Create(IssueDto dto)
        {
            _dataStore.Add(dto);
        }
    }
}
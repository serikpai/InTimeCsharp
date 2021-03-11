using System.Collections.Generic;
using Kukshaus.InTime.Data.IssueDataStorage.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.Contract.DataClasses;

namespace Kukshaus.InTime.Data.IssueDataStorage.InMemory
{
    public class InMemoryProjectVersionRepository : IProjectVersionRepository
    {
        public IReadOnlyList<ProjectVersionDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Create(ProjectVersionDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
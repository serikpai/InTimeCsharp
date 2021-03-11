using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.CrossCutting.StaticProxying.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.Contract.DataClasses;
using Kukshaus.InTime.Logic.IssueManagement.Contract;

namespace Kukshaus.InTime.Logic.IssueManagement
{
    public class IssueManager : IIssueManager
    {
        private readonly IIssueRepository _issueRepository;
        private readonly IGuidProxy _guidProxy;

        public IssueManager(IIssueRepository issueRepository,
            IGuidProxy guidProxy)
        {
            _issueRepository = issueRepository;
            _guidProxy = guidProxy;
        }

        public void CreateIssue(Issue issue)
        {
            _issueRepository.Create(new IssueDto
            {
                Id = _guidProxy.NewGuid(),
                Name = issue.Name,
                Description = issue.Description,
            });
        }
    }
}
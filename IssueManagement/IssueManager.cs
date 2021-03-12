using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects;
using Kukshaus.InTime.CrossCutting.StaticProxying.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.Contract;
using Kukshaus.InTime.Data.IssueDataStorage.Contract.DataClasses;
using Kukshaus.InTime.Logic.IssueManagement.Contract;

namespace Kukshaus.InTime.Logic.IssueManagement
{
    public sealed class IssueManager : IIssueManager
    {
        private readonly IDateTimeProxy _dateTimeProxy;
        private readonly IGuidProxy _guidProxy;
        private readonly IIssueRepository _issueRepository;

        public IssueManager(IIssueRepository issueRepository,
            IGuidProxy guidProxy, IDateTimeProxy dateTimeProxy)
        {
            _issueRepository = issueRepository;
            _guidProxy = guidProxy;
            _dateTimeProxy = dateTimeProxy;
        }

        public IReadOnlyList<Issue> GetUnresolvedIssues()
            => _issueRepository.GetAll()
                .Where(x => x.Status < IssueStatus.Done)
                .OrderBy(x => x.CreationTime)
                .Select(ConvertFromDto).ToList();

        public void Create(Issue issue)
        {
            issue.Id = _guidProxy.NewGuid();
            issue.LastUpdate = _dateTimeProxy.Now();
            issue.CreationTime = _dateTimeProxy.Now();
            
            var dto = ConvertToDto(issue);
            _issueRepository.Create(dto);
        }

        public Issue GetById(IssueId id)
        {
            var dto = _issueRepository.GetAll()
                .First(x => x.Id == id);

            return ConvertFromDto(dto);
        }

        public void Save(Issue issue)
        {
            issue.LastUpdate = _dateTimeProxy.Now();

            var dto = ConvertToDto(issue);
            _issueRepository.Update(dto);
        }

        private Issue ConvertFromDto(IssueDto dto)
            => new Issue
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Priority = dto.Priority,
                Type = dto.Type,
                Status = dto.Status,
                CreationTime = dto.CreationTime
            };

        private IssueDto ConvertToDto(Issue issue)
            => new IssueDto
            {
                Id = issue.Id,
                CreationTime = issue.CreationTime,
                Name = issue.Name,
                Description = issue.Description,
                LastUpdate = issue.LastUpdate,

                Priority = IssuePriority.Normal,
                Type = IssueType.Task,
                Status = IssueStatus.Backlog,
            };
    }
}
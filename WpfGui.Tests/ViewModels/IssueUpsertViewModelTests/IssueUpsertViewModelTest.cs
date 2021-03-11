using System.Collections.Generic;
using Kukshaus.InTime.CrossCutting.DataClasses.Aggregates;
using Kukshaus.InTime.Gui.WpfGui.ViewModels;
using Kukshaus.InTime.Logic.IssueManagement.Contract;
using NSubstitute;
using NUnit.Framework;

namespace Kukshaus.InTime.Gui.WpfGui.Tests.ViewModels.IssueUpsertViewModelTests
{
    [TestFixture]
    public abstract class IssueUpsertViewModelTest
    {
        protected IssueUpsertViewModel ViewModel;
        protected List<Issue> CreatedIssues = new List<Issue>();

        [SetUp]
        public void Setup()
        {
            CreatedIssues.Clear();
            
            var issueManager = Substitute.For<IIssueManager>();
            issueManager
                .When(m => m.CreateIssue(Arg.Any<Issue>()))
                .Do(x => CreatedIssues.Add(x.Arg<Issue>()));

            ViewModel = new IssueUpsertViewModel(issueManager);
        }

        [TearDown]
        public void TearDown()
        {
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }
    }
}
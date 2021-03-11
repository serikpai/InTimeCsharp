using System;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;

namespace Kukshaus.InTime.Gui.WpfGui.Tests.ViewModels.IssueUpsertViewModelTests
{
    public class Create : IssueUpsertViewModelTest
    {
        [Test]
        public void NameIsEmpty_NotAllowed()
        {
            ViewModel.Invoking(vm => vm.Create())
                .Should().ThrowExactly<ArgumentException>();
        }

        [Test]
        public void NameWasSet_NoError()
        {
            ViewModel.Model.Name = "hello world";

            ViewModel.Create();

            using (new AssertionScope())
            {
                ViewModel.IsClosed.Should().BeTrue();
                
                CreatedIssues.Should().HaveCount(1);
                var issue = CreatedIssues.First();

                ((string) issue.Name).Should().Be("hello world");
                ((string) issue.Description).Should().BeEmpty();
            }
        }

        [Test]
        public void NameAndDescriptionWareSet_NoError()
        {
            ViewModel.Model.Name = "hello world";
            ViewModel.Model.Description = "Lorem ipsum...";

            ViewModel.Create();

            using (new AssertionScope())
            {
                ViewModel.IsClosed.Should().BeTrue();
                
                CreatedIssues.Should().HaveCount(1);
                var issue = CreatedIssues.First();

                ((string) issue.Name).Should().Be("hello world");
                ((string) issue.Description).Should().Be("Lorem ipsum...");
            }
        }
    }
}
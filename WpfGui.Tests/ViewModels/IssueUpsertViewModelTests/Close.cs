using FluentAssertions;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using NUnit.Framework;

namespace Kukshaus.InTime.Gui.WpfGui.Tests.ViewModels.IssueUpsertViewModelTests
{
    internal class Close : IssueUpsertViewModelTest
    {
        [Test]
        public void ModelIsDirty_CannotBeClosed()
        {
            ViewModel.Model.Name = "hello world";
            
            ViewModel.Close();
            
            ViewModel.IsClosed.Should().BeFalse();
        }
        
        [Test]
        public void ModelIsNotDirty_CanBeClosed()
        {
            ViewModel.Close();

            ViewModel.IsClosed.Should().BeTrue();
        }
    }
}
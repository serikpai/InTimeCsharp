using System;

namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public readonly struct IssueId : IValueObject
    {
        private readonly Guid _id;

        private IssueId(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("The issue id must be a valid guid.");
            }

            _id = id;
        }

        public static implicit operator IssueId(Guid id)
            => new IssueId(id);

        public static implicit operator Guid(IssueId id)
            => id._id;

        public static explicit operator string(IssueId id)
            => id._id.ToString();

        public override string ToString()
            => (string) this;

    }
}
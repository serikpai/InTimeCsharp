using System;

namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public readonly struct IssueDescription : IValueObject, IEquatable<IssueDescription>
    {
        private readonly string _description;

        private IssueDescription(string description)
        {
            _description = description;
        }

        public static implicit operator IssueDescription(string description)
        {
            return new IssueDescription(description);
        }

        public static implicit operator string(IssueDescription description)
        {
            return description._description;
        }

        public bool Equals(IssueDescription other)
        {
            return _description == other._description;
        }

        public override bool Equals(object? obj)
        {
            return obj is IssueDescription other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _description.GetHashCode();
        }

        public static bool operator ==(IssueDescription left, IssueDescription right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IssueDescription left, IssueDescription right)
        {
            return !left.Equals(right);
        }
    }
}
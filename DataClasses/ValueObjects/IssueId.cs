using System;

namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public struct IssueId : IValueObject, IEquatable<IssueId> /*IEquatable<IssueId>*/
    {
        private readonly int _id;

        private IssueId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("The issue id must be a positive number.");
            }

            _id = id;
        }

        public int GetTheId()
        {
            return _id;
        }

        public static implicit operator IssueId(int id)
        {
            return new IssueId(id);
        }

        public static explicit operator int(IssueId id)
        {
            return id._id;
        }

        public static explicit operator string(IssueId id)
        {
            return id._id.ToString();
        }
        
        public bool Equals(IssueId other)
        {
            return _id == other._id;
        }

        public override bool Equals(object obj)
        {
            return obj is IssueId other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public static bool operator ==(IssueId a, IssueId b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(IssueId a, IssueId b)
        {
            return !Equals(a, b);
        }

        public override string ToString()
        {
            return (string)this;
        }
    }
}
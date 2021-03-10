using System;

namespace InTime.CrossCutting.DataClasses.ValueObjects
{
    public struct CommentId : ILocalEntity, IEquatable<CommentId>
    {
        private readonly int _id;

        private CommentId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("The comment id must be a positive number");
            }

            _id = id;
        }

        public int GetTheId()
        {
            return _id;
        }

        public static implicit operator CommentId(int id)
        {
            return new CommentId(id);
        }

        public static explicit operator int(CommentId id)
        {
            return id._id;
        }

        public static explicit operator string(CommentId id)
        {
            return id._id.ToString();
        }

        public bool Equals(CommentId other)
        {
            return _id == (int)other;
        }

        public override bool Equals(object obj)
        {
            return obj is CommentId other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        public static bool operator ==(CommentId a, CommentId b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(CommentId a, CommentId b)
        {
            return !Equals(a, b);
        }

        public override string ToString()
        {
            return (string)this;
        }
    }
}
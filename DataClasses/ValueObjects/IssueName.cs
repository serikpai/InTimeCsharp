using System;

namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public struct IssueName : IValueObject, IEquatable<IssueName>
    {
        private readonly string _name;

        private IssueName(string name)
        {
            _name = name;
        }

        public static implicit operator IssueName(string name)
        {
            return new IssueName(name);
        }

        public bool Equals(IssueName other)
        {
            return _name == other._name;
        }

        public override bool Equals(object obj)
        {
            return obj is IssueName other && Equals(other);
        }

        public override int GetHashCode()
        {
            return (_name != null ? _name.GetHashCode() : 0);
        }

        public static bool operator ==(IssueName left, IssueName right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IssueName left, IssueName right)
        {
            return !left.Equals(right);
        }
    }
}
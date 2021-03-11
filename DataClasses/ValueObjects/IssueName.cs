using System;

namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public readonly struct IssueName : IValueObject, IEquatable<IssueName>
    {
        private readonly string _name;

        private IssueName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Issue name cannot be empty.", nameof(name));
            }

            _name = name;
        }

        public static implicit operator IssueName(string name)
            => new IssueName(name);

        public static implicit operator string(IssueName name)
            => name._name;

        public bool Equals(IssueName other)
            => _name == other._name;

        public override bool Equals(object? obj)
            => obj is IssueName other && Equals(other);

        public override int GetHashCode()
            => _name.GetHashCode();

        public static bool operator ==(IssueName left, IssueName right)
            => left.Equals(right);

        public static bool operator !=(IssueName left, IssueName right)
            => !left.Equals(right);
    }
}
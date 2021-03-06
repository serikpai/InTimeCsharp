﻿namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public readonly struct IssuePriority
    {
        private readonly int _priority;

        public static IssuePriority Blocker { get; } = new IssuePriority(1);
        public static IssuePriority High { get; } = new IssuePriority(2);
        public static IssuePriority Normal { get; } = new IssuePriority(3);
        public static IssuePriority Low { get; } = new IssuePriority(4);

        private IssuePriority(int priority)
            => _priority = priority;

        public static implicit operator int(IssuePriority priority)
            => priority._priority;

        public static implicit operator IssuePriority(int priority)
            => new IssuePriority(priority);
    }
}
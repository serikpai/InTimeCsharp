using System;

namespace Kukshaus.InTime.CrossCutting.DataClasses.ValueObjects
{
    public class ProjectVersionId
    {
        private readonly int _id;

        public ProjectVersionId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("The version id must be a positive number.");
            }

            _id = id;
        }

        public int GetTheId()
        {
            return _id;
        }
    }
}
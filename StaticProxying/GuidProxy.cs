using System;
using Kukshaus.InTime.CrossCutting.StaticProxying.Contract;

namespace Kukshaus.InTime.CrossCutting.StaticProxying
{
    public class GuidProxy : IGuidProxy
    {
        public Guid NewGuid()
        {
            return Guid.NewGuid();
        }
    }
}
using System;

namespace Kukshaus.InTime.CrossCutting.StaticProxying.Contract
{
    public interface IGuidProxy
    {
        Guid NewGuid();
    }
}
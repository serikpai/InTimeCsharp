using System;

namespace Kukshaus.InTime.CrossCutting.StaticProxying.Contract
{
    public interface IDateTimeProxy
    {
        DateTime Now();
    }
}
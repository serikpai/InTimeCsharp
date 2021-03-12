using System;
using Kukshaus.InTime.CrossCutting.StaticProxying.Contract;

namespace Kukshaus.InTime.CrossCutting.StaticProxying
{
    public class DateTimeProxy : IDateTimeProxy
    {
        public DateTime Now()
            => DateTime.Now;
    }
}
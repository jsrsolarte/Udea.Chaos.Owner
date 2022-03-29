using System;

namespace Udea.Chaos.Owner.Domain.Services
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DomainServiceAttribute : Attribute
    {
    }
}
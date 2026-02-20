using System;

namespace Shinject.Activation
{
    public interface IRootedProvider : IProvider
    {
        Guid KernerId { get; }
    }
}
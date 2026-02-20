using System;

namespace Shinject
{
    public interface IKernelWithId : IKernel
    {
        Guid Id { get; }
    }
}
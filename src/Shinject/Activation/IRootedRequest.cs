using System;

namespace Shinject.Activation
{
    public interface IRootedRequest : IRequest
    {
        Guid RequestingKernelId { get; }

        RootedResolutionStrategy Strategy { get; }
    }
}
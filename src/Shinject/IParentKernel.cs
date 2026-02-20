using System.Collections.Generic;
using Shinject.Syntax;

namespace Shinject
{
    public interface IParentKernel : IKernelWithId
    {
        IReadOnlyCollection<IResolutionRoot> Children { get; }
    }
}
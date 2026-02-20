#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using Shinject.Activation;
using Shinject.Activation.Providers;
using Shinject.Components;
using Shinject.Planning.Bindings.Resolvers;
#endregion

namespace Shinject.Planning.Bindings
{
    public class RootedMissingBindingResolver : NinjectComponent,
                                                IMissingBindingResolver
    {
        #region Methods
        /// <inheritdoc />
        public ICollection<IBinding> Resolve(IDictionary<Type, ICollection<IBinding>> bindings,
                                              IRequest request)
        {
            var service = request.Service;
            if (request is not IRootedRequest rootedRequest ||
                !bindings.TryGetValue(service, out var sb))
                return Array.Empty<IBinding>();

            var tmp = sb.Where(b => b.Metadata.Has("kernelId")).ToArray();
            if (tmp.Length > 0) return tmp;

            var kernelId = rootedRequest.RequestingKernelId;
            var b = new Binding(service)
            {
                ProviderCallback = RootedProvider.GetCreationCallback(service, kernelId)
            };
            b.Metadata.Set("kernelId", kernelId);

            return new[]
                    {
                        b
                    };

        }
        #endregion
    }
}
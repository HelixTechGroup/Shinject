using System;
using System.Collections.Generic;
using System.Linq;
using Shinject.Components;
using Shinject.Planning.Bindings.Resolvers;

namespace Shinject.Planning.Bindings
{
    public class RootedBindingResolver : NinjectComponent, IBindingResolver
    {
        /// <inheritdoc />
        public ICollection<IBinding> Resolve(IDictionary<Type, ICollection<IBinding>> bindings,
                                             Type service)
        {
            //if (request is IRootedRequest rootedRequest)
            //{
            if (bindings.TryGetValue(service, out var b))
                return b.Where(b => b.Metadata.Has("kernelId"))
                    .ToArray();
            //}

            return Array.Empty<IBinding>();
        }
    }
}
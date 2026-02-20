using Shinject.Tests.Fakes;

namespace Shinject.Tests.Unit
{
    using System;
    using FluentAssertions;
    using Shinject.Parameters;
    using Shinject.Tests.Fakes;
    using Xunit;

    public class TypeMatchingConstructorArgumentTest : IDisposable
    {
        [Fact]
        public void InstancesAreEqualIfTypeIsEqual()
        {
            var firstInstance = new TypeMatchingConstructorArgument(typeof(Samurai), (context, target) => null);
            var secondInstance = new TypeMatchingConstructorArgument(typeof(Samurai), (context, target) => null);

            var result = firstInstance.Equals(secondInstance);

            result.Should().BeTrue();
        }

        [Fact]
        public void InstancesAreNotEqual()
        {
            var firstInstance = new TypeMatchingConstructorArgument(typeof(Samurai), (context, target) => null);
            var secondInstance = new TypeMatchingConstructorArgument(typeof(Ninja), (context, target) => null);

            var result = firstInstance.Equals(secondInstance);

            result.Should().BeFalse();
        }

        public void Dispose()
        {
        }
    }
}
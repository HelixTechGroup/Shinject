namespace Shinject.Tests.Unit.Activation
{
    using Shinject.Activation;
    using Shinject.Parameters;
    using Shinject.Planning.Bindings;
    using System;
    using Xunit;

    public class RequestTests
    {
        [Fact]
        public void Constructor_ShouldThrowArgumentNullExceptionWhenServiceIsNull()
        {
            const Type service = null;
            Func<IBindingMetadata, bool> constraint = bindingMetadata => true;
            var parameters = new IParameter[0];
            Func<object> scopeCallback = () => { return null; };

            var actual = Assert.Throws<ArgumentNullException>(()
                => new Request(service, constraint, parameters, scopeCallback, false, false));

            Assert.Null(actual.InnerException);
            Assert.Equal(nameof(service), actual.ParamName);
        }

        [Fact]
        public void Constructor_ShouldThrowArgumentNullExceptionWhenParametersIsNull()
        {
            var service = typeof(RequestTests);
            Func<IBindingMetadata, bool> constraint = bindingMetadata => true;
            IParameter[] parameters = null;
            Func<object> scopeCallback = () => { return null; };

            var actual = Assert.Throws<ArgumentNullException>(()
                => new Request(service, constraint, parameters, scopeCallback, false, false));

            Assert.Null(actual.InnerException);
            Assert.Equal(nameof(parameters), actual.ParamName);
        }
    }
}

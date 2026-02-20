namespace Shinject.Tests.Fakes
{
    using System;
    using Shinject.Infrastructure.Disposal;

    public class NotifiesWhenDisposed : DisposableObject, INotifyWhenDisposed
    {
    }
}
namespace Shinject
{
    public interface IRootedKernel : IRootKernel, IChildKernel
    {
        IRootKernel Root { get; }
    }
}
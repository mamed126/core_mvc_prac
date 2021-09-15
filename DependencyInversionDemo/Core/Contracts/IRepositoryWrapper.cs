namespace DependencyInversionDemo.Core.Contracts
{
    public interface IRepositoryWrapper
    {
        IRepositoryLoclDb RepositoryLocalDb { get; }
    }
}

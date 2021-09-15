using DependencyInversionDemo.Core.Contracts;

namespace DependencyInversionDemo.Data
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private  IRepositoryLoclDb _localDbRepo =null;
        public IRepositoryLoclDb RepositoryLocalDb
        {
            get {

                if (_localDbRepo == null)
                    _localDbRepo = new RepositoryLocalDb();
                return _localDbRepo;
            
            }
        }
    }
}

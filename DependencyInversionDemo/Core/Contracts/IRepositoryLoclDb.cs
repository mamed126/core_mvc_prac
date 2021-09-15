using System.Collections.Generic;

namespace DependencyInversionDemo.Core.Contracts
{
    public interface IRepositoryLoclDb
    {
        void Add(string data);
        void Delete(int pos);
        List<string> GetData();
        void Update(int pos, string data);
    }
}

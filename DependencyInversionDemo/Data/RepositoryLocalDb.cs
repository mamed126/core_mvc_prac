using DependencyInversionDemo.Core.Contracts;
using System.Collections.Generic;

namespace DependencyInversionDemo.Data
{
    public class RepositoryLocalDb : IRepositoryLoclDb
    {
        public void Add(string data)
        {
            LocalDb.Add(data);
        }

        public void Delete(int pos)
        {
            LocalDb.Delete(pos);
        }

        public List<string> GetData()
        {
            return LocalDb.GetDb();
        }

        public void Update(int pos, string data)
        {
            LocalDb.Update(pos, data);
        }
    }
}

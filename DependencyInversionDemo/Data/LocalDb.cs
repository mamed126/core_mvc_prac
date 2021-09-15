using System.Collections.Generic;

namespace DependencyInversionDemo.Data
{
    public static class LocalDb
    {
        private static List<string> _db = new List<string> { "item1", "item2" };
        public static List<string> GetDb()
        {
            return _db;
        }
        public static void Add(string data)
        {
            _db.Add(data);
        }

        public static void Delete(int index)
        {
            _db.RemoveAt(index);
        }

        public static void Update(int index, string data)
        {
            _db[index] = data;
        }
    }
}

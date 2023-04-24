using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LevelDB;
using Domain;
namespace Infrastructure.Data
{
    public class LinkDbContext : IUnitOfWork, IDisposable
    {
        private static DB db;

        public LinkDbContext()
        {
            if (db == null)
            {
                var options = new Options { CreateIfMissing = true };
                db = new DB(options, "links.db");
            }
        }
        public async Task<bool> Set(Link obj)
        {
            db.Put(obj.ShortUrl, obj.Url);
            return true;
        }
        public async Task<Link> Get(string key)
        {
            string s = db.Get(key);
            return Link.CreateUrl(s, key, 0);
        }

        public void Dispose()
        {
            if (db != null)
            {
                db.Close();
            }
        }
    }
}
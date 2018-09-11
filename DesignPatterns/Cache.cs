using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Cache
    {
        private const string CacheKey = "availableHotel";

        public IEnumerable GetAvailableHotel()
        {
            ObjectCache cache = MemoryCache.Default;

            if (cache.Contains(CacheKey))
            {
                Console.WriteLine("<-------------->");
                Console.WriteLine("Data in cache");
                Console.WriteLine("<-------------->");
                return (IEnumerable)cache.Get(CacheKey);
            }
            else
            {
                IEnumerable availableStocks = this.GetAvailableFromDB();
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddHours(1.0);
                cache.Add(CacheKey, availableStocks, cacheItemPolicy);

                return availableStocks;
            }
        }
        public IEnumerable GetAvailableFromDB()
        {
            SqlDataBase extracter = new SqlDataBase();
            List<Product> data =extracter.GetAllDetails();
            return data;

        }
    }
}

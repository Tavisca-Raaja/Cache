using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Cache storage = new Cache();
            var DataBaseData = storage.GetAvailableHotel();
            //extracting from database
            foreach(Product entity in DataBaseData)
            {
                Console.WriteLine("Hotel Name:"+entity.Name);
                Console.WriteLine("Hotel Id:" + entity.Id);
                Console.WriteLine("Room Rate:" + entity.Fare);
                Console.WriteLine("<------------------->");
            }
            //extracting from cache
            var CacheData = storage.GetAvailableHotel();
            foreach (Product entity in CacheData)
            {
                Console.WriteLine("Hotel Name:" + entity.Name);
                Console.WriteLine("Hotel Id:" + entity.Id);
                Console.WriteLine("Room Rate:" + entity.Fare);
                Console.WriteLine("<------------------->");
            }


            Console.ReadKey();
        }
    }
}

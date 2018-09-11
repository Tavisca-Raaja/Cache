using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ActivityProduct : Product
    {
        private string _ProductName = "cinemas";
        private Decimal _Fare = 1000;
        private bool _IsBooked = false;

        public string Name { get{ return _ProductName; } set { _ProductName = value; } }
        public Decimal Fare { get { return _Fare; } set { _Fare = value; } }
        public bool status { get { return _IsBooked; } set { _IsBooked = value; } }

        public string type { get { return "ActicityProduct"; } }
      
 
    }
}
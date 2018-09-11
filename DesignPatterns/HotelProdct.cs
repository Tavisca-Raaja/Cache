using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class HotelProduct : Product
    {
        private string _ProductName = "Hyatt";
        private Decimal _Fare = 90000;
        private bool _IsBooked = false;

        public string Name { get { return _ProductName; } set { _ProductName = value; } }
        public Decimal Fare { get { return _Fare; } set { _Fare = value; } }
        public bool status { get { return _IsBooked; } set { _IsBooked = value; } }

        public string type { get { return "HotelProduct"; } }
    }
}
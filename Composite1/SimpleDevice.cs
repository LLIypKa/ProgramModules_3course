using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite1
{
    class SimpleDevice: Device
    {
        private string _name;
        private int _price;

        public override string GetName()
        {
            return _name;
        }

        public override int GetTotalPrice()
        {
            return _price;
        }

        public SimpleDevice(string name, int price)
        {
            _name = name;
            _price = price;
        }
    }
}

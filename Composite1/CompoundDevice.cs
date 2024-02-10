using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite1
{
    class CompoundDevice: Device
    {
        private string _name;
        private int _price;
        private List<Device> _components = new List<Device>();

        public override void Add(Device d)
        {
            _components.Add(d);
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetTotalPrice()
        {
            return _price + HelpOperation();
        }

        private int HelpOperation()
        {
            int fullPrice = 0;

            foreach (Device d in _components) fullPrice += d.GetTotalPrice();

            return fullPrice;
            
        }

        public CompoundDevice(string name, int price)
        {
            _name = name;
            _price = price;
        }
    }
}

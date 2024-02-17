using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConcretePrototype2: Prototype
    {
        private string _data;
        private int _id;

        public override void ChangeId(int id)
        {
            _id = id;
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(_data, _id);
        }

        public override string GetInfo()
        {
            return "CP2 = " + _data + " = " + Convert.ToString(_id);
        }

        public ConcretePrototype2(string data, int id)
        {
            _data = data;
            _id = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod_02
{
    class ConcreteCreator2 : ConcreteCreator1
    {
        public override ConcreteProduct1 factoryMethod(string info)
        {
            return new ConcreteProduct2(info);
        }
    }
}

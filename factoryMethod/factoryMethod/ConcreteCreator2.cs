using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    class ConcreteCreator2: Creator
    {
        public override ConcreteProduct2 factoryMethod(string info)
        {
            return new ConcreteProduct2(info);
        }
        public override string AnOperation(string info)
        {
            ConcreteProduct2 pr1 = factoryMethod(info);
            pr1.Transform();
            pr1.Transform();
            return pr1.GetInfo(pr1.info);
        }
    }
}

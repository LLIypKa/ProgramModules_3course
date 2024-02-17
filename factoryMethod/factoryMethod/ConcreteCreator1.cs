using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    class ConcreteCreator1: Creator
    {
        public override ConcreteProduct1 factoryMethod(string info)
        {
            return new ConcreteProduct1(info);
        }
        public override string AnOperation(string info)
        {
            ConcreteProduct1 pr1 = factoryMethod(info);
            pr1.Transform();
            pr1.Transform();
            return pr1.GetInfo(pr1.info);
        }
    }
}

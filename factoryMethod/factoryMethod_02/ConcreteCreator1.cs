using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod_02
{
    class ConcreteCreator1
    {
        public virtual ConcreteProduct1 factoryMethod(string info)
        {
            return new ConcreteProduct1(info);
        }
        public string AnOperation(string info)
        {
            ConcreteProduct1 pr = factoryMethod(info);
            pr.Transform();
            pr.Transform();
            return pr.GetInfo(pr.info);
        }
    }
}

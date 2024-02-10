using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factory2 : AbstractFactory
    {
        private int _variableA, _variableB;
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2(_variableA);
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2(_variableB);
        }

        public Factory2(int inf1, int inf2)
        {
            _variableA = inf1;
            _variableB = inf2;
        }
    }
}

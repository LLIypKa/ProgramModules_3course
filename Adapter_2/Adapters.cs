using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    class Adapters: Target, IAdapteeInterface
    {
        public override int GetA()
        {
            return IAdapteeInterface._a;
        }

        public override int GetB()
        {
            return IAdapteeInterface._b;
        }

        public override int Request()
        {
            return IAdapteeInterface._a * IAdapteeInterface._b;
        }

        public Adapters(int a, int b)
        {
            IAdapteeInterface._a = a;
            IAdapteeInterface._b = b;
        }
    }
}

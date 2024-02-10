using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_2
{
    interface IAdapteeInterface
    {
        static protected int _a;
        static protected int _b;

        public int[] GetAll()
        {
            return new int[] { _a, _b };
        }

        public int SpecificRequest()
        {
            return _a * _b;
        }
    }
}

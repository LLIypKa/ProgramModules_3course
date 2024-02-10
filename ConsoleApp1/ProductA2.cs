using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductA2 : AbstractProductA
    {
        private string _info;

        public override void A()
        {
            _info = _info + _info;
        }

        public override string GetInfo()
        {
            return _info;
        }

        public ProductA2(int inf)
        {
            _info = Convert.ToString(inf);
        }
    }
}

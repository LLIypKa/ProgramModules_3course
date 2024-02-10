using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductA1: AbstractProductA
    {
        private string _info;

        public override void A()
        {
            _info = Convert.ToString(Int32.Parse(_info) * 2);
        }

        public override string GetInfo()
        {
            return _info;
        }

        public ProductA1(int inf)
        {
            _info = Convert.ToString(inf);
        }
    }
}

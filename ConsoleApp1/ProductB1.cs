using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductB1: AbstractProductB
    {
        private string _info;

        public override void B(AbstractProductA obj)
        {
            _info = Convert.ToString(Int32.Parse(_info) + Int32.Parse(obj.GetInfo()));
        }

        public override string GetInfo()
        {
            return _info;
        }

        public ProductB1(int inf)
        {
            _info = Convert.ToString(inf);  
        }
    }
}

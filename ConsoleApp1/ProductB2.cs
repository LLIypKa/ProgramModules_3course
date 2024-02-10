using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductB2 : AbstractProductB
    {
        private string _info;

        public override void B(AbstractProductA obj)
        {
            _info += obj.GetInfo();
        }

        public override string GetInfo()
        {
            return _info;
        }

        public ProductB2(int inf)
        {
            _info = Convert.ToString(inf);
        }
    }
}

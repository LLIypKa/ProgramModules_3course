using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adapters: Target
    {
        private Adaptee _ad;

        public override int GetA()
        {
            return _ad.GetAll()[0];
        }

        public override int GetB()
        {
            return _ad.GetAll()[1];
        }

        public override int Request()
        {
            return _ad.SpecificRequest();
        }

        public Adapters(int a, int b)
        {
            _ad = new Adaptee(a, b);
        }
    }
}

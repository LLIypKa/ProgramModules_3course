using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi
{
    class RealSubject: Subject
    {
        public override string RequestA()
        {
            return "A(real)";
        }

        public override string RequestB()
        {
            return "B(real)";
        }

        public override string RequestC()
        {
            return "C(real)";
        }

        public override string RequestD()
        {
            return "D(real)";
        }
    }
}

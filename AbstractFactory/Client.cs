using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private ControlFactory _factory;

        public ControlFactory Factory { get { return _factory; } set { _factory = value; } }

        public Client(ControlFactory f) 
        {
            _factory = f;
        }
    }
}

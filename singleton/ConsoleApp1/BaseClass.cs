using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class BaseClass
    {
        private int _data = 0;

        public void IncData(int increment)
        {
            _data += increment;
        }

        public int GetData() 
        { 
            return _data; 
        } 
    }
}

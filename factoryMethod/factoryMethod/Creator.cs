using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    abstract class Creator
    {
        public abstract Product factoryMethod(string info);

        public abstract string AnOperation(string info);
    }
}

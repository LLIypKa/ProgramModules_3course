using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    abstract class Product
    {
        public abstract string GetInfo(string str);
        public abstract void Transform();
    }
}

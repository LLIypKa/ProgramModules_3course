using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Prototype
    {
        abstract public Prototype Clone();

        abstract public string GetInfo();

        abstract public void ChangeId(int id);

        public Prototype() { }
    }
}

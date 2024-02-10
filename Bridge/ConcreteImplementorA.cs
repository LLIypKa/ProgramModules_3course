using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImplementorA: Implementor
    {
        public override string DrawLine(int size)
        {
            string line = "";

            for (int i = 0; i < size; i++)
            {
                line += "-";
            }

            return line;
        }

        public override string DrawText(string text)
        {
            return text.ToLower();
        }

        public ConcreteImplementorA()
        {
            
        }
    }
}
